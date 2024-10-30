using MCISBCWebApp.Models;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Linq;

namespace MCISBCWebApp.Services
{
    public class ComplaintService
    {
        static IOrganizationService organizationService = null;
        private readonly AuthService authService;

        public ComplaintService()
        {
            authService = new AuthService();
            organizationService = authService.ConnectCrmOrgService();
        }

        public string CreateComplaint(ComplaintModel complaint)
        {
            try
            {
                // Create a new complaint entity
                Entity complaintEntity = new Entity("incident");

                // Set the attributes of the complaint entity
                complaintEntity["mci_customername"] = new EntityReference("contact", new Guid(complaint.CustomerId));
                complaintEntity["customerid"] = new EntityReference("contact", new Guid(complaint.CustomerId));
                complaintEntity["mci_idnumber"] = complaint.IdNumber;
                complaintEntity["mci_phonenumber"] = complaint.PhoneNumber;
                complaintEntity["emailaddress"] = complaint.EmailAddress;
                complaintEntity["mci_complaintdescription"] = complaint.ComplaintDescription;
                complaintEntity["mci_complaintcreationchannel"] = new OptionSetValue(10); /*SBC*/
                complaintEntity["mci_complaintcategory"] = new OptionSetValue(3);/*services*/
                complaintEntity["mci_servicemainclassification"] = new OptionSetValue(int.Parse(complaint.MainClassification));
                complaintEntity["mci_subclassification"] = new OptionSetValue(int.Parse(complaint.SubClassification));
                complaintEntity["mci_iscreated_externally"] = true;//yes
                complaintEntity["mci_complainttype"] = new OptionSetValue(5)/*Request Service*/;
                complaintEntity["mci_complaintdivision"] = new OptionSetValue(2)/*technique*/;
                complaintEntity["mci_legislatoragency"] = new EntityReference("team", new Guid("B89D83BC-7393-ED11-A33B-005056AD1B4D"))/*BO Team*/;
                complaintEntity["severitycode"] = new OptionSetValue(4)/*low*/;
                complaintEntity["mci_responsibleteam"] = new OptionSetValue(1)/*Ministry*/;

                // Create the complaint in CRM

                var createdId = organizationService.Create(complaintEntity);
                var result = organizationService.Retrieve("incident", createdId, new ColumnSet("mci_complaintnumber"));

                return result.GetAttributeValue<string>("mci_complaintnumber");
            }
            catch (Exception ex)
            {

                return null;
            }
        }


        public ComplaintViewModel GetComplaintDetails(string complaintNumber, Language lang)
        {
            try
            {
                if (string.IsNullOrEmpty(complaintNumber))
                    return null;

                var complaintQuery = new QueryExpression("incident")
                {
                    ColumnSet = new ColumnSet("mci_complaintnumber", "statecode", "mci_customername",/* "mci_idnumber", "mci_phonenumber", "emailaddress",*/ "mci_complaintdescription", "mci_complaintcreationchannel", "mci_servicemainclassification", "mci_subclassification", "mci_createdby_externally")
                };

                var filter = new FilterExpression(LogicalOperator.Or);
                filter.AddCondition("mci_complaintnumber", ConditionOperator.Equal, complaintNumber.Trim());
                filter.AddCondition("mci_complaintnumber", ConditionOperator.Like, "CAS-" + complaintNumber.Trim());


                complaintQuery.Criteria.AddCondition("mci_complaintcreationchannel", ConditionOperator.Equal, 10 /*SBC*/);
                complaintQuery.Criteria.Filters.Add(filter);
                complaintQuery.TopCount = 20;

                var result = organizationService.RetrieveMultiple(complaintQuery);
                if (result.Entities.Count > 0)
                {
                    var complaintResult = result.Entities[0];
                    if (complaintResult != null)
                    {
                        var ComplaintCreationChannelLabel = GetOptionSetLabel("incident", "mci_complaintcreationchannel", complaintResult.GetAttributeValue<OptionSetValue>("mci_complaintcreationchannel")?.Value, lang);
                        var mainClassificationLabel = GetOptionSetLabel("incident", "mci_servicemainclassification", complaintResult.GetAttributeValue<OptionSetValue>("mci_servicemainclassification")?.Value, lang);
                        var subClassificationLabel = GetOptionSetLabel("incident", "mci_subclassification", complaintResult.GetAttributeValue<OptionSetValue>("mci_subclassification")?.Value, lang);
                        var statusLabel = GetOptionSetLabel("incident", "statecode", complaintResult.GetAttributeValue<OptionSetValue>("statecode")?.Value, lang);
                        var contactId = complaintResult.GetAttributeValue<EntityReference>("mci_customername");

                        return new ComplaintViewModel
                        {
                            /*
                            //IdNumber = complaintResult.GetAttributeValue<string>("mci_idnumber"),
                            //PhoneNumber = complaintResult.GetAttributeValue<string>("mci_phonenumber"),
                            //EmailAddress = complaintResult.GetAttributeValue<string>("emailaddress"),
                            */
                            ComplaintDescription = complaintResult.GetAttributeValue<string>("mci_complaintdescription"),
                            ComplaintCreationChannel = ComplaintCreationChannelLabel,
                            MainClassification = new SelectItem
                            {
                                Id = (complaintResult.GetAttributeValue<OptionSetValue>("mci_servicemainclassification")?.Value).ToString()
                            ,
                                Name = mainClassificationLabel
                            },
                            SubClassification = new SelectItem
                            {
                                Id = (complaintResult.GetAttributeValue<OptionSetValue>("mci_subclassification")?.Value).ToString(),
                                Name = subClassificationLabel
                            },
                            CreatedBy = complaintResult.GetAttributeValue<string>("mci_createdby_externally"),
                            ComplaintNumber = complaintResult.GetAttributeValue<string>("mci_complaintnumber"),
                            Status = statusLabel,
                            Statecode = complaintResult.GetAttributeValue<OptionSetValue>("statecode")?.Value,
                            Contact = GetCustomerById(contactId.Id),
                            Id = complaintResult.Id
                        };
                    }
                }
            }
            catch
            {

            }
            return null;
        }


        public List<SelectItem> GetComplaintsNumbers(string query)
        {
            try
            {
                var complaintQuery = new QueryExpression("incident")
                {
                    ColumnSet = new ColumnSet("mci_complaintnumber")
                };
                var filter = new FilterExpression();
                filter.AddCondition("mci_complaintnumber", ConditionOperator.Like, "%" + query.Trim() + "%");
                filter.AddCondition("mci_complaintcreationchannel", ConditionOperator.Equal, 10 /*SBC*/);
                complaintQuery.Criteria.Filters.Add(filter);
                complaintQuery.TopCount = 20;

                var result = organizationService.RetrieveMultiple(complaintQuery);
                if (result.Entities.Count > 0)
                {
                    return result.Entities.Select(x => new SelectItem() { Id = x.Id.ToString(), Name = x.GetAttributeValue<string>("mci_complaintnumber") }).ToList();
                }

            }
            catch
            {

            }
            return new List<SelectItem>();
        }

        public CustomerViewModel GetCustomerByQuery(string query)
        {
            try
            {
                if (string.IsNullOrEmpty(query))
                    return null;

                QueryExpression contactQuery = new QueryExpression("contact")
                {
                    ColumnSet = new ColumnSet("fullname", "mci_identitynumber", "emailaddress1", "mobilephone")
                };

                // Creating the OR filter
                FilterExpression filter = new FilterExpression(LogicalOperator.Or);
                filter.AddCondition("fullname", ConditionOperator.Equal, query.Trim());
                filter.AddCondition("mci_identitynumber", ConditionOperator.Equal, query.Trim());
                filter.AddCondition("emailaddress1", ConditionOperator.Equal, query.Trim());
                filter.AddCondition("mobilephone", ConditionOperator.Equal, query.Trim());
                // Adding the filter to the query
                contactQuery.Criteria.AddFilter(filter);
                contactQuery.Criteria.AddCondition("statecode", ConditionOperator.Equal, 0);//active

                var result = organizationService.RetrieveMultiple(contactQuery);

                if (result.Entities.Count > 0)
                {
                    var entity = result.Entities[0];
                    return new CustomerViewModel
                    {
                        Id = entity.Id,
                        FullName = entity.GetAttributeValue<string>("fullname"),
                        IdNumber = entity.GetAttributeValue<string>("mci_identitynumber"),
                        Email = entity.GetAttributeValue<string>("emailaddress1"),
                        PhoneNumber = entity.GetAttributeValue<string>("mobilephone")
                    };
                }
            }
            catch (Exception ex)
            {
            }

            return null;
        }
        public CustomerViewModel GetCustomerById(Guid id)
        {
            try
            {
                var contact = organizationService.Retrieve("contact", id, new ColumnSet("fullname", "mci_identitynumber", "emailaddress1", "mobilephone"));
                if (contact != null)
                    return new CustomerViewModel
                    {
                        Id = contact.Id,
                        Email = contact.GetAttributeValue<string>("emailaddress1"),
                        FullName = contact.GetAttributeValue<string>("fullname"),
                        IdNumber = contact.GetAttributeValue<string>("mci_identitynumber"),
                        PhoneNumber = contact.GetAttributeValue<string>("mobilephone")
                    };
            }
            catch (Exception ex)
            {
            }

            return null;
        }




        public List<ClassificationItem> GetMainClassificationsWithSubClassificationsForSBC()
        {
            var webresource = GetWebResourceContent("mci_DependentClassifications");
            XDocument xmlDoc = XDocument.Parse(webresource);

            // Query to get all main classifications with value="3" and label="Sevices"
            var mainClassifications = from option in xmlDoc.Descendants("Option")
                                      where option.Attribute("value") != null &&
                                            option.Attribute("value").Value == "3" &&
                                            option.Attribute("label") != null &&
                                            option.Attribute("label").Value == "Sevices"
                                      from showOption in option.Elements("ShowOption")
                                      where showOption.Attribute("label") != null &&
                                            showOption.Attribute("label").Value.ToUpperInvariant().Contains("SBC")
                                      select new ClassificationItem
                                      {
                                          Id = showOption.Attribute("value")?.Value,
                                          Name = showOption.Attribute("label")?.Value,
                                          SubClassifications = GetSubClassifications(showOption.Attribute("value")?.Value, ref xmlDoc)
                                      };


            return mainClassifications.Where(x => x.SubClassifications.Any()).ToList();
        }

        private List<SelectItem> GetSubClassifications(string parentClassId, ref XDocument xmlDoc)
        {
            // Find the Option element with the specified parentClassId
            var parentOption = xmlDoc.Descendants("Option")
                                     .FirstOrDefault(option => option.Attribute("value").Value == parentClassId
                                     && option.Attribute("label").Value.ToUpperInvariant().Contains("SBC"));

            if (parentOption == null)
            {
                return new List<SelectItem>();
            }

            // Get all ShowOption elements under the found parent Option element
            var subClassifications = from showOption in parentOption.Elements("ShowOption")
                                     select new SelectItem
                                     {
                                         Id = showOption.Attribute("value")?.Value,
                                         Name = showOption.Attribute("label")?.Value,
                                         ParentClassificationId = parentClassId.ToString()
                                     };

            return subClassifications.ToList();
        }



        public string GetWebResourceContent(string webResourceName)
        {
            try
            {
                // Create the query expression to retrieve the web resource
                QueryExpression query = new QueryExpression("webresource")
                {
                    ColumnSet = new ColumnSet("content")
                };

                // Add a condition to filter the web resource by its name
                query.Criteria.AddCondition("name", ConditionOperator.Equal, webResourceName);

                // Execute the query
                EntityCollection result = organizationService.RetrieveMultiple(query);

                if (result.Entities.Count > 0)
                {
                    // Retrieve the content of the web resource
                    string content = result.Entities[0].GetAttributeValue<string>("content");

                    // Web resource content is base64 encoded, so decode it
                    byte[] contentBytes = Convert.FromBase64String(content);
                    string decodedContent = Encoding.UTF8.GetString(contentBytes);

                    return decodedContent;
                }
                else
                {
                    throw new Exception("Web resource not found.");
                }
            }
            catch (Exception ex)
            {
                // Optionally, log the exception or handle it as needed
                throw new Exception("An error occurred while retrieving the web resource content.", ex);
            }
        }

        private string GetOptionSetLabel(string entityName, string attributeName, int? optionSetValue, Language lang = Language.English)
        {
            if (optionSetValue == null)
            {
                return null;
            }

            var attributeRequest = new RetrieveAttributeRequest
            {
                EntityLogicalName = entityName,
                LogicalName = attributeName,
                RetrieveAsIfPublished = true
            };

            var attributeResponse = (RetrieveAttributeResponse)organizationService.Execute(attributeRequest);
            var attributeMetadata = (EnumAttributeMetadata)attributeResponse.AttributeMetadata;

            foreach (var option in attributeMetadata.OptionSet.Options)
            {
                if (option.Value == optionSetValue)
                {
                    return option.Label.UserLocalizedLabel?.Label ?? option.Label.LocalizedLabels.FirstOrDefault(l => l.LanguageCode == (int)lang)?.Label;
                }
            }

            return null;
        }



        public Guid? CreateCustomer(CustomerModel customer)
        {
            try
            {
                Entity contactEntity = new Entity("contact");

                contactEntity["fullname"] = customer.FullName;
                contactEntity["mci_identitynumber"] = customer.IdNumber;
                contactEntity["mci_identitytype"] = new OptionSetValue(customer.IdentityType);
                contactEntity["emailaddress1"] = customer.Email;
                contactEntity["mobilephone"] = customer.PhoneNumber;


                var orgService = authService.ConnectCrmOrgServiceByToken(customer.Token);
                var createdId = orgService.Create(contactEntity);

                return createdId;
            }
            catch (Exception ex)
            {

                return null;
            }
        }


        public enum Language
        {
            Arabic = 1025,
            English = 1033
        }

    }
}
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace MCISBCWebApp.Application
{
    public class CRMPreferencesService
    {
        public static string GetSystemPreference(IOrganizationService orgService, string preferenceName)
        {
            string value = null;
            QueryExpression query = new QueryExpression("arb_systemprefrence");
            query.Criteria = new FilterExpression();
            query.ColumnSet.AddColumns("arb_name", "arb_value");
            query.Criteria.AddCondition("arb_name", ConditionOperator.Equal, preferenceName);

            var systemPreference = orgService.RetrieveMultiple(query);

            if (systemPreference.Entities.Count > 0)
            {
                if (systemPreference.Entities[0].Contains("arb_value"))
                    value = systemPreference.Entities[0]["arb_value"].ToString();
            }
            return value;
        }
    }
}
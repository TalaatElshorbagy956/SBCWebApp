namespace MCISBCWebApp.Application.MCIGateWay
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IIMCIGateWayService")]
    public interface IIMCIGateWayService
    {
        
        // CODEGEN: Parameter 'SendEmailResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/SendEmail", ReplyAction="http://tempuri.org/IMCIGateWayService/SendEmailResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        SendEmailResponse SendEmail(SendEmailRequest request);
        
        // CODEGEN: Parameter 'SendEmailKeyValResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/SendEmailKeyVal", ReplyAction="http://tempuri.org/IMCIGateWayService/SendEmailKeyValResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        SendEmailKeyValResponse SendEmailKeyVal(SendEmailKeyValRequest request);
        
        // CODEGEN: Parameter 'SendSMSResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/SendSMS", ReplyAction="http://tempuri.org/IMCIGateWayService/SendSMSResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        SendSMSResponse SendSMS(SendSMSRequest request);
        
        // CODEGEN: Parameter 'GetCRInfoResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetCRInfo", ReplyAction="http://tempuri.org/IMCIGateWayService/GetCRInfoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetCRInfoResponse GetCRInfo(GetCRInfoRequest request);
        
        // CODEGEN: Parameter 'GetPersonInfoResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetPersonInfo", ReplyAction="http://tempuri.org/IMCIGateWayService/GetPersonInfoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetPersonInfoResponse GetPersonInfo(GetPersonInfoRequest request);
        
        // CODEGEN: Parameter 'Apikey' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/MakeOTPRequest", ReplyAction="http://tempuri.org/IMCIGateWayService/MakeOTPRequestResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        MakeOTPRequestResponse MakeOTPRequest(MakeOTPRequestRequest request);
        
        // CODEGEN: Parameter 'Apikey' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/MakeOTPRequestByNID", ReplyAction="http://tempuri.org/IMCIGateWayService/MakeOTPRequestByNIDResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        MakeOTPRequestByNIDResponse MakeOTPRequestByNID(MakeOTPRequestByNIDRequest request);
        
        // CODEGEN: Parameter 'Apikey' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/CheckOTPIsValid", ReplyAction="http://tempuri.org/IMCIGateWayService/CheckOTPIsValidResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        CheckOTPIsValidResponse CheckOTPIsValid(CheckOTPIsValidRequest request);
        
        // CODEGEN: Parameter 'GetEFileContactOfficerResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetEFileContactOfficer", ReplyAction="http://tempuri.org/IMCIGateWayService/GetEFileContactOfficerResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetEFileContactOfficerResponse GetEFileContactOfficer(GetEFileContactOfficerRequest request);
        
        // CODEGEN: Parameter 'key' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/AuthenticateByAD", ReplyAction="http://tempuri.org/IMCIGateWayService/AuthenticateByADResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        AuthenticateByADResponse AuthenticateByAD(AuthenticateByADRequest request);
        
        // CODEGEN: Parameter 'GetADUserResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetADUser", ReplyAction="http://tempuri.org/IMCIGateWayService/GetADUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetADUserResponse GetADUser(GetADUserRequest request);
        
        // CODEGEN: Parameter 'GetEmployeeDataResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetEmployeeData", ReplyAction="http://tempuri.org/IMCIGateWayService/GetEmployeeDataResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetEmployeeDataResponse GetEmployeeData(GetEmployeeDataRequest request);
        
        // CODEGEN: Parameter 'FNSaveDocResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/FNSaveDoc", ReplyAction="http://tempuri.org/IMCIGateWayService/FNSaveDocResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        FNSaveDocResponse FNSaveDoc(FNSaveDocRequest request);
        
        // CODEGEN: Parameter 'key' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/FNDeleteDoc", ReplyAction="http://tempuri.org/IMCIGateWayService/FNDeleteDocResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        FNDeleteDocResponse FNDeleteDoc(FNDeleteDocRequest request);
        
        // CODEGEN: Parameter 'FNGetDocResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/FNGetDoc", ReplyAction="http://tempuri.org/IMCIGateWayService/FNGetDocResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        FNGetDocResponse FNGetDoc(FNGetDocRequest request);
        
        // CODEGEN: Parameter 'FNGetDocInfoResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/FNGetDocInfo", ReplyAction="http://tempuri.org/IMCIGateWayService/FNGetDocInfoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        FNGetDocInfoResponse FNGetDocInfo(FNGetDocInfoRequest request);
        
        // CODEGEN: Parameter 'FNSaveDocInfoResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/FNSaveDocInfo", ReplyAction="http://tempuri.org/IMCIGateWayService/FNSaveDocInfoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        FNSaveDocInfoResponse FNSaveDocInfo(FNSaveDocInfoRequest request);
        
        // CODEGEN: Parameter 'key' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/FNDeleteDocInfo", ReplyAction="http://tempuri.org/IMCIGateWayService/FNDeleteDocInfoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        FNDeleteDocInfoResponse FNDeleteDocInfo(FNDeleteDocInfoRequest request);
        
        // CODEGEN: Parameter 'ShearchInADResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/ShearchInAD", ReplyAction="http://tempuri.org/IMCIGateWayService/ShearchInADResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        ShearchInADResponse ShearchInAD(ShearchInADRequest request);
        
        // CODEGEN: Parameter 'key' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/EfileLogout", ReplyAction="http://tempuri.org/IMCIGateWayService/EfileLogoutResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        EfileLogoutResponse EfileLogout(EfileLogoutRequest request);
        
        // CODEGEN: Parameter 'EfileLoginResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/EfileLogin", ReplyAction="http://tempuri.org/IMCIGateWayService/EfileLoginResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        EfileLoginResponse EfileLogin(EfileLoginRequest request);
        
        // CODEGEN: Parameter 'GetEFileUserDataByNIDResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetEFileUserDataByNID", ReplyAction="http://tempuri.org/IMCIGateWayService/GetEFileUserDataByNIDResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetEFileUserDataByNIDResponse GetEFileUserDataByNID(GetEFileUserDataByNIDRequest request);
        
        // CODEGEN: Parameter 'GetAllCRForNationalIdResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetAllCRForNationalId", ReplyAction="http://tempuri.org/IMCIGateWayService/GetAllCRForNationalIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetAllCRForNationalIdResponse GetAllCRForNationalId(GetAllCRForNationalIdRequest request);
        
        // CODEGEN: Parameter 'GetAllPersonsForCRResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetAllPersonsForCR", ReplyAction="http://tempuri.org/IMCIGateWayService/GetAllPersonsForCRResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetAllPersonsForCRResponse GetAllPersonsForCR(GetAllPersonsForCRRequest request);
        
        // CODEGEN: Parameter 'GetFakeAllPersonsForCRResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetFakeAllPersonsForCR", ReplyAction="http://tempuri.org/IMCIGateWayService/GetFakeAllPersonsForCRResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetFakeAllPersonsForCRResponse GetFakeAllPersonsForCR(GetFakeAllPersonsForCRRequest request);
        
        // CODEGEN: Parameter 'GenerateSadadBillResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GenerateSadadBill", ReplyAction="http://tempuri.org/IMCIGateWayService/GenerateSadadBillResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GenerateSadadBillResponse GenerateSadadBill(GenerateSadadBillRequest request);
        
        // CODEGEN: Parameter 'GetBillDetailResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetBillDetail", ReplyAction="http://tempuri.org/IMCIGateWayService/GetBillDetailResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetBillDetailResponse1 GetBillDetail(GetBillDetailRequest1 request);
        
        // CODEGEN: Parameter 'CancelBillResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/CancelBill", ReplyAction="http://tempuri.org/IMCIGateWayService/CancelBillResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        CancelBillResponse CancelBill(CancelBillRequest1 request);
        
        // CODEGEN: Parameter 'GetCRBranchesResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetCRBranches", ReplyAction="http://tempuri.org/IMCIGateWayService/GetCRBranchesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetCRBranchesResponse GetCRBranches(GetCRBranchesRequest request);
        
        // CODEGEN: Parameter 'GetDelegatedReferencesResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetDelegatedReferences", ReplyAction="http://tempuri.org/IMCIGateWayService/GetDelegatedReferencesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetDelegatedReferencesResponse GetDelegatedReferences(GetDelegatedReferencesRequest request);
        
        // CODEGEN: Parameter 'GetMultiCRsInfoResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetMultiCRsInfo", ReplyAction="http://tempuri.org/IMCIGateWayService/GetMultiCRsInfoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetMultiCRsInfoResponse GetMultiCRsInfo(GetMultiCRsInfoRequest request);
        
        // CODEGEN: Parameter 'Apikey' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GenrateMCISadadBill", ReplyAction="http://tempuri.org/IMCIGateWayService/GenrateMCISadadBillResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GenrateMCISadadBillResponse GenrateMCISadadBill(GenrateMCISadadBillRequest request);
        
        // CODEGEN: Parameter 'GetMCISadadBillStatusResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetMCISadadBillStatus", ReplyAction="http://tempuri.org/IMCIGateWayService/GetMCISadadBillStatusResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetMCISadadBillStatusResponse GetMCISadadBillStatus(GetMCISadadBillStatusRequest request);
        
        // CODEGEN: Parameter 'GetAllTMForNationalIdResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetAllTMForNationalId", ReplyAction="http://tempuri.org/IMCIGateWayService/GetAllTMForNationalIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetAllTMForNationalIdResponse GetAllTMForNationalId(GetAllTMForNationalIdRequest request);
        
        // CODEGEN: Parameter 'GetAllProfessionsForNationalIdResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetAllProfessionsForNationalId", ReplyAction="http://tempuri.org/IMCIGateWayService/GetAllProfessionsForNationalIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetAllProfessionsForNationalIdResponse GetAllProfessionsForNationalId(GetAllProfessionsForNationalIdRequest request);
        
        // CODEGEN: Parameter 'GetPersonForCRWithCOCResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetPersonForCRWithCOC", ReplyAction="http://tempuri.org/IMCIGateWayService/GetPersonForCRWithCOCResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetPersonForCRWithCOCResponse GetPersonForCRWithCOC(GetPersonForCRWithCOCRequest request);
        
        // CODEGEN: Parameter 'GetMonshaatRequestResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetMonshaatRequest", ReplyAction="http://tempuri.org/IMCIGateWayService/GetMonshaatRequestResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetMonshaatRequestResponse GetMonshaatRequest(GetMonshaatRequestRequest request);
        
        // CODEGEN: Parameter 'GetOwnerMobileByCRNumberResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetOwnerMobileByCRNumber", ReplyAction="http://tempuri.org/IMCIGateWayService/GetOwnerMobileByCRNumberResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetOwnerMobileByCRNumberResponse GetOwnerMobileByCRNumber(GetOwnerMobileByCRNumberRequest request);
        
        // CODEGEN: Parameter 'GetAllTicketsForCRNumberResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetAllTicketsForCRNumber", ReplyAction="http://tempuri.org/IMCIGateWayService/GetAllTicketsForCRNumberResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetAllTicketsForCRNumberResponse GetAllTicketsForCRNumber(GetAllTicketsForCRNumberRequest request);
        
        // CODEGEN: Parameter 'GetAllRelatedCrsForCRNumberResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetAllRelatedCrsForCRNumber", ReplyAction="http://tempuri.org/IMCIGateWayService/GetAllRelatedCrsForCRNumberResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetAllRelatedCrsForCRNumberResponse GetAllRelatedCrsForCRNumber(GetAllRelatedCrsForCRNumberRequest request);
        
        // CODEGEN: Parameter 'GetAllTicketsForNationalIdResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetAllTicketsForNationalId", ReplyAction="http://tempuri.org/IMCIGateWayService/GetAllTicketsForNationalIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetAllTicketsForNationalIdResponse GetAllTicketsForNationalId(GetAllTicketsForNationalIdRequest request);
        
        // CODEGEN: Parameter 'GetAllGPMLicensesForNationalIdResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetAllGPMLicensesForNationalId", ReplyAction="http://tempuri.org/IMCIGateWayService/GetAllGPMLicensesForNationalIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetAllGPMLicensesForNationalIdResponse GetAllGPMLicensesForNationalId(GetAllGPMLicensesForNationalIdRequest request);
        
        // CODEGEN: Parameter 'GetAllLabLicensesForNationalIdResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetAllLabLicensesForNationalId", ReplyAction="http://tempuri.org/IMCIGateWayService/GetAllLabLicensesForNationalIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetAllLabLicensesForNationalIdResponse GetAllLabLicensesForNationalId(GetAllLabLicensesForNationalIdRequest request);
        
        // CODEGEN: Parameter 'GetAllCRForNationalIdWithoutDuplicationResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetAllCRForNationalIdWithoutDuplication", ReplyAction="http://tempuri.org/IMCIGateWayService/GetAllCRForNationalIdWithoutDuplicationResp" +
            "onse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetAllCRForNationalIdWithoutDuplicationResponse GetAllCRForNationalIdWithoutDuplication(GetAllCRForNationalIdWithoutDuplicationRequest request);
        
        // CODEGEN: Parameter 'GetCRCountWithStatusForNationalIdResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetCRCountWithStatusForNationalId", ReplyAction="http://tempuri.org/IMCIGateWayService/GetCRCountWithStatusForNationalIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetCRCountWithStatusForNationalIdResponse GetCRCountWithStatusForNationalId(GetCRCountWithStatusForNationalIdRequest request);
        
        // CODEGEN: Parameter 'GetLicenseCountWithStatusForNationalIdResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetLicenseCountWithStatusForNationalId", ReplyAction="http://tempuri.org/IMCIGateWayService/GetLicenseCountWithStatusForNationalIdRespo" +
            "nse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetLicenseCountWithStatusForNationalIdResponse GetLicenseCountWithStatusForNationalId(GetLicenseCountWithStatusForNationalIdRequest request);
        
        // CODEGEN: Parameter 'GetTrademarkCountWithStatusForNationalIdResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetTrademarkCountWithStatusForNationalId", ReplyAction="http://tempuri.org/IMCIGateWayService/GetTrademarkCountWithStatusForNationalIdRes" +
            "ponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetTrademarkCountWithStatusForNationalIdResponse GetTrademarkCountWithStatusForNationalId(GetTrademarkCountWithStatusForNationalIdRequest request);
        
        // CODEGEN: Parameter 'GetViolationCountWithStatusForNationalIdResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetViolationCountWithStatusForNationalId", ReplyAction="http://tempuri.org/IMCIGateWayService/GetViolationCountWithStatusForNationalIdRes" +
            "ponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetViolationCountWithStatusForNationalIdResponse GetViolationCountWithStatusForNationalId(GetViolationCountWithStatusForNationalIdRequest request);
        
        // CODEGEN: Parameter 'GetCRQRImageResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetCRQRImage", ReplyAction="http://tempuri.org/IMCIGateWayService/GetCRQRImageResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetCRQRImageResponse GetCRQRImage(GetCRQRImageRequest request);
        
        // CODEGEN: Parameter 'GetCRCertificateResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetCRCertificate", ReplyAction="http://tempuri.org/IMCIGateWayService/GetCRCertificateResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetCRCertificateResponse GetCRCertificate(GetCRCertificateRequest request);
        
        // CODEGEN: Parameter 'SendNewEfadaRequestResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/SendNewEfadaRequest", ReplyAction="http://tempuri.org/IMCIGateWayService/SendNewEfadaRequestResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        SendNewEfadaRequestResponse SendNewEfadaRequest(SendNewEfadaRequestRequest request);
        
        // CODEGEN: Parameter 'GetEfadaRequestsResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetEfadaRequests", ReplyAction="http://tempuri.org/IMCIGateWayService/GetEfadaRequestsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetEfadaRequestsResponse GetEfadaRequests(GetEfadaRequestsRequest request);
        
        // CODEGEN: Parameter 'GetCRQRUrlResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetCRQRUrl", ReplyAction="http://tempuri.org/IMCIGateWayService/GetCRQRUrlResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetCRQRUrlResponse GetCRQRUrl(GetCRQRUrlRequest request);
        
        // CODEGEN: Parameter 'Apikey' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/ValidateShareholdersRecordUpdate", ReplyAction="http://tempuri.org/IMCIGateWayService/ValidateShareholdersRecordUpdateResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        ValidateShareholdersRecordUpdateResponse ValidateShareholdersRecordUpdate(ValidateShareholdersRecordUpdateRequest request);
        
        // CODEGEN: Parameter 'GetShareholdersListByCRNumberResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetShareholdersListByCRNumber", ReplyAction="http://tempuri.org/IMCIGateWayService/GetShareholdersListByCRNumberResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetShareholdersListByCRNumberResponse GetShareholdersListByCRNumber(GetShareholdersListByCRNumberRequest request);
        
        // CODEGEN: Parameter 'GetShareholderCRsByIdentityNumberResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMCIGateWayService/GetShareholderCRsByIdentityNumber", ReplyAction="http://tempuri.org/IMCIGateWayService/GetShareholderCRsByIdentityNumberResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BillResponse))]
        GetShareholderCRsByIdentityNumberResponse GetShareholderCRsByIdentityNumber(GetShareholderCRsByIdentityNumberRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIGateWay")]
    public partial class ReturnResults
    {
        
        private Exception exceptionField;
        
        private bool statusField;
        
        private bool statusFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual Exception Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.StatusSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/System")]
    public partial class Exception
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlQualifiedName factoryTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public virtual System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        public virtual System.Xml.XmlQualifiedName FactoryType
        {
            get
            {
                return this.factoryTypeField;
            }
            set
            {
                this.factoryTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework")]
    public partial class GetShareholderCRsByIdentityNumber_Result
    {
        
        private string cRNumberField;
        
        private string contributorBirthDateField;
        
        private string contributorEmailField;
        
        private string contributorFullNameField;
        
        private string contributorIdentityNumberField;
        
        private string contributorMobileField;
        
        private System.Nullable<decimal> shareCountField;
        
        private bool shareCountFieldSpecified;
        
        private string shareTypeField;
        
        private System.Nullable<decimal> shareValueField;
        
        private bool shareValueFieldSpecified;
        
        private System.Nullable<System.DateTime> approve_dateField;
        
        private bool approve_dateFieldSpecified;
        
        private System.Nullable<double> capitalField;
        
        private bool capitalFieldSpecified;
        
        private string companyNameField;
        
        private System.Nullable<double> company_share_countField;
        
        private bool company_share_countFieldSpecified;
        
        private System.Nullable<double> company_share_priceField;
        
        private bool company_share_priceFieldSpecified;
        
        private System.Nullable<double> company_special_share_countField;
        
        private bool company_special_share_countFieldSpecified;
        
        private System.Nullable<double> company_special_share_priceField;
        
        private bool company_special_share_priceFieldSpecified;
        
        private System.Nullable<bool> is_validField;
        
        private bool is_validFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRNumber
        {
            get
            {
                return this.cRNumberField;
            }
            set
            {
                this.cRNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorBirthDate
        {
            get
            {
                return this.contributorBirthDateField;
            }
            set
            {
                this.contributorBirthDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorEmail
        {
            get
            {
                return this.contributorEmailField;
            }
            set
            {
                this.contributorEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorFullName
        {
            get
            {
                return this.contributorFullNameField;
            }
            set
            {
                this.contributorFullNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorIdentityNumber
        {
            get
            {
                return this.contributorIdentityNumberField;
            }
            set
            {
                this.contributorIdentityNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorMobile
        {
            get
            {
                return this.contributorMobileField;
            }
            set
            {
                this.contributorMobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<decimal> ShareCount
        {
            get
            {
                return this.shareCountField;
            }
            set
            {
                this.shareCountField = value;
                this.ShareCountSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ShareCountSpecified
        {
            get
            {
                return this.shareCountFieldSpecified;
            }
            set
            {
                this.shareCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ShareType
        {
            get
            {
                return this.shareTypeField;
            }
            set
            {
                this.shareTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<decimal> ShareValue
        {
            get
            {
                return this.shareValueField;
            }
            set
            {
                this.shareValueField = value;
                this.ShareValueSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ShareValueSpecified
        {
            get
            {
                return this.shareValueFieldSpecified;
            }
            set
            {
                this.shareValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> approve_date
        {
            get
            {
                return this.approve_dateField;
            }
            set
            {
                this.approve_dateField = value;
                this.approve_dateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool approve_dateSpecified
        {
            get
            {
                return this.approve_dateFieldSpecified;
            }
            set
            {
                this.approve_dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> capital
        {
            get
            {
                return this.capitalField;
            }
            set
            {
                this.capitalField = value;
                this.capitalSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool capitalSpecified
        {
            get
            {
                return this.capitalFieldSpecified;
            }
            set
            {
                this.capitalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string companyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> company_share_count
        {
            get
            {
                return this.company_share_countField;
            }
            set
            {
                this.company_share_countField = value;
                this.company_share_countSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool company_share_countSpecified
        {
            get
            {
                return this.company_share_countFieldSpecified;
            }
            set
            {
                this.company_share_countFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> company_share_price
        {
            get
            {
                return this.company_share_priceField;
            }
            set
            {
                this.company_share_priceField = value;
                this.company_share_priceSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool company_share_priceSpecified
        {
            get
            {
                return this.company_share_priceFieldSpecified;
            }
            set
            {
                this.company_share_priceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> company_special_share_count
        {
            get
            {
                return this.company_special_share_countField;
            }
            set
            {
                this.company_special_share_countField = value;
                this.company_special_share_countSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool company_special_share_countSpecified
        {
            get
            {
                return this.company_special_share_countFieldSpecified;
            }
            set
            {
                this.company_special_share_countFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> company_special_share_price
        {
            get
            {
                return this.company_special_share_priceField;
            }
            set
            {
                this.company_special_share_priceField = value;
                this.company_special_share_priceSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool company_special_share_priceSpecified
        {
            get
            {
                return this.company_special_share_priceFieldSpecified;
            }
            set
            {
                this.company_special_share_priceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<bool> is_valid
        {
            get
            {
                return this.is_validField;
            }
            set
            {
                this.is_validField = value;
                this.is_validSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool is_validSpecified
        {
            get
            {
                return this.is_validFieldSpecified;
            }
            set
            {
                this.is_validFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework")]
    public partial class GetShareholdersListByCRNumber_Result
    {
        
        private string cRNumberField;
        
        private string contributorAddressField;
        
        private string contributorBirthDateField;
        
        private string contributorEmailField;
        
        private string contributorFullNameField;
        
        private string contributorIdentityNumberField;
        
        private string contributorIdentityTypeField;
        
        private System.Nullable<int> contributorIdentityTypeIdField;
        
        private bool contributorIdentityTypeIdFieldSpecified;
        
        private string contributorMobileField;
        
        private string contributorNationalityField;
        
        private System.Nullable<int> contributorNationalityIdField;
        
        private bool contributorNationalityIdFieldSpecified;
        
        private System.Nullable<decimal> shareCountField;
        
        private bool shareCountFieldSpecified;
        
        private string shareTypeField;
        
        private System.Nullable<decimal> shareValueField;
        
        private bool shareValueFieldSpecified;
        
        private System.Nullable<System.DateTime> approve_dateField;
        
        private bool approve_dateFieldSpecified;
        
        private System.Nullable<double> capitalField;
        
        private bool capitalFieldSpecified;
        
        private string companyNameField;
        
        private System.Nullable<double> company_share_countField;
        
        private bool company_share_countFieldSpecified;
        
        private System.Nullable<double> company_share_priceField;
        
        private bool company_share_priceFieldSpecified;
        
        private System.Nullable<double> company_special_share_countField;
        
        private bool company_special_share_countFieldSpecified;
        
        private System.Nullable<double> company_special_share_priceField;
        
        private bool company_special_share_priceFieldSpecified;
        
        private System.Nullable<bool> is_validField;
        
        private bool is_validFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRNumber
        {
            get
            {
                return this.cRNumberField;
            }
            set
            {
                this.cRNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorAddress
        {
            get
            {
                return this.contributorAddressField;
            }
            set
            {
                this.contributorAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorBirthDate
        {
            get
            {
                return this.contributorBirthDateField;
            }
            set
            {
                this.contributorBirthDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorEmail
        {
            get
            {
                return this.contributorEmailField;
            }
            set
            {
                this.contributorEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorFullName
        {
            get
            {
                return this.contributorFullNameField;
            }
            set
            {
                this.contributorFullNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorIdentityNumber
        {
            get
            {
                return this.contributorIdentityNumberField;
            }
            set
            {
                this.contributorIdentityNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorIdentityType
        {
            get
            {
                return this.contributorIdentityTypeField;
            }
            set
            {
                this.contributorIdentityTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> ContributorIdentityTypeId
        {
            get
            {
                return this.contributorIdentityTypeIdField;
            }
            set
            {
                this.contributorIdentityTypeIdField = value;
                this.ContributorIdentityTypeIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ContributorIdentityTypeIdSpecified
        {
            get
            {
                return this.contributorIdentityTypeIdFieldSpecified;
            }
            set
            {
                this.contributorIdentityTypeIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorMobile
        {
            get
            {
                return this.contributorMobileField;
            }
            set
            {
                this.contributorMobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContributorNationality
        {
            get
            {
                return this.contributorNationalityField;
            }
            set
            {
                this.contributorNationalityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> ContributorNationalityId
        {
            get
            {
                return this.contributorNationalityIdField;
            }
            set
            {
                this.contributorNationalityIdField = value;
                this.ContributorNationalityIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ContributorNationalityIdSpecified
        {
            get
            {
                return this.contributorNationalityIdFieldSpecified;
            }
            set
            {
                this.contributorNationalityIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<decimal> ShareCount
        {
            get
            {
                return this.shareCountField;
            }
            set
            {
                this.shareCountField = value;
                this.ShareCountSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ShareCountSpecified
        {
            get
            {
                return this.shareCountFieldSpecified;
            }
            set
            {
                this.shareCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ShareType
        {
            get
            {
                return this.shareTypeField;
            }
            set
            {
                this.shareTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<decimal> ShareValue
        {
            get
            {
                return this.shareValueField;
            }
            set
            {
                this.shareValueField = value;
                this.ShareValueSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ShareValueSpecified
        {
            get
            {
                return this.shareValueFieldSpecified;
            }
            set
            {
                this.shareValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> approve_date
        {
            get
            {
                return this.approve_dateField;
            }
            set
            {
                this.approve_dateField = value;
                this.approve_dateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool approve_dateSpecified
        {
            get
            {
                return this.approve_dateFieldSpecified;
            }
            set
            {
                this.approve_dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> capital
        {
            get
            {
                return this.capitalField;
            }
            set
            {
                this.capitalField = value;
                this.capitalSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool capitalSpecified
        {
            get
            {
                return this.capitalFieldSpecified;
            }
            set
            {
                this.capitalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string companyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> company_share_count
        {
            get
            {
                return this.company_share_countField;
            }
            set
            {
                this.company_share_countField = value;
                this.company_share_countSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool company_share_countSpecified
        {
            get
            {
                return this.company_share_countFieldSpecified;
            }
            set
            {
                this.company_share_countFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> company_share_price
        {
            get
            {
                return this.company_share_priceField;
            }
            set
            {
                this.company_share_priceField = value;
                this.company_share_priceSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool company_share_priceSpecified
        {
            get
            {
                return this.company_share_priceFieldSpecified;
            }
            set
            {
                this.company_share_priceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> company_special_share_count
        {
            get
            {
                return this.company_special_share_countField;
            }
            set
            {
                this.company_special_share_countField = value;
                this.company_special_share_countSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool company_special_share_countSpecified
        {
            get
            {
                return this.company_special_share_countFieldSpecified;
            }
            set
            {
                this.company_special_share_countFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> company_special_share_price
        {
            get
            {
                return this.company_special_share_priceField;
            }
            set
            {
                this.company_special_share_priceField = value;
                this.company_special_share_priceSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool company_special_share_priceSpecified
        {
            get
            {
                return this.company_special_share_priceFieldSpecified;
            }
            set
            {
                this.company_special_share_priceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<bool> is_valid
        {
            get
            {
                return this.is_validField;
            }
            set
            {
                this.is_validField = value;
                this.is_validSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool is_validSpecified
        {
            get
            {
                return this.is_validFieldSpecified;
            }
            set
            {
                this.is_validFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.CRM")]
    public partial class CRQRUrlResult
    {
        
        private string codeField;
        
        private string messageField;
        
        private string qrUrlField;
        
        private bool successField;
        
        private bool successFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string QrUrl
        {
            get
            {
                return this.qrUrlField;
            }
            set
            {
                this.qrUrlField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
                this.SuccessSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool SuccessSpecified
        {
            get
            {
                return this.successFieldSpecified;
            }
            set
            {
                this.successFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Efada")]
    public partial class EfadaRequest
    {
        
        private string companyNameField;
        
        private string crNumberField;
        
        private string createDateField;
        
        private string docIdField;
        
        private long requestIdField;
        
        private bool requestIdFieldSpecified;
        
        private int requestStatusIdField;
        
        private bool requestStatusIdFieldSpecified;
        
        private string sadadBillNumberField;
        
        private bool showPrintButtonField;
        
        private bool showPrintButtonFieldSpecified;
        
        private string stepNameField;
        
        private string subjectField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string companyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string crNumber
        {
            get
            {
                return this.crNumberField;
            }
            set
            {
                this.crNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string docId
        {
            get
            {
                return this.docIdField;
            }
            set
            {
                this.docIdField = value;
            }
        }
        
        /// <remarks/>
        public virtual long requestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
                this.requestIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool requestIdSpecified
        {
            get
            {
                return this.requestIdFieldSpecified;
            }
            set
            {
                this.requestIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual int requestStatusId
        {
            get
            {
                return this.requestStatusIdField;
            }
            set
            {
                this.requestStatusIdField = value;
                this.requestStatusIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool requestStatusIdSpecified
        {
            get
            {
                return this.requestStatusIdFieldSpecified;
            }
            set
            {
                this.requestStatusIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string sadadBillNumber
        {
            get
            {
                return this.sadadBillNumberField;
            }
            set
            {
                this.sadadBillNumberField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool showPrintButton
        {
            get
            {
                return this.showPrintButtonField;
            }
            set
            {
                this.showPrintButtonField = value;
                this.showPrintButtonSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool showPrintButtonSpecified
        {
            get
            {
                return this.showPrintButtonFieldSpecified;
            }
            set
            {
                this.showPrintButtonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string stepName
        {
            get
            {
                return this.stepNameField;
            }
            set
            {
                this.stepNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Efada")]
    public partial class EfadaRequests
    {
        
        private string codeField;
        
        private string messageField;
        
        private EfadaRequest[] requestsField;
        
        private bool successField;
        
        private bool successFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public virtual EfadaRequest[] requests
        {
            get
            {
                return this.requestsField;
            }
            set
            {
                this.requestsField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
                this.successSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool successSpecified
        {
            get
            {
                return this.successFieldSpecified;
            }
            set
            {
                this.successFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Efada")]
    public partial class User
    {
        
        private string identityNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string identityNumber
        {
            get
            {
                return this.identityNumberField;
            }
            set
            {
                this.identityNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Efada")]
    public partial class EfadaResponse
    {
        
        private string codeField;
        
        private string docIdField;
        
        private string efadaTypeIdField;
        
        private string idField;
        
        private string messageField;
        
        private string sadadBillCreationDateField;
        
        private string sadadBillNumberField;
        
        private bool successField;
        
        private bool successFieldSpecified;
        
        private User userField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string docId
        {
            get
            {
                return this.docIdField;
            }
            set
            {
                this.docIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string efadaTypeId
        {
            get
            {
                return this.efadaTypeIdField;
            }
            set
            {
                this.efadaTypeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string sadadBillCreationDate
        {
            get
            {
                return this.sadadBillCreationDateField;
            }
            set
            {
                this.sadadBillCreationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string sadadBillNumber
        {
            get
            {
                return this.sadadBillNumberField;
            }
            set
            {
                this.sadadBillNumberField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
                this.successSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool successSpecified
        {
            get
            {
                return this.successFieldSpecified;
            }
            set
            {
                this.successFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual User user
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.CRM")]
    public partial class CRCertificateResult
    {
        
        private string codeField;
        
        private string messageField;
        
        private byte[] printCertificateField;
        
        private string printContentTypeField;
        
        private bool successField;
        
        private bool successFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public virtual byte[] PrintCertificate
        {
            get
            {
                return this.printCertificateField;
            }
            set
            {
                this.printCertificateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PrintContentType
        {
            get
            {
                return this.printContentTypeField;
            }
            set
            {
                this.printContentTypeField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
                this.SuccessSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool SuccessSpecified
        {
            get
            {
                return this.successFieldSpecified;
            }
            set
            {
                this.successFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.CRM")]
    public partial class CRQRResult
    {
        
        private string codeField;
        
        private string messageField;
        
        private byte[] qRImageField;
        
        private bool successField;
        
        private bool successFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public virtual byte[] QRImage
        {
            get
            {
                return this.qRImageField;
            }
            set
            {
                this.qRImageField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
                this.SuccessSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool SuccessSpecified
        {
            get
            {
                return this.successFieldSpecified;
            }
            set
            {
                this.successFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
    public partial class ServicesCountsModel
    {
        
        private int countField;
        
        private bool countFieldSpecified;
        
        private string statusField;
        
        private System.Nullable<decimal> valueField;
        
        private bool valueFieldSpecified;
        
        /// <remarks/>
        public virtual int Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
                this.CountSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CountSpecified
        {
            get
            {
                return this.countFieldSpecified;
            }
            set
            {
                this.countFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<decimal> Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.ValueSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ValueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.LabLicenses")]
    public partial class LabLicensesInfo
    {
        
        private string crField;
        
        private string cRExpireDateField;
        
        private System.Nullable<System.DateTime> expireDateField;
        
        private bool expireDateFieldSpecified;
        
        private System.Nullable<System.DateTime> issueDateField;
        
        private bool issueDateFieldSpecified;
        
        private string labNameField;
        
        private int licenseNumberField;
        
        private bool licenseNumberFieldSpecified;
        
        private string licenseTypeField;
        
        private bool isCanceledField;
        
        private bool isCanceledFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CR
        {
            get
            {
                return this.crField;
            }
            set
            {
                this.crField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRExpireDate
        {
            get
            {
                return this.cRExpireDateField;
            }
            set
            {
                this.cRExpireDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
                this.ExpireDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
                this.IssueDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool IssueDateSpecified
        {
            get
            {
                return this.issueDateFieldSpecified;
            }
            set
            {
                this.issueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string LabName
        {
            get
            {
                return this.labNameField;
            }
            set
            {
                this.labNameField = value;
            }
        }
        
        /// <remarks/>
        public virtual int LicenseNumber
        {
            get
            {
                return this.licenseNumberField;
            }
            set
            {
                this.licenseNumberField = value;
                this.LicenseNumberSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool LicenseNumberSpecified
        {
            get
            {
                return this.licenseNumberFieldSpecified;
            }
            set
            {
                this.licenseNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string LicenseType
        {
            get
            {
                return this.licenseTypeField;
            }
            set
            {
                this.licenseTypeField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool isCanceled
        {
            get
            {
                return this.isCanceledField;
            }
            set
            {
                this.isCanceledField = value;
                this.isCanceledSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool isCanceledSpecified
        {
            get
            {
                return this.isCanceledFieldSpecified;
            }
            set
            {
                this.isCanceledFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.GPMLicenses")]
    public partial class GPMLicensesInfo
    {
        
        private string companyNameField;
        
        private System.Nullable<System.DateTime> expireDateField;
        
        private bool expireDateFieldSpecified;
        
        private System.Nullable<bool> isCanceledBySystemField;
        
        private bool isCanceledBySystemFieldSpecified;
        
        private System.Nullable<System.DateTime> issueDateField;
        
        private bool issueDateFieldSpecified;
        
        private long licenseNumberField;
        
        private bool licenseNumberFieldSpecified;
        
        private bool isCanceledField;
        
        private bool isCanceledFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
                this.ExpireDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<bool> IsCanceledBySystem
        {
            get
            {
                return this.isCanceledBySystemField;
            }
            set
            {
                this.isCanceledBySystemField = value;
                this.IsCanceledBySystemSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool IsCanceledBySystemSpecified
        {
            get
            {
                return this.isCanceledBySystemFieldSpecified;
            }
            set
            {
                this.isCanceledBySystemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
                this.IssueDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool IssueDateSpecified
        {
            get
            {
                return this.issueDateFieldSpecified;
            }
            set
            {
                this.issueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual long LicenseNumber
        {
            get
            {
                return this.licenseNumberField;
            }
            set
            {
                this.licenseNumberField = value;
                this.LicenseNumberSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool LicenseNumberSpecified
        {
            get
            {
                return this.licenseNumberFieldSpecified;
            }
            set
            {
                this.licenseNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual bool isCanceled
        {
            get
            {
                return this.isCanceledField;
            }
            set
            {
                this.isCanceledField = value;
                this.isCanceledSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool isCanceledSpecified
        {
            get
            {
                return this.isCanceledFieldSpecified;
            }
            set
            {
                this.isCanceledFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Professions")]
    public partial class TicketInfo
    {
        
        private System.Nullable<System.DateTime> creationDateField;
        
        private bool creationDateFieldSpecified;
        
        private string nameField;
        
        private System.Nullable<bool> paymentFlagField;
        
        private bool paymentFlagFieldSpecified;
        
        private System.Nullable<long> sadadRefNoField;
        
        private bool sadadRefNoFieldSpecified;
        
        private int ticketIdField;
        
        private bool ticketIdFieldSpecified;
        
        private string ticketViolationsField;
        
        private System.Nullable<double> totalPriceField;
        
        private bool totalPriceFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
                this.CreationDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CreationDateSpecified
        {
            get
            {
                return this.creationDateFieldSpecified;
            }
            set
            {
                this.creationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<bool> PaymentFlag
        {
            get
            {
                return this.paymentFlagField;
            }
            set
            {
                this.paymentFlagField = value;
                this.PaymentFlagSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool PaymentFlagSpecified
        {
            get
            {
                return this.paymentFlagFieldSpecified;
            }
            set
            {
                this.paymentFlagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<long> SadadRefNo
        {
            get
            {
                return this.sadadRefNoField;
            }
            set
            {
                this.sadadRefNoField = value;
                this.SadadRefNoSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool SadadRefNoSpecified
        {
            get
            {
                return this.sadadRefNoFieldSpecified;
            }
            set
            {
                this.sadadRefNoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual int TicketId
        {
            get
            {
                return this.ticketIdField;
            }
            set
            {
                this.ticketIdField = value;
                this.TicketIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool TicketIdSpecified
        {
            get
            {
                return this.ticketIdFieldSpecified;
            }
            set
            {
                this.ticketIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string TicketViolations
        {
            get
            {
                return this.ticketViolationsField;
            }
            set
            {
                this.ticketViolationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> TotalPrice
        {
            get
            {
                return this.totalPriceField;
            }
            set
            {
                this.totalPriceField = value;
                this.TotalPriceSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool TotalPriceSpecified
        {
            get
            {
                return this.totalPriceFieldSpecified;
            }
            set
            {
                this.totalPriceFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
    public partial class CROwnerInfo
    {
        
        private string cRNumberField;
        
        private string mobileField;
        
        private string nationalIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRNumber
        {
            get
            {
                return this.cRNumberField;
            }
            set
            {
                this.cRNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NationalID
        {
            get
            {
                return this.nationalIDField;
            }
            set
            {
                this.nationalIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
    public partial class GetMonshaatRequestResult
    {
        
        private string cRNoField;
        
        private System.Nullable<System.DateTime> fiscalYearField;
        
        private bool fiscalYearFieldSpecified;
        
        private string lessthan200millionField;
        
        private string organizationSizeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRNo
        {
            get
            {
                return this.cRNoField;
            }
            set
            {
                this.cRNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> FiscalYear
        {
            get
            {
                return this.fiscalYearField;
            }
            set
            {
                this.fiscalYearField = value;
                this.FiscalYearSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool FiscalYearSpecified
        {
            get
            {
                return this.fiscalYearFieldSpecified;
            }
            set
            {
                this.fiscalYearFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Lessthan200million
        {
            get
            {
                return this.lessthan200millionField;
            }
            set
            {
                this.lessthan200millionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string OrganizationSize
        {
            get
            {
                return this.organizationSizeField;
            }
            set
            {
                this.organizationSizeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
    public partial class PersonForCRWithCOCInfo
    {
        
        private string cOCEndDateField;
        
        private string cOCStartDateField;
        
        private string cRExpiryDateField;
        
        private string cRIssueDateField;
        
        private string cRNumberField;
        
        private string iD_TypeField;
        
        private string nameField;
        
        private string national_IDField;
        
        private string nationalityField;
        
        private string nationalityENField;
        
        private string partyNationalityIDField;
        
        private string relationTypeField;
        
        private string relationTypeENField;
        
        private string relationTypeIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string COCEndDate
        {
            get
            {
                return this.cOCEndDateField;
            }
            set
            {
                this.cOCEndDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string COCStartDate
        {
            get
            {
                return this.cOCStartDateField;
            }
            set
            {
                this.cOCStartDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRExpiryDate
        {
            get
            {
                return this.cRExpiryDateField;
            }
            set
            {
                this.cRExpiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRIssueDate
        {
            get
            {
                return this.cRIssueDateField;
            }
            set
            {
                this.cRIssueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRNumber
        {
            get
            {
                return this.cRNumberField;
            }
            set
            {
                this.cRNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ID_Type
        {
            get
            {
                return this.iD_TypeField;
            }
            set
            {
                this.iD_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string National_ID
        {
            get
            {
                return this.national_IDField;
            }
            set
            {
                this.national_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Nationality
        {
            get
            {
                return this.nationalityField;
            }
            set
            {
                this.nationalityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NationalityEN
        {
            get
            {
                return this.nationalityENField;
            }
            set
            {
                this.nationalityENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PartyNationalityID
        {
            get
            {
                return this.partyNationalityIDField;
            }
            set
            {
                this.partyNationalityIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RelationType
        {
            get
            {
                return this.relationTypeField;
            }
            set
            {
                this.relationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RelationTypeEN
        {
            get
            {
                return this.relationTypeENField;
            }
            set
            {
                this.relationTypeENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RelationTypeID
        {
            get
            {
                return this.relationTypeIDField;
            }
            set
            {
                this.relationTypeIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
    public partial class PersonForCRWithCOC
    {
        
        private string gregorianBirthDateField;
        
        private string hijriBirthDateField;
        
        private PersonForCRWithCOCInfo[] listField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string GregorianBirthDate
        {
            get
            {
                return this.gregorianBirthDateField;
            }
            set
            {
                this.gregorianBirthDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string HijriBirthDate
        {
            get
            {
                return this.hijriBirthDateField;
            }
            set
            {
                this.hijriBirthDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public virtual PersonForCRWithCOCInfo[] List
        {
            get
            {
                return this.listField;
            }
            set
            {
                this.listField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Professions")]
    public partial class ProfessionInfo
    {
        
        private string cityField;
        
        private System.Nullable<System.DateTime> expiredateField;
        
        private bool expiredateFieldSpecified;
        
        private string licenseNameField;
        
        private string licenseNoField;
        
        private string licenseStatusField;
        
        private System.Nullable<int> licenseStatusIDField;
        
        private bool licenseStatusIDFieldSpecified;
        
        private string nationalIDField;
        
        private string officeAddressField;
        
        private string officeNameField;
        
        private string officeTelephoneField;
        
        private string personEmailField;
        
        private string personMobileField;
        
        private string personNameField;
        
        private string personProfessionField;
        
        private string professionField;
        
        private string regionField;
        
        private string specializationField;
        
        private System.Nullable<System.DateTime> startDateField;
        
        private bool startDateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> Expiredate
        {
            get
            {
                return this.expiredateField;
            }
            set
            {
                this.expiredateField = value;
                this.ExpiredateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ExpiredateSpecified
        {
            get
            {
                return this.expiredateFieldSpecified;
            }
            set
            {
                this.expiredateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string LicenseName
        {
            get
            {
                return this.licenseNameField;
            }
            set
            {
                this.licenseNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string LicenseNo
        {
            get
            {
                return this.licenseNoField;
            }
            set
            {
                this.licenseNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string LicenseStatus
        {
            get
            {
                return this.licenseStatusField;
            }
            set
            {
                this.licenseStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> LicenseStatusID
        {
            get
            {
                return this.licenseStatusIDField;
            }
            set
            {
                this.licenseStatusIDField = value;
                this.LicenseStatusIDSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool LicenseStatusIDSpecified
        {
            get
            {
                return this.licenseStatusIDFieldSpecified;
            }
            set
            {
                this.licenseStatusIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NationalID
        {
            get
            {
                return this.nationalIDField;
            }
            set
            {
                this.nationalIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string OfficeAddress
        {
            get
            {
                return this.officeAddressField;
            }
            set
            {
                this.officeAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string OfficeName
        {
            get
            {
                return this.officeNameField;
            }
            set
            {
                this.officeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string OfficeTelephone
        {
            get
            {
                return this.officeTelephoneField;
            }
            set
            {
                this.officeTelephoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PersonEmail
        {
            get
            {
                return this.personEmailField;
            }
            set
            {
                this.personEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PersonMobile
        {
            get
            {
                return this.personMobileField;
            }
            set
            {
                this.personMobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PersonProfession
        {
            get
            {
                return this.personProfessionField;
            }
            set
            {
                this.personProfessionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Profession
        {
            get
            {
                return this.professionField;
            }
            set
            {
                this.professionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Specialization
        {
            get
            {
                return this.specializationField;
            }
            set
            {
                this.specializationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
                this.StartDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool StartDateSpecified
        {
            get
            {
                return this.startDateFieldSpecified;
            }
            set
            {
                this.startDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.TMS")]
    public partial class TradeMarkInfo
    {
        
        private string categoryField;
        
        private System.Nullable<int> categoryIdField;
        
        private bool categoryIdFieldSpecified;
        
        private string descriptionField;
        
        private byte[] imageBytesField;
        
        private string imageNameField;
        
        private string imageTypeField;
        
        private string nameArField;
        
        private string nameEnField;
        
        private string ownerArabicNameField;
        
        private string protectionEndDateField;
        
        private System.Nullable<decimal> protectionStartDateField;
        
        private bool protectionStartDateFieldSpecified;
        
        private System.Nullable<decimal> registrationDateField;
        
        private bool registrationDateFieldSpecified;
        
        private int requestNumberField;
        
        private bool requestNumberFieldSpecified;
        
        private string statusField;
        
        private System.Nullable<int> statusIdField;
        
        private bool statusIdFieldSpecified;
        
        private string tMIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> CategoryId
        {
            get
            {
                return this.categoryIdField;
            }
            set
            {
                this.categoryIdField = value;
                this.CategoryIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CategoryIdSpecified
        {
            get
            {
                return this.categoryIdFieldSpecified;
            }
            set
            {
                this.categoryIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public virtual byte[] ImageBytes
        {
            get
            {
                return this.imageBytesField;
            }
            set
            {
                this.imageBytesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ImageName
        {
            get
            {
                return this.imageNameField;
            }
            set
            {
                this.imageNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ImageType
        {
            get
            {
                return this.imageTypeField;
            }
            set
            {
                this.imageTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NameAr
        {
            get
            {
                return this.nameArField;
            }
            set
            {
                this.nameArField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NameEn
        {
            get
            {
                return this.nameEnField;
            }
            set
            {
                this.nameEnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string OwnerArabicName
        {
            get
            {
                return this.ownerArabicNameField;
            }
            set
            {
                this.ownerArabicNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ProtectionEndDate
        {
            get
            {
                return this.protectionEndDateField;
            }
            set
            {
                this.protectionEndDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<decimal> ProtectionStartDate
        {
            get
            {
                return this.protectionStartDateField;
            }
            set
            {
                this.protectionStartDateField = value;
                this.ProtectionStartDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ProtectionStartDateSpecified
        {
            get
            {
                return this.protectionStartDateFieldSpecified;
            }
            set
            {
                this.protectionStartDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<decimal> RegistrationDate
        {
            get
            {
                return this.registrationDateField;
            }
            set
            {
                this.registrationDateField = value;
                this.RegistrationDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RegistrationDateSpecified
        {
            get
            {
                return this.registrationDateFieldSpecified;
            }
            set
            {
                this.registrationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual int RequestNumber
        {
            get
            {
                return this.requestNumberField;
            }
            set
            {
                this.requestNumberField = value;
                this.RequestNumberSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RequestNumberSpecified
        {
            get
            {
                return this.requestNumberFieldSpecified;
            }
            set
            {
                this.requestNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> StatusId
        {
            get
            {
                return this.statusIdField;
            }
            set
            {
                this.statusIdField = value;
                this.StatusIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool StatusIdSpecified
        {
            get
            {
                return this.statusIdFieldSpecified;
            }
            set
            {
                this.statusIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string TMID
        {
            get
            {
                return this.tMIDField;
            }
            set
            {
                this.tMIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
    public partial class MCISadadModel
    {
        
        private string amountField;
        
        private string billingNumberField;
        
        private string descriptionField;
        
        private int maxDaysExpiryField;
        
        private bool maxDaysExpiryFieldSpecified;
        
        private string nationalIDField;
        
        private string requestIdField;
        
        private string sadadAccountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string BillingNumber
        {
            get
            {
                return this.billingNumberField;
            }
            set
            {
                this.billingNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public virtual int MaxDaysExpiry
        {
            get
            {
                return this.maxDaysExpiryField;
            }
            set
            {
                this.maxDaysExpiryField = value;
                this.MaxDaysExpirySpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool MaxDaysExpirySpecified
        {
            get
            {
                return this.maxDaysExpiryFieldSpecified;
            }
            set
            {
                this.maxDaysExpiryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NationalID
        {
            get
            {
                return this.nationalIDField;
            }
            set
            {
                this.nationalIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RequestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string SadadAccount
        {
            get
            {
                return this.sadadAccountField;
            }
            set
            {
                this.sadadAccountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
    public partial class EFileServiceDelegated
    {
        
        private string delegateTypeField;
        
        private bool hasReferenceField;
        
        private bool hasReferenceFieldSpecified;
        
        private string referenceNumberField;
        
        private string roleEnglishNameField;
        
        private string roleIDField;
        
        private string roleNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string DelegateType
        {
            get
            {
                return this.delegateTypeField;
            }
            set
            {
                this.delegateTypeField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool HasReference
        {
            get
            {
                return this.hasReferenceField;
            }
            set
            {
                this.hasReferenceField = value;
                this.HasReferenceSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool HasReferenceSpecified
        {
            get
            {
                return this.hasReferenceFieldSpecified;
            }
            set
            {
                this.hasReferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ReferenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RoleEnglishName
        {
            get
            {
                return this.roleEnglishNameField;
            }
            set
            {
                this.roleEnglishNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RoleID
        {
            get
            {
                return this.roleIDField;
            }
            set
            {
                this.roleIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RoleName
        {
            get
            {
                return this.roleNameField;
            }
            set
            {
                this.roleNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Sadad")]
    public partial class CancelBillRequest
    {
        
        private string noteField;
        
        private string referenceNumberField;
        
        private string sadadNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ReferenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string SadadNumber
        {
            get
            {
                return this.sadadNumberField;
            }
            set
            {
                this.sadadNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public partial class GetBillDetailResponse
    {
        
        private System.DateTime billCreationDateField;
        
        private bool billCreationDateFieldSpecified;
        
        private string billDescriptionField;
        
        private long billIdField;
        
        private bool billIdFieldSpecified;
        
        private BillStatus billStatusField;
        
        private bool billStatusFieldSpecified;
        
        private double costField;
        
        private bool costFieldSpecified;
        
        private System.Nullable<System.DateTime> expireDateField;
        
        private bool expireDateFieldSpecified;
        
        private System.Nullable<System.DateTime> paymentDateField;
        
        private bool paymentDateFieldSpecified;
        
        private PaymentMethod paymentMethodField;
        
        private bool paymentMethodFieldSpecified;
        
        private BillDetailPricing[] pricingDetailsField;
        
        private string referenceNumberField;
        
        private string sadadNumberField;
        
        private double totalCostField;
        
        private bool totalCostFieldSpecified;
        
        private double vATCostField;
        
        private bool vATCostFieldSpecified;
        
        /// <remarks/>
        public virtual System.DateTime BillCreationDate
        {
            get
            {
                return this.billCreationDateField;
            }
            set
            {
                this.billCreationDateField = value;
                this.BillCreationDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool BillCreationDateSpecified
        {
            get
            {
                return this.billCreationDateFieldSpecified;
            }
            set
            {
                this.billCreationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string BillDescription
        {
            get
            {
                return this.billDescriptionField;
            }
            set
            {
                this.billDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public virtual long BillId
        {
            get
            {
                return this.billIdField;
            }
            set
            {
                this.billIdField = value;
                this.BillIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool BillIdSpecified
        {
            get
            {
                return this.billIdFieldSpecified;
            }
            set
            {
                this.billIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual BillStatus BillStatus
        {
            get
            {
                return this.billStatusField;
            }
            set
            {
                this.billStatusField = value;
                this.BillStatusSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool BillStatusSpecified
        {
            get
            {
                return this.billStatusFieldSpecified;
            }
            set
            {
                this.billStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual double Cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
                this.CostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CostSpecified
        {
            get
            {
                return this.costFieldSpecified;
            }
            set
            {
                this.costFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
                this.ExpireDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> PaymentDate
        {
            get
            {
                return this.paymentDateField;
            }
            set
            {
                this.paymentDateField = value;
                this.PaymentDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool PaymentDateSpecified
        {
            get
            {
                return this.paymentDateFieldSpecified;
            }
            set
            {
                this.paymentDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual PaymentMethod PaymentMethod
        {
            get
            {
                return this.paymentMethodField;
            }
            set
            {
                this.paymentMethodField = value;
                this.PaymentMethodSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool PaymentMethodSpecified
        {
            get
            {
                return this.paymentMethodFieldSpecified;
            }
            set
            {
                this.paymentMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public virtual BillDetailPricing[] PricingDetails
        {
            get
            {
                return this.pricingDetailsField;
            }
            set
            {
                this.pricingDetailsField = value;
            }
        }
        
        /// <remarks/>
        public virtual string ReferenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string SadadNumber
        {
            get
            {
                return this.sadadNumberField;
            }
            set
            {
                this.sadadNumberField = value;
            }
        }
        
        /// <remarks/>
        public virtual double TotalCost
        {
            get
            {
                return this.totalCostField;
            }
            set
            {
                this.totalCostField = value;
                this.TotalCostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool TotalCostSpecified
        {
            get
            {
                return this.totalCostFieldSpecified;
            }
            set
            {
                this.totalCostFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual double VATCost
        {
            get
            {
                return this.vATCostField;
            }
            set
            {
                this.vATCostField = value;
                this.VATCostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool VATCostSpecified
        {
            get
            {
                return this.vATCostFieldSpecified;
            }
            set
            {
                this.vATCostFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public enum BillStatus
    {
        
        /// <remarks/>
        Any,
        
        /// <remarks/>
        Created,
        
        /// <remarks/>
        NotPaid,
        
        /// <remarks/>
        Paid,
        
        /// <remarks/>
        Expired,
        
        /// <remarks/>
        Canceled,
        
        /// <remarks/>
        Failed,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public enum PaymentMethod
    {
        
        /// <remarks/>
        Any,
        
        /// <remarks/>
        SadadThiqah,
        
        /// <remarks/>
        SadadMCI,
        
        /// <remarks/>
        Cash,
        
        /// <remarks/>
        OLP,
        
        /// <remarks/>
        CreditCard,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public partial class BillDetailPricing
    {
        
        private double costField;
        
        private bool costFieldSpecified;
        
        private string descField;
        
        private string refDescField;
        
        private string refIdField;
        
        private string serviceCodeField;
        
        private string serviceNameArField;
        
        private string serviceNameEnField;
        
        private double totalCostField;
        
        private bool totalCostFieldSpecified;
        
        private double vATCostField;
        
        private bool vATCostFieldSpecified;
        
        private double vATPercentageField;
        
        private bool vATPercentageFieldSpecified;
        
        private BillPricingStrategyResultModel[] billPricingStrategyResultField;
        
        /// <remarks/>
        public virtual double Cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
                this.CostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CostSpecified
        {
            get
            {
                return this.costFieldSpecified;
            }
            set
            {
                this.costFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RefDesc
        {
            get
            {
                return this.refDescField;
            }
            set
            {
                this.refDescField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RefId
        {
            get
            {
                return this.refIdField;
            }
            set
            {
                this.refIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ServiceCode
        {
            get
            {
                return this.serviceCodeField;
            }
            set
            {
                this.serviceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ServiceNameAr
        {
            get
            {
                return this.serviceNameArField;
            }
            set
            {
                this.serviceNameArField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ServiceNameEn
        {
            get
            {
                return this.serviceNameEnField;
            }
            set
            {
                this.serviceNameEnField = value;
            }
        }
        
        /// <remarks/>
        public virtual double TotalCost
        {
            get
            {
                return this.totalCostField;
            }
            set
            {
                this.totalCostField = value;
                this.TotalCostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool TotalCostSpecified
        {
            get
            {
                return this.totalCostFieldSpecified;
            }
            set
            {
                this.totalCostFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual double VATCost
        {
            get
            {
                return this.vATCostField;
            }
            set
            {
                this.vATCostField = value;
                this.VATCostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool VATCostSpecified
        {
            get
            {
                return this.vATCostFieldSpecified;
            }
            set
            {
                this.vATCostFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual double VATPercentage
        {
            get
            {
                return this.vATPercentageField;
            }
            set
            {
                this.vATPercentageField = value;
                this.VATPercentageSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool VATPercentageSpecified
        {
            get
            {
                return this.vATPercentageFieldSpecified;
            }
            set
            {
                this.vATPercentageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public virtual BillPricingStrategyResultModel[] billPricingStrategyResult
        {
            get
            {
                return this.billPricingStrategyResultField;
            }
            set
            {
                this.billPricingStrategyResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public partial class BillPricingStrategyResultModel
    {
        
        private int billDetailIdField;
        
        private bool billDetailIdFieldSpecified;
        
        private double costField;
        
        private bool costFieldSpecified;
        
        private string descriptionArField;
        
        private string descriptionEnField;
        
        /// <remarks/>
        public virtual int BillDetailId
        {
            get
            {
                return this.billDetailIdField;
            }
            set
            {
                this.billDetailIdField = value;
                this.BillDetailIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool BillDetailIdSpecified
        {
            get
            {
                return this.billDetailIdFieldSpecified;
            }
            set
            {
                this.billDetailIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual double Cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
                this.CostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CostSpecified
        {
            get
            {
                return this.costFieldSpecified;
            }
            set
            {
                this.costFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string DescriptionAr
        {
            get
            {
                return this.descriptionArField;
            }
            set
            {
                this.descriptionArField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string DescriptionEn
        {
            get
            {
                return this.descriptionEnField;
            }
            set
            {
                this.descriptionEnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Sadad")]
    public partial class GetBillDetailRequest
    {
        
        private string refDescField;
        
        private string refIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string refDesc
        {
            get
            {
                return this.refDescField;
            }
            set
            {
                this.refDescField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string refId
        {
            get
            {
                return this.refIdField;
            }
            set
            {
                this.refIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CheckBillCostResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChangeBillResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenerateBillResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenerateBillSadadResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public partial class BillResponse
    {
        
        private int errorCodeField;
        
        private bool errorCodeFieldSpecified;
        
        private string messageField;
        
        private ResponseCode responseCodeField;
        
        private bool responseCodeFieldSpecified;
        
        /// <remarks/>
        public virtual int ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
                this.ErrorCodeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ErrorCodeSpecified
        {
            get
            {
                return this.errorCodeFieldSpecified;
            }
            set
            {
                this.errorCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public virtual ResponseCode ResponseCode
        {
            get
            {
                return this.responseCodeField;
            }
            set
            {
                this.responseCodeField = value;
                this.ResponseCodeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ResponseCodeSpecified
        {
            get
            {
                return this.responseCodeFieldSpecified;
            }
            set
            {
                this.responseCodeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public enum ResponseCode
    {
        
        /// <remarks/>
        Success,
        
        /// <remarks/>
        Error,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public partial class CheckBillCostResponse : BillResponse
    {
        
        private BillDetailPricing[] billDetailsField;
        
        private double costField;
        
        private bool costFieldSpecified;
        
        private double totalCostField;
        
        private bool totalCostFieldSpecified;
        
        private double vATCostField;
        
        private bool vATCostFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public virtual BillDetailPricing[] BillDetails
        {
            get
            {
                return this.billDetailsField;
            }
            set
            {
                this.billDetailsField = value;
            }
        }
        
        /// <remarks/>
        public virtual double Cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
                this.CostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CostSpecified
        {
            get
            {
                return this.costFieldSpecified;
            }
            set
            {
                this.costFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual double TotalCost
        {
            get
            {
                return this.totalCostField;
            }
            set
            {
                this.totalCostField = value;
                this.TotalCostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool TotalCostSpecified
        {
            get
            {
                return this.totalCostFieldSpecified;
            }
            set
            {
                this.totalCostFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual double VATCost
        {
            get
            {
                return this.vATCostField;
            }
            set
            {
                this.vATCostField = value;
                this.VATCostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool VATCostSpecified
        {
            get
            {
                return this.vATCostFieldSpecified;
            }
            set
            {
                this.vATCostFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public partial class ChangeBillResponse : BillResponse
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenerateBillSadadResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public partial class GenerateBillResponse : BillResponse
    {
        
        private double costField;
        
        private bool costFieldSpecified;
        
        private BillDetailPricing[] pricingDetailsField;
        
        private double totalCostField;
        
        private bool totalCostFieldSpecified;
        
        private double vATCostField;
        
        private bool vATCostFieldSpecified;
        
        /// <remarks/>
        public virtual double Cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
                this.CostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CostSpecified
        {
            get
            {
                return this.costFieldSpecified;
            }
            set
            {
                this.costFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public virtual BillDetailPricing[] PricingDetails
        {
            get
            {
                return this.pricingDetailsField;
            }
            set
            {
                this.pricingDetailsField = value;
            }
        }
        
        /// <remarks/>
        public virtual double TotalCost
        {
            get
            {
                return this.totalCostField;
            }
            set
            {
                this.totalCostField = value;
                this.TotalCostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool TotalCostSpecified
        {
            get
            {
                return this.totalCostFieldSpecified;
            }
            set
            {
                this.totalCostFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual double VATCost
        {
            get
            {
                return this.vATCostField;
            }
            set
            {
                this.vATCostField = value;
                this.VATCostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool VATCostSpecified
        {
            get
            {
                return this.vATCostFieldSpecified;
            }
            set
            {
                this.vATCostFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCIBilling.WebService")]
    public partial class GenerateBillSadadResponse : GenerateBillResponse
    {
        
        private long billIdField;
        
        private bool billIdFieldSpecified;
        
        private string referenceNumberField;
        
        private System.Nullable<long> sadadNumberField;
        
        private bool sadadNumberFieldSpecified;
        
        /// <remarks/>
        public virtual long BillId
        {
            get
            {
                return this.billIdField;
            }
            set
            {
                this.billIdField = value;
                this.BillIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool BillIdSpecified
        {
            get
            {
                return this.billIdFieldSpecified;
            }
            set
            {
                this.billIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual string ReferenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<long> SadadNumber
        {
            get
            {
                return this.sadadNumberField;
            }
            set
            {
                this.sadadNumberField = value;
                this.SadadNumberSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool SadadNumberSpecified
        {
            get
            {
                return this.sadadNumberFieldSpecified;
            }
            set
            {
                this.sadadNumberFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Sadad")]
    public partial class BillDetailMetadata
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Sadad")]
    public partial class RequestedBillDetail
    {
        
        private BillDetailMetadata[] billDetailMetadataField;
        
        private double costField;
        
        private bool costFieldSpecified;
        
        private string descriptionField;
        
        private string refDescField;
        
        private string refIdField;
        
        private string serviceCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public virtual BillDetailMetadata[] BillDetailMetadata
        {
            get
            {
                return this.billDetailMetadataField;
            }
            set
            {
                this.billDetailMetadataField = value;
            }
        }
        
        /// <remarks/>
        public virtual double Cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
                this.CostSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CostSpecified
        {
            get
            {
                return this.costFieldSpecified;
            }
            set
            {
                this.costFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RefDesc
        {
            get
            {
                return this.refDescField;
            }
            set
            {
                this.refDescField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RefId
        {
            get
            {
                return this.refIdField;
            }
            set
            {
                this.refIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ServiceCode
        {
            get
            {
                return this.serviceCodeField;
            }
            set
            {
                this.serviceCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Sadad")]
    public partial class GenerateBillSadadRequest
    {
        
        private string billDescriptionField;
        
        private RequestedBillDetail[] billDetailsField;
        
        private string emailField;
        
        private System.Nullable<System.DateTime> expireDateField;
        
        private bool expireDateFieldSpecified;
        
        private string mobileNoField;
        
        private string refDescField;
        
        private string refIdField;
        
        private string vATNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string BillDescription
        {
            get
            {
                return this.billDescriptionField;
            }
            set
            {
                this.billDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public virtual RequestedBillDetail[] BillDetails
        {
            get
            {
                return this.billDetailsField;
            }
            set
            {
                this.billDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
                this.ExpireDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string MobileNo
        {
            get
            {
                return this.mobileNoField;
            }
            set
            {
                this.mobileNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RefDesc
        {
            get
            {
                return this.refDescField;
            }
            set
            {
                this.refDescField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RefId
        {
            get
            {
                return this.refIdField;
            }
            set
            {
                this.refIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string VATNumber
        {
            get
            {
                return this.vATNumberField;
            }
            set
            {
                this.vATNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CRForPerson))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
    public partial class CRPerson
    {
        
        private string activitiesField;
        
        private string addressField;
        
        private string birthDateField;
        
        private string cRLocationField;
        
        private long cardNoField;
        
        private bool cardNoFieldSpecified;
        
        private string entered_CRField;
        
        private string iD_TypeField;
        
        private ISICActivity[] iSICActivitiesField;
        
        private string locationField;
        
        private string locationIDField;
        
        private string mobileField;
        
        private string nameField;
        
        private string national_IDField;
        
        private string national_ID_CreatedDateField;
        
        private string nationalityField;
        
        private string nationalityENField;
        
        private string nationalityIDField;
        
        private string nationality_ISO3Field;
        
        private string pHONE1Field;
        
        private string pKEYField;
        
        private string pOBOX1Field;
        
        private string partyAddressField;
        
        private string partyBirthLocationField;
        
        private string partyGrossField;
        
        private string partyPercintField;
        
        private string partyShareCountField;
        
        private string relationTypeField;
        
        private string relationTypeENField;
        
        private string relationTypeIDField;
        
        private string unifiedNumberField;
        
        private string zipCodeField;
        
        private string mainCRField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Activities
        {
            get
            {
                return this.activitiesField;
            }
            set
            {
                this.activitiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRLocation
        {
            get
            {
                return this.cRLocationField;
            }
            set
            {
                this.cRLocationField = value;
            }
        }
        
        /// <remarks/>
        public virtual long CardNo
        {
            get
            {
                return this.cardNoField;
            }
            set
            {
                this.cardNoField = value;
                this.CardNoSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CardNoSpecified
        {
            get
            {
                return this.cardNoFieldSpecified;
            }
            set
            {
                this.cardNoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Entered_CR
        {
            get
            {
                return this.entered_CRField;
            }
            set
            {
                this.entered_CRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ID_Type
        {
            get
            {
                return this.iD_TypeField;
            }
            set
            {
                this.iD_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public virtual ISICActivity[] ISICActivities
        {
            get
            {
                return this.iSICActivitiesField;
            }
            set
            {
                this.iSICActivitiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string LocationID
        {
            get
            {
                return this.locationIDField;
            }
            set
            {
                this.locationIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string National_ID
        {
            get
            {
                return this.national_IDField;
            }
            set
            {
                this.national_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string National_ID_CreatedDate
        {
            get
            {
                return this.national_ID_CreatedDateField;
            }
            set
            {
                this.national_ID_CreatedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Nationality
        {
            get
            {
                return this.nationalityField;
            }
            set
            {
                this.nationalityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NationalityEN
        {
            get
            {
                return this.nationalityENField;
            }
            set
            {
                this.nationalityENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NationalityID
        {
            get
            {
                return this.nationalityIDField;
            }
            set
            {
                this.nationalityIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Nationality_ISO3
        {
            get
            {
                return this.nationality_ISO3Field;
            }
            set
            {
                this.nationality_ISO3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PHONE1
        {
            get
            {
                return this.pHONE1Field;
            }
            set
            {
                this.pHONE1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PKEY
        {
            get
            {
                return this.pKEYField;
            }
            set
            {
                this.pKEYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string POBOX1
        {
            get
            {
                return this.pOBOX1Field;
            }
            set
            {
                this.pOBOX1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PartyAddress
        {
            get
            {
                return this.partyAddressField;
            }
            set
            {
                this.partyAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PartyBirthLocation
        {
            get
            {
                return this.partyBirthLocationField;
            }
            set
            {
                this.partyBirthLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PartyGross
        {
            get
            {
                return this.partyGrossField;
            }
            set
            {
                this.partyGrossField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PartyPercint
        {
            get
            {
                return this.partyPercintField;
            }
            set
            {
                this.partyPercintField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PartyShareCount
        {
            get
            {
                return this.partyShareCountField;
            }
            set
            {
                this.partyShareCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RelationType
        {
            get
            {
                return this.relationTypeField;
            }
            set
            {
                this.relationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RelationTypeEN
        {
            get
            {
                return this.relationTypeENField;
            }
            set
            {
                this.relationTypeENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RelationTypeID
        {
            get
            {
                return this.relationTypeIDField;
            }
            set
            {
                this.relationTypeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string UnifiedNumber
        {
            get
            {
                return this.unifiedNumberField;
            }
            set
            {
                this.unifiedNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string mainCR
        {
            get
            {
                return this.mainCRField;
            }
            set
            {
                this.mainCRField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
    public partial class ISICActivity
    {
        
        private System.Nullable<int> activityCodeField;
        
        private bool activityCodeFieldSpecified;
        
        private string activityDescriptionField;
        
        private System.Nullable<int> authorityIdField;
        
        private bool authorityIdFieldSpecified;
        
        private string authorityNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> ActivityCode
        {
            get
            {
                return this.activityCodeField;
            }
            set
            {
                this.activityCodeField = value;
                this.ActivityCodeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ActivityCodeSpecified
        {
            get
            {
                return this.activityCodeFieldSpecified;
            }
            set
            {
                this.activityCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ActivityDescription
        {
            get
            {
                return this.activityDescriptionField;
            }
            set
            {
                this.activityDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> AuthorityId
        {
            get
            {
                return this.authorityIdField;
            }
            set
            {
                this.authorityIdField = value;
                this.AuthorityIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool AuthorityIdSpecified
        {
            get
            {
                return this.authorityIdFieldSpecified;
            }
            set
            {
                this.authorityIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string AuthorityName
        {
            get
            {
                return this.authorityNameField;
            }
            set
            {
                this.authorityNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
    public partial class CRForPerson : CRPerson
    {
        
        private string businessTypeField;
        
        private int businessTypeIdField;
        
        private bool businessTypeIdFieldSpecified;
        
        private string cRNameField;
        
        private string cRNumberField;
        
        private string cRStatusField;
        
        private string expiryDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string BusinessType
        {
            get
            {
                return this.businessTypeField;
            }
            set
            {
                this.businessTypeField = value;
            }
        }
        
        /// <remarks/>
        public virtual int BusinessTypeId
        {
            get
            {
                return this.businessTypeIdField;
            }
            set
            {
                this.businessTypeIdField = value;
                this.BusinessTypeIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool BusinessTypeIdSpecified
        {
            get
            {
                return this.businessTypeIdFieldSpecified;
            }
            set
            {
                this.businessTypeIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRName
        {
            get
            {
                return this.cRNameField;
            }
            set
            {
                this.cRNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRNumber
        {
            get
            {
                return this.cRNumberField;
            }
            set
            {
                this.cRNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRStatus
        {
            get
            {
                return this.cRStatusField;
            }
            set
            {
                this.cRStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework")]
    public partial class FNInfo
    {
        
        private string fileContentField;
        
        private byte[] fileDataField;
        
        private string fileNameField;
        
        private System.Nullable<double> fileSizeField;
        
        private bool fileSizeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string FileContent
        {
            get
            {
                return this.fileContentField;
            }
            set
            {
                this.fileContentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public virtual byte[] FileData
        {
            get
            {
                return this.fileDataField;
            }
            set
            {
                this.fileDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> FileSize
        {
            get
            {
                return this.fileSizeField;
            }
            set
            {
                this.fileSizeField = value;
                this.FileSizeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool FileSizeSpecified
        {
            get
            {
                return this.fileSizeFieldSpecified;
            }
            set
            {
                this.fileSizeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework")]
    public partial class FNAttribute
    {
        
        private string keyField;
        
        private string vlaueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Vlaue
        {
            get
            {
                return this.vlaueField;
            }
            set
            {
                this.vlaueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.HR")]
    public partial class EmployeeFullData
    {
        
        private System.Nullable<System.DateTime> aCTSTDATEField;
        
        private bool aCTSTDATEFieldSpecified;
        
        private string aCTSTDATEHGField;
        
        private int departmentIdField;
        
        private bool departmentIdFieldSpecified;
        
        private string departmentName_ArField;
        
        private string departmentName_EnField;
        
        private string displayNameField;
        
        private string emailField;
        
        private string empNameField;
        
        private string empName_EnField;
        
        private int empTypeIdField;
        
        private bool empTypeIdFieldSpecified;
        
        private int employeeIdField;
        
        private bool employeeIdFieldSpecified;
        
        private int jobIdField;
        
        private bool jobIdFieldSpecified;
        
        private string jobNameField;
        
        private string mobileField;
        
        private string nIDField;
        
        private int parent_Org_IdField;
        
        private bool parent_Org_IdFieldSpecified;
        
        private int rankCodeField;
        
        private bool rankCodeFieldSpecified;
        
        private int statusIdField;
        
        private bool statusIdFieldSpecified;
        
        private string telephonenumberField;
        
        private string userNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> ACTSTDATE
        {
            get
            {
                return this.aCTSTDATEField;
            }
            set
            {
                this.aCTSTDATEField = value;
                this.ACTSTDATESpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ACTSTDATESpecified
        {
            get
            {
                return this.aCTSTDATEFieldSpecified;
            }
            set
            {
                this.aCTSTDATEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ACTSTDATEHG
        {
            get
            {
                return this.aCTSTDATEHGField;
            }
            set
            {
                this.aCTSTDATEHGField = value;
            }
        }
        
        /// <remarks/>
        public virtual int DepartmentId
        {
            get
            {
                return this.departmentIdField;
            }
            set
            {
                this.departmentIdField = value;
                this.DepartmentIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool DepartmentIdSpecified
        {
            get
            {
                return this.departmentIdFieldSpecified;
            }
            set
            {
                this.departmentIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string DepartmentName_Ar
        {
            get
            {
                return this.departmentName_ArField;
            }
            set
            {
                this.departmentName_ArField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string DepartmentName_En
        {
            get
            {
                return this.departmentName_EnField;
            }
            set
            {
                this.departmentName_EnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string EmpName
        {
            get
            {
                return this.empNameField;
            }
            set
            {
                this.empNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string EmpName_En
        {
            get
            {
                return this.empName_EnField;
            }
            set
            {
                this.empName_EnField = value;
            }
        }
        
        /// <remarks/>
        public virtual int EmpTypeId
        {
            get
            {
                return this.empTypeIdField;
            }
            set
            {
                this.empTypeIdField = value;
                this.EmpTypeIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool EmpTypeIdSpecified
        {
            get
            {
                return this.empTypeIdFieldSpecified;
            }
            set
            {
                this.empTypeIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual int EmployeeId
        {
            get
            {
                return this.employeeIdField;
            }
            set
            {
                this.employeeIdField = value;
                this.EmployeeIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool EmployeeIdSpecified
        {
            get
            {
                return this.employeeIdFieldSpecified;
            }
            set
            {
                this.employeeIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual int JobId
        {
            get
            {
                return this.jobIdField;
            }
            set
            {
                this.jobIdField = value;
                this.JobIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool JobIdSpecified
        {
            get
            {
                return this.jobIdFieldSpecified;
            }
            set
            {
                this.jobIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string JobName
        {
            get
            {
                return this.jobNameField;
            }
            set
            {
                this.jobNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NID
        {
            get
            {
                return this.nIDField;
            }
            set
            {
                this.nIDField = value;
            }
        }
        
        /// <remarks/>
        public virtual int Parent_Org_Id
        {
            get
            {
                return this.parent_Org_IdField;
            }
            set
            {
                this.parent_Org_IdField = value;
                this.Parent_Org_IdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool Parent_Org_IdSpecified
        {
            get
            {
                return this.parent_Org_IdFieldSpecified;
            }
            set
            {
                this.parent_Org_IdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual int RankCode
        {
            get
            {
                return this.rankCodeField;
            }
            set
            {
                this.rankCodeField = value;
                this.RankCodeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RankCodeSpecified
        {
            get
            {
                return this.rankCodeFieldSpecified;
            }
            set
            {
                this.rankCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual int StatusId
        {
            get
            {
                return this.statusIdField;
            }
            set
            {
                this.statusIdField = value;
                this.StatusIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool StatusIdSpecified
        {
            get
            {
                return this.statusIdFieldSpecified;
            }
            set
            {
                this.statusIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Telephonenumber
        {
            get
            {
                return this.telephonenumberField;
            }
            set
            {
                this.telephonenumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Services")]
    public partial class ADUser
    {
        
        private string displayNameField;
        
        private string empIdField;
        
        private string mobileField;
        
        private string telephonenumberField;
        
        private string userNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string EmpId
        {
            get
            {
                return this.empIdField;
            }
            set
            {
                this.empIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Telephonenumber
        {
            get
            {
                return this.telephonenumberField;
            }
            set
            {
                this.telephonenumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework")]
    public partial class ContactOfficerModel
    {
        
        private string additionalNoField;
        
        private System.Nullable<System.DateTime> birthDateField;
        
        private bool birthDateFieldSpecified;
        
        private string birthDateHijriField;
        
        private string buildingNoField;
        
        private string cityNameField;
        
        private string cityTelephoneCodeField;
        
        private string contactEmailField;
        
        private string contactMobileField;
        
        private string contactTelephoneField;
        
        private string countryNameField;
        
        private string districtNameField;
        
        private System.Nullable<System.DateTime> expiryDateField;
        
        private bool expiryDateFieldSpecified;
        
        private string formalIdentityNumberField;
        
        private string fullNameField;
        
        private string genderField;
        
        private bool hasWaselAccountField;
        
        private bool hasWaselAccountFieldSpecified;
        
        private string interContactMobileField;
        
        private string interContactTelephoneField;
        
        private string issueAuthorityField;
        
        private System.Nullable<System.DateTime> issueDateField;
        
        private bool issueDateFieldSpecified;
        
        private string issuePlaceField;
        
        private string lastNameField;
        
        private int legalStatusField;
        
        private bool legalStatusFieldSpecified;
        
        private string nationalityIDField;
        
        private string nationalityNameField;
        
        private string pOBoxField;
        
        private string personGUIDField;
        
        private string personImageField;
        
        private string postalCodeField;
        
        private string secondNameField;
        
        private string streetNameField;
        
        private string telephoneCodeIDField;
        
        private string thirdNameField;
        
        private string unitNoField;
        
        private string userIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string AdditionalNo
        {
            get
            {
                return this.additionalNoField;
            }
            set
            {
                this.additionalNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
                this.BirthDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool BirthDateSpecified
        {
            get
            {
                return this.birthDateFieldSpecified;
            }
            set
            {
                this.birthDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string BirthDateHijri
        {
            get
            {
                return this.birthDateHijriField;
            }
            set
            {
                this.birthDateHijriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string BuildingNo
        {
            get
            {
                return this.buildingNoField;
            }
            set
            {
                this.buildingNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CityTelephoneCode
        {
            get
            {
                return this.cityTelephoneCodeField;
            }
            set
            {
                this.cityTelephoneCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContactEmail
        {
            get
            {
                return this.contactEmailField;
            }
            set
            {
                this.contactEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContactMobile
        {
            get
            {
                return this.contactMobileField;
            }
            set
            {
                this.contactMobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ContactTelephone
        {
            get
            {
                return this.contactTelephoneField;
            }
            set
            {
                this.contactTelephoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string DistrictName
        {
            get
            {
                return this.districtNameField;
            }
            set
            {
                this.districtNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
                this.ExpiryDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ExpiryDateSpecified
        {
            get
            {
                return this.expiryDateFieldSpecified;
            }
            set
            {
                this.expiryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string FormalIdentityNumber
        {
            get
            {
                return this.formalIdentityNumberField;
            }
            set
            {
                this.formalIdentityNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string FullName
        {
            get
            {
                return this.fullNameField;
            }
            set
            {
                this.fullNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool HasWaselAccount
        {
            get
            {
                return this.hasWaselAccountField;
            }
            set
            {
                this.hasWaselAccountField = value;
                this.HasWaselAccountSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool HasWaselAccountSpecified
        {
            get
            {
                return this.hasWaselAccountFieldSpecified;
            }
            set
            {
                this.hasWaselAccountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string InterContactMobile
        {
            get
            {
                return this.interContactMobileField;
            }
            set
            {
                this.interContactMobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string InterContactTelephone
        {
            get
            {
                return this.interContactTelephoneField;
            }
            set
            {
                this.interContactTelephoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string IssueAuthority
        {
            get
            {
                return this.issueAuthorityField;
            }
            set
            {
                this.issueAuthorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<System.DateTime> IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
                this.IssueDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool IssueDateSpecified
        {
            get
            {
                return this.issueDateFieldSpecified;
            }
            set
            {
                this.issueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string IssuePlace
        {
            get
            {
                return this.issuePlaceField;
            }
            set
            {
                this.issuePlaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public virtual int LegalStatus
        {
            get
            {
                return this.legalStatusField;
            }
            set
            {
                this.legalStatusField = value;
                this.LegalStatusSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool LegalStatusSpecified
        {
            get
            {
                return this.legalStatusFieldSpecified;
            }
            set
            {
                this.legalStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NationalityID
        {
            get
            {
                return this.nationalityIDField;
            }
            set
            {
                this.nationalityIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string NationalityName
        {
            get
            {
                return this.nationalityNameField;
            }
            set
            {
                this.nationalityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string POBox
        {
            get
            {
                return this.pOBoxField;
            }
            set
            {
                this.pOBoxField = value;
            }
        }
        
        /// <remarks/>
        public virtual string PersonGUID
        {
            get
            {
                return this.personGUIDField;
            }
            set
            {
                this.personGUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PersonImage
        {
            get
            {
                return this.personImageField;
            }
            set
            {
                this.personImageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string SecondName
        {
            get
            {
                return this.secondNameField;
            }
            set
            {
                this.secondNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string StreetName
        {
            get
            {
                return this.streetNameField;
            }
            set
            {
                this.streetNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string TelephoneCodeID
        {
            get
            {
                return this.telephoneCodeIDField;
            }
            set
            {
                this.telephoneCodeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ThirdName
        {
            get
            {
                return this.thirdNameField;
            }
            set
            {
                this.thirdNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string UnitNo
        {
            get
            {
                return this.unitNoField;
            }
            set
            {
                this.unitNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Model")]
    public partial class YaqeenInfo
    {
        
        private System.DateTime bIRTH_DATE_GField;
        
        private bool bIRTH_DATE_GFieldSpecified;
        
        private string bIRTH_DATE_HField;
        
        private string errorField;
        
        private bool exitStatusField;
        
        private bool exitStatusFieldSpecified;
        
        private string expirayDateHijriField;
        
        private string firstNameField;
        
        private string firstName_TRField;
        
        private string idNumberField;
        
        private bool isAliveField;
        
        private bool isAliveFieldSpecified;
        
        private bool isGovernmentEmployeeField;
        
        private bool isGovernmentEmployeeFieldSpecified;
        
        private string issueCityField;
        
        private string issueDateHijriField;
        
        private string lastNameField;
        
        private string lastName_TRField;
        
        private int legalStatusField;
        
        private bool legalStatusFieldSpecified;
        
        private string nationalityField;
        
        private int nationalityCodeField;
        
        private bool nationalityCodeFieldSpecified;
        
        private string sEXField;
        
        private string secondNameField;
        
        private string secondName_TRField;
        
        private int securityStatusField;
        
        private bool securityStatusFieldSpecified;
        
        private string thirdNameField;
        
        /// <remarks/>
        public virtual System.DateTime BIRTH_DATE_G
        {
            get
            {
                return this.bIRTH_DATE_GField;
            }
            set
            {
                this.bIRTH_DATE_GField = value;
                this.BIRTH_DATE_GSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool BIRTH_DATE_GSpecified
        {
            get
            {
                return this.bIRTH_DATE_GFieldSpecified;
            }
            set
            {
                this.bIRTH_DATE_GFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string BIRTH_DATE_H
        {
            get
            {
                return this.bIRTH_DATE_HField;
            }
            set
            {
                this.bIRTH_DATE_HField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool ExitStatus
        {
            get
            {
                return this.exitStatusField;
            }
            set
            {
                this.exitStatusField = value;
                this.ExitStatusSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool ExitStatusSpecified
        {
            get
            {
                return this.exitStatusFieldSpecified;
            }
            set
            {
                this.exitStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ExpirayDateHijri
        {
            get
            {
                return this.expirayDateHijriField;
            }
            set
            {
                this.expirayDateHijriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string FirstName_TR
        {
            get
            {
                return this.firstName_TRField;
            }
            set
            {
                this.firstName_TRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string IdNumber
        {
            get
            {
                return this.idNumberField;
            }
            set
            {
                this.idNumberField = value;
            }
        }
        
        /// <remarks/>
        public virtual bool IsAlive
        {
            get
            {
                return this.isAliveField;
            }
            set
            {
                this.isAliveField = value;
                this.IsAliveSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool IsAliveSpecified
        {
            get
            {
                return this.isAliveFieldSpecified;
            }
            set
            {
                this.isAliveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public virtual bool IsGovernmentEmployee
        {
            get
            {
                return this.isGovernmentEmployeeField;
            }
            set
            {
                this.isGovernmentEmployeeField = value;
                this.IsGovernmentEmployeeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool IsGovernmentEmployeeSpecified
        {
            get
            {
                return this.isGovernmentEmployeeFieldSpecified;
            }
            set
            {
                this.isGovernmentEmployeeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string IssueCity
        {
            get
            {
                return this.issueCityField;
            }
            set
            {
                this.issueCityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string IssueDateHijri
        {
            get
            {
                return this.issueDateHijriField;
            }
            set
            {
                this.issueDateHijriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string LastName_TR
        {
            get
            {
                return this.lastName_TRField;
            }
            set
            {
                this.lastName_TRField = value;
            }
        }
        
        /// <remarks/>
        public virtual int LegalStatus
        {
            get
            {
                return this.legalStatusField;
            }
            set
            {
                this.legalStatusField = value;
                this.LegalStatusSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool LegalStatusSpecified
        {
            get
            {
                return this.legalStatusFieldSpecified;
            }
            set
            {
                this.legalStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Nationality
        {
            get
            {
                return this.nationalityField;
            }
            set
            {
                this.nationalityField = value;
            }
        }
        
        /// <remarks/>
        public virtual int NationalityCode
        {
            get
            {
                return this.nationalityCodeField;
            }
            set
            {
                this.nationalityCodeField = value;
                this.NationalityCodeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool NationalityCodeSpecified
        {
            get
            {
                return this.nationalityCodeFieldSpecified;
            }
            set
            {
                this.nationalityCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string SEX
        {
            get
            {
                return this.sEXField;
            }
            set
            {
                this.sEXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string SecondName
        {
            get
            {
                return this.secondNameField;
            }
            set
            {
                this.secondNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string SecondName_TR
        {
            get
            {
                return this.secondName_TRField;
            }
            set
            {
                this.secondName_TRField = value;
            }
        }
        
        /// <remarks/>
        public virtual int SecurityStatus
        {
            get
            {
                return this.securityStatusField;
            }
            set
            {
                this.securityStatusField = value;
                this.SecurityStatusSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool SecurityStatusSpecified
        {
            get
            {
                return this.securityStatusFieldSpecified;
            }
            set
            {
                this.securityStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ThirdName
        {
            get
            {
                return this.thirdNameField;
            }
            set
            {
                this.thirdNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
    public partial class CR
    {
        
        private string activitiesField;
        
        private string addressField;
        
        private string businessTypeField;
        
        private int businessTypeIdField;
        
        private bool businessTypeIdFieldSpecified;
        
        private string cRLocationField;
        
        private string cRNameField;
        
        private string cRNationalityField;
        
        private string cRNumberField;
        
        private string cRStatusField;
        
        private string canceledDateField;
        
        private string canceledReasonField;
        
        private System.Nullable<decimal> capitalField;
        
        private bool capitalFieldSpecified;
        
        private System.Nullable<double> companyDurationField;
        
        private bool companyDurationFieldSpecified;
        
        private System.Nullable<decimal> company_PaidCapitalField;
        
        private bool company_PaidCapitalFieldSpecified;
        
        private string company_ShareCountField;
        
        private System.Nullable<decimal> company_SharePriceField;
        
        private bool company_SharePriceFieldSpecified;
        
        private string eNQ200_StatusField;
        
        private string expiryDateField;
        
        private string fAX1Field;
        
        private string fAX2Field;
        
        private ISICActivity[] iSICActivitiesField;
        
        private int isMainField;
        
        private bool isMainFieldSpecified;
        
        private System.Nullable<bool> is_eCRField;
        
        private bool is_eCRFieldSpecified;
        
        private string issueDateField;
        
        private string mainCRField;
        
        private System.Nullable<bool> nICUpdatedField;
        
        private bool nICUpdatedFieldSpecified;
        
        private System.Nullable<double> nationalNoField;
        
        private bool nationalNoFieldSpecified;
        
        private string pHONE1Field;
        
        private string pHONE2Field;
        
        private string pOBOX1Field;
        
        private string pOBOX2Field;
        
        private string recepDateField;
        
        private string transDateField;
        
        private string zipCodeField;
        
        private System.Nullable<int> eCR_CityIdField;
        
        private bool eCR_CityIdFieldSpecified;
        
        private string eCR_CityNameField;
        
        private System.Nullable<long> eCR_ContractIDField;
        
        private bool eCR_ContractIDFieldSpecified;
        
        private string eCR_EmailField;
        
        private System.Nullable<int> eCR_FiscalDateTypeField;
        
        private bool eCR_FiscalDateTypeFieldSpecified;
        
        private System.Nullable<int> eCR_FiscalEndDayField;
        
        private bool eCR_FiscalEndDayFieldSpecified;
        
        private System.Nullable<int> eCR_FiscalEndMonthField;
        
        private bool eCR_FiscalEndMonthFieldSpecified;
        
        private System.Nullable<bool> eCR_IsWaselField;
        
        private bool eCR_IsWaselFieldSpecified;
        
        private System.Nullable<double> eCR_LatField;
        
        private bool eCR_LatFieldSpecified;
        
        private System.Nullable<double> eCR_LngField;
        
        private bool eCR_LngFieldSpecified;
        
        private string eCR_MobileField;
        
        private System.Nullable<int> eCR_NeighbourhoodIdField;
        
        private bool eCR_NeighbourhoodIdFieldSpecified;
        
        private string eCR_OfficeNumberField;
        
        private string eCR_StreetField;
        
        private string eCR_WebsiteField;
        
        private string eC_RBuildingField;
        
        private string eC_RNeighbourhoodNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Activities
        {
            get
            {
                return this.activitiesField;
            }
            set
            {
                this.activitiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string BusinessType
        {
            get
            {
                return this.businessTypeField;
            }
            set
            {
                this.businessTypeField = value;
            }
        }
        
        /// <remarks/>
        public virtual int BusinessTypeId
        {
            get
            {
                return this.businessTypeIdField;
            }
            set
            {
                this.businessTypeIdField = value;
                this.BusinessTypeIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool BusinessTypeIdSpecified
        {
            get
            {
                return this.businessTypeIdFieldSpecified;
            }
            set
            {
                this.businessTypeIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRLocation
        {
            get
            {
                return this.cRLocationField;
            }
            set
            {
                this.cRLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRName
        {
            get
            {
                return this.cRNameField;
            }
            set
            {
                this.cRNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRNationality
        {
            get
            {
                return this.cRNationalityField;
            }
            set
            {
                this.cRNationalityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRNumber
        {
            get
            {
                return this.cRNumberField;
            }
            set
            {
                this.cRNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CRStatus
        {
            get
            {
                return this.cRStatusField;
            }
            set
            {
                this.cRStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CanceledDate
        {
            get
            {
                return this.canceledDateField;
            }
            set
            {
                this.canceledDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string CanceledReason
        {
            get
            {
                return this.canceledReasonField;
            }
            set
            {
                this.canceledReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<decimal> Capital
        {
            get
            {
                return this.capitalField;
            }
            set
            {
                this.capitalField = value;
                this.CapitalSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CapitalSpecified
        {
            get
            {
                return this.capitalFieldSpecified;
            }
            set
            {
                this.capitalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> CompanyDuration
        {
            get
            {
                return this.companyDurationField;
            }
            set
            {
                this.companyDurationField = value;
                this.CompanyDurationSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool CompanyDurationSpecified
        {
            get
            {
                return this.companyDurationFieldSpecified;
            }
            set
            {
                this.companyDurationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<decimal> Company_PaidCapital
        {
            get
            {
                return this.company_PaidCapitalField;
            }
            set
            {
                this.company_PaidCapitalField = value;
                this.Company_PaidCapitalSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool Company_PaidCapitalSpecified
        {
            get
            {
                return this.company_PaidCapitalFieldSpecified;
            }
            set
            {
                this.company_PaidCapitalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Company_ShareCount
        {
            get
            {
                return this.company_ShareCountField;
            }
            set
            {
                this.company_ShareCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<decimal> Company_SharePrice
        {
            get
            {
                return this.company_SharePriceField;
            }
            set
            {
                this.company_SharePriceField = value;
                this.Company_SharePriceSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool Company_SharePriceSpecified
        {
            get
            {
                return this.company_SharePriceFieldSpecified;
            }
            set
            {
                this.company_SharePriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ENQ200_Status
        {
            get
            {
                return this.eNQ200_StatusField;
            }
            set
            {
                this.eNQ200_StatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string FAX1
        {
            get
            {
                return this.fAX1Field;
            }
            set
            {
                this.fAX1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string FAX2
        {
            get
            {
                return this.fAX2Field;
            }
            set
            {
                this.fAX2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public virtual ISICActivity[] ISICActivities
        {
            get
            {
                return this.iSICActivitiesField;
            }
            set
            {
                this.iSICActivitiesField = value;
            }
        }
        
        /// <remarks/>
        public virtual int IsMain
        {
            get
            {
                return this.isMainField;
            }
            set
            {
                this.isMainField = value;
                this.IsMainSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool IsMainSpecified
        {
            get
            {
                return this.isMainFieldSpecified;
            }
            set
            {
                this.isMainFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<bool> Is_eCR
        {
            get
            {
                return this.is_eCRField;
            }
            set
            {
                this.is_eCRField = value;
                this.Is_eCRSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool Is_eCRSpecified
        {
            get
            {
                return this.is_eCRFieldSpecified;
            }
            set
            {
                this.is_eCRFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string MainCR
        {
            get
            {
                return this.mainCRField;
            }
            set
            {
                this.mainCRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<bool> NICUpdated
        {
            get
            {
                return this.nICUpdatedField;
            }
            set
            {
                this.nICUpdatedField = value;
                this.NICUpdatedSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool NICUpdatedSpecified
        {
            get
            {
                return this.nICUpdatedFieldSpecified;
            }
            set
            {
                this.nICUpdatedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> NationalNo
        {
            get
            {
                return this.nationalNoField;
            }
            set
            {
                this.nationalNoField = value;
                this.NationalNoSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool NationalNoSpecified
        {
            get
            {
                return this.nationalNoFieldSpecified;
            }
            set
            {
                this.nationalNoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PHONE1
        {
            get
            {
                return this.pHONE1Field;
            }
            set
            {
                this.pHONE1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string PHONE2
        {
            get
            {
                return this.pHONE2Field;
            }
            set
            {
                this.pHONE2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string POBOX1
        {
            get
            {
                return this.pOBOX1Field;
            }
            set
            {
                this.pOBOX1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string POBOX2
        {
            get
            {
                return this.pOBOX2Field;
            }
            set
            {
                this.pOBOX2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string RecepDate
        {
            get
            {
                return this.recepDateField;
            }
            set
            {
                this.recepDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string TransDate
        {
            get
            {
                return this.transDateField;
            }
            set
            {
                this.transDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> eCR_CityId
        {
            get
            {
                return this.eCR_CityIdField;
            }
            set
            {
                this.eCR_CityIdField = value;
                this.eCR_CityIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool eCR_CityIdSpecified
        {
            get
            {
                return this.eCR_CityIdFieldSpecified;
            }
            set
            {
                this.eCR_CityIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string eCR_CityName
        {
            get
            {
                return this.eCR_CityNameField;
            }
            set
            {
                this.eCR_CityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<long> eCR_ContractID
        {
            get
            {
                return this.eCR_ContractIDField;
            }
            set
            {
                this.eCR_ContractIDField = value;
                this.eCR_ContractIDSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool eCR_ContractIDSpecified
        {
            get
            {
                return this.eCR_ContractIDFieldSpecified;
            }
            set
            {
                this.eCR_ContractIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string eCR_Email
        {
            get
            {
                return this.eCR_EmailField;
            }
            set
            {
                this.eCR_EmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> eCR_FiscalDateType
        {
            get
            {
                return this.eCR_FiscalDateTypeField;
            }
            set
            {
                this.eCR_FiscalDateTypeField = value;
                this.eCR_FiscalDateTypeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool eCR_FiscalDateTypeSpecified
        {
            get
            {
                return this.eCR_FiscalDateTypeFieldSpecified;
            }
            set
            {
                this.eCR_FiscalDateTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> eCR_FiscalEndDay
        {
            get
            {
                return this.eCR_FiscalEndDayField;
            }
            set
            {
                this.eCR_FiscalEndDayField = value;
                this.eCR_FiscalEndDaySpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool eCR_FiscalEndDaySpecified
        {
            get
            {
                return this.eCR_FiscalEndDayFieldSpecified;
            }
            set
            {
                this.eCR_FiscalEndDayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> eCR_FiscalEndMonth
        {
            get
            {
                return this.eCR_FiscalEndMonthField;
            }
            set
            {
                this.eCR_FiscalEndMonthField = value;
                this.eCR_FiscalEndMonthSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool eCR_FiscalEndMonthSpecified
        {
            get
            {
                return this.eCR_FiscalEndMonthFieldSpecified;
            }
            set
            {
                this.eCR_FiscalEndMonthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<bool> eCR_IsWasel
        {
            get
            {
                return this.eCR_IsWaselField;
            }
            set
            {
                this.eCR_IsWaselField = value;
                this.eCR_IsWaselSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool eCR_IsWaselSpecified
        {
            get
            {
                return this.eCR_IsWaselFieldSpecified;
            }
            set
            {
                this.eCR_IsWaselFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> eCR_Lat
        {
            get
            {
                return this.eCR_LatField;
            }
            set
            {
                this.eCR_LatField = value;
                this.eCR_LatSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool eCR_LatSpecified
        {
            get
            {
                return this.eCR_LatFieldSpecified;
            }
            set
            {
                this.eCR_LatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<double> eCR_Lng
        {
            get
            {
                return this.eCR_LngField;
            }
            set
            {
                this.eCR_LngField = value;
                this.eCR_LngSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool eCR_LngSpecified
        {
            get
            {
                return this.eCR_LngFieldSpecified;
            }
            set
            {
                this.eCR_LngFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string eCR_Mobile
        {
            get
            {
                return this.eCR_MobileField;
            }
            set
            {
                this.eCR_MobileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual System.Nullable<int> eCR_NeighbourhoodId
        {
            get
            {
                return this.eCR_NeighbourhoodIdField;
            }
            set
            {
                this.eCR_NeighbourhoodIdField = value;
                this.eCR_NeighbourhoodIdSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool eCR_NeighbourhoodIdSpecified
        {
            get
            {
                return this.eCR_NeighbourhoodIdFieldSpecified;
            }
            set
            {
                this.eCR_NeighbourhoodIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string eCR_OfficeNumber
        {
            get
            {
                return this.eCR_OfficeNumberField;
            }
            set
            {
                this.eCR_OfficeNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string eCR_Street
        {
            get
            {
                return this.eCR_StreetField;
            }
            set
            {
                this.eCR_StreetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string eCR_Website
        {
            get
            {
                return this.eCR_WebsiteField;
            }
            set
            {
                this.eCR_WebsiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string eC_RBuilding
        {
            get
            {
                return this.eC_RBuildingField;
            }
            set
            {
                this.eC_RBuildingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string eC_RNeighbourhoodName
        {
            get
            {
                return this.eC_RNeighbourhoodNameField;
            }
            set
            {
                this.eC_RNeighbourhoodNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
    public partial class EmailParam
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public virtual string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendEmail", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendEmailRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ApiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] To;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Cc;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Bcc;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string TemplateCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Subject;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] BodyParameters;
        
        public SendEmailRequest()
        {
        }
        
        public SendEmailRequest(string ApiKey, string[] To, string[] Cc, string[] Bcc, string TemplateCode, string Subject, string[] BodyParameters)
        {
            this.ApiKey = ApiKey;
            this.To = To;
            this.Cc = Cc;
            this.Bcc = Bcc;
            this.TemplateCode = TemplateCode;
            this.Subject = Subject;
            this.BodyParameters = BodyParameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendEmailResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendEmailResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ReturnResults SendEmailResult;
        
        public SendEmailResponse()
        {
        }
        
        public SendEmailResponse(ReturnResults SendEmailResult)
        {
            this.SendEmailResult = SendEmailResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendEmailKeyVal", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendEmailKeyValRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ApiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] To;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Cc;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Bcc;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string TemplateCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Subject;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
        public EmailParam[] BodyParametersKeyValue;
        
        public SendEmailKeyValRequest()
        {
        }
        
        public SendEmailKeyValRequest(string ApiKey, string[] To, string[] Cc, string[] Bcc, string TemplateCode, string Subject, EmailParam[] BodyParametersKeyValue)
        {
            this.ApiKey = ApiKey;
            this.To = To;
            this.Cc = Cc;
            this.Bcc = Bcc;
            this.TemplateCode = TemplateCode;
            this.Subject = Subject;
            this.BodyParametersKeyValue = BodyParametersKeyValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendEmailKeyValResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendEmailKeyValResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ReturnResults SendEmailKeyValResult;
        
        public SendEmailKeyValResponse()
        {
        }
        
        public SendEmailKeyValResponse(ReturnResults SendEmailKeyValResult)
        {
            this.SendEmailKeyValResult = SendEmailKeyValResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendSMS", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendSMSRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ApiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Mobile;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string TemplateCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] BodyParameters;
        
        public SendSMSRequest()
        {
        }
        
        public SendSMSRequest(string ApiKey, string Mobile, string TemplateCode, string[] BodyParameters)
        {
            this.ApiKey = ApiKey;
            this.Mobile = Mobile;
            this.TemplateCode = TemplateCode;
            this.BodyParameters = BodyParameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendSMSResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendSMSResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ReturnResults SendSMSResult;
        
        public SendSMSResponse()
        {
        }
        
        public SendSMSResponse(ReturnResults SendSMSResult)
        {
            this.SendSMSResult = SendSMSResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        public GetCRInfoRequest()
        {
        }
        
        public GetCRInfoRequest(string Apikey, string CR)
        {
            this.Apikey = Apikey;
            this.CR = CR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRInfoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CR GetCRInfoResult;
        
        public GetCRInfoResponse()
        {
        }
        
        public GetCRInfoResponse(CR GetCRInfoResult)
        {
            this.GetCRInfoResult = GetCRInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPersonInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPersonInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public double NationalId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string date;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int uType;
        
        public GetPersonInfoRequest()
        {
        }
        
        public GetPersonInfoRequest(string Apikey, double NationalId, string date, int uType)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
            this.date = date;
            this.uType = uType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPersonInfoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPersonInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public YaqeenInfo GetPersonInfoResult;
        
        public GetPersonInfoResponse()
        {
        }
        
        public GetPersonInfoResponse(YaqeenInfo GetPersonInfoResult)
        {
            this.GetPersonInfoResult = GetPersonInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MakeOTPRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MakeOTPRequestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public bool isAbsherOTP;
        
        public MakeOTPRequestRequest()
        {
        }
        
        public MakeOTPRequestRequest(string Apikey, string Username, bool isAbsherOTP)
        {
            this.Apikey = Apikey;
            this.Username = Username;
            this.isAbsherOTP = isAbsherOTP;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MakeOTPRequestResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MakeOTPRequestResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public long MakeOTPRequestResult;
        
        public MakeOTPRequestResponse()
        {
        }
        
        public MakeOTPRequestResponse(long MakeOTPRequestResult)
        {
            this.MakeOTPRequestResult = MakeOTPRequestResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MakeOTPRequestByNID", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MakeOTPRequestByNIDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public MakeOTPRequestByNIDRequest()
        {
        }
        
        public MakeOTPRequestByNIDRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MakeOTPRequestByNIDResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MakeOTPRequestByNIDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public long MakeOTPRequestByNIDResult;
        
        public MakeOTPRequestByNIDResponse()
        {
        }
        
        public MakeOTPRequestByNIDResponse(long MakeOTPRequestByNIDResult)
        {
            this.MakeOTPRequestByNIDResult = MakeOTPRequestByNIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckOTPIsValid", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CheckOTPIsValidRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public long RequestId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int OTP;
        
        public CheckOTPIsValidRequest()
        {
        }
        
        public CheckOTPIsValidRequest(string Apikey, long RequestId, int OTP)
        {
            this.Apikey = Apikey;
            this.RequestId = RequestId;
            this.OTP = OTP;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckOTPIsValidResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CheckOTPIsValidResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool CheckOTPIsValidResult;
        
        public CheckOTPIsValidResponse()
        {
        }
        
        public CheckOTPIsValidResponse(bool CheckOTPIsValidResult)
        {
            this.CheckOTPIsValidResult = CheckOTPIsValidResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEFileContactOfficer", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEFileContactOfficerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string token;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string clientid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string clientPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public bool IsDev;
        
        public GetEFileContactOfficerRequest()
        {
        }
        
        public GetEFileContactOfficerRequest(string key, string token, string clientid, string clientPassword, bool IsDev)
        {
            this.key = key;
            this.token = token;
            this.clientid = clientid;
            this.clientPassword = clientPassword;
            this.IsDev = IsDev;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEFileContactOfficerResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEFileContactOfficerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ContactOfficerModel GetEFileContactOfficerResult;
        
        public GetEFileContactOfficerResponse()
        {
        }
        
        public GetEFileContactOfficerResponse(ContactOfficerModel GetEFileContactOfficerResult)
        {
            this.GetEFileContactOfficerResult = GetEFileContactOfficerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthenticateByAD", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthenticateByADRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string UserName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Password;
        
        public AuthenticateByADRequest()
        {
        }
        
        public AuthenticateByADRequest(string key, string UserName, string Password)
        {
            this.key = key;
            this.UserName = UserName;
            this.Password = Password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthenticateByADResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthenticateByADResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool AuthenticateByADResult;
        
        public AuthenticateByADResponse()
        {
        }
        
        public AuthenticateByADResponse(bool AuthenticateByADResult)
        {
            this.AuthenticateByADResult = AuthenticateByADResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetADUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetADUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string UserName;
        
        public GetADUserRequest()
        {
        }
        
        public GetADUserRequest(string key, string UserName)
        {
            this.key = key;
            this.UserName = UserName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetADUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetADUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ADUser GetADUserResult;
        
        public GetADUserResponse()
        {
        }
        
        public GetADUserResponse(ADUser GetADUserResult)
        {
            this.GetADUserResult = GetADUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeData", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeeDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Email;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string UserName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> EmpId;
        
        public GetEmployeeDataRequest()
        {
        }
        
        public GetEmployeeDataRequest(string key, string Email, string NID, string UserName, System.Nullable<int> EmpId)
        {
            this.key = key;
            this.Email = Email;
            this.NID = NID;
            this.UserName = UserName;
            this.EmpId = EmpId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeDataResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeeDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public EmployeeFullData GetEmployeeDataResult;
        
        public GetEmployeeDataResponse()
        {
        }
        
        public GetEmployeeDataResponse(EmployeeFullData GetEmployeeDataResult)
        {
            this.GetEmployeeDataResult = GetEmployeeDataResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNSaveDoc", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNSaveDocRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNUserName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNUrl;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNOS;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNClassName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework")]
        public FNAttribute[] data;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public byte[] fileData;
        
        public FNSaveDocRequest()
        {
        }
        
        public FNSaveDocRequest(string key, string FNUserName, string FNPassword, string FNUrl, string FNOS, string FNClassName, FNAttribute[] data, string FileName, byte[] fileData)
        {
            this.key = key;
            this.FNUserName = FNUserName;
            this.FNPassword = FNPassword;
            this.FNUrl = FNUrl;
            this.FNOS = FNOS;
            this.FNClassName = FNClassName;
            this.data = data;
            this.FileName = FileName;
            this.fileData = fileData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNSaveDocResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNSaveDocResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNSaveDocResult;
        
        public FNSaveDocResponse()
        {
        }
        
        public FNSaveDocResponse(string FNSaveDocResult)
        {
            this.FNSaveDocResult = FNSaveDocResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNDeleteDoc", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNDeleteDocRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNUserName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNUrl;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNOS;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string DocId;
        
        public FNDeleteDocRequest()
        {
        }
        
        public FNDeleteDocRequest(string key, string FNUserName, string FNPassword, string FNUrl, string FNOS, string DocId)
        {
            this.key = key;
            this.FNUserName = FNUserName;
            this.FNPassword = FNPassword;
            this.FNUrl = FNUrl;
            this.FNOS = FNOS;
            this.DocId = DocId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNDeleteDocResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNDeleteDocResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool FNDeleteDocResult;
        
        public FNDeleteDocResponse()
        {
        }
        
        public FNDeleteDocResponse(bool FNDeleteDocResult)
        {
            this.FNDeleteDocResult = FNDeleteDocResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNGetDoc", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNGetDocRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNUserName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNUrl;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNOS;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNClassName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string DocId;
        
        public FNGetDocRequest()
        {
        }
        
        public FNGetDocRequest(string key, string FNUserName, string FNPassword, string FNUrl, string FNOS, string FNClassName, string DocId)
        {
            this.key = key;
            this.FNUserName = FNUserName;
            this.FNPassword = FNPassword;
            this.FNUrl = FNUrl;
            this.FNOS = FNOS;
            this.FNClassName = FNClassName;
            this.DocId = DocId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNGetDocResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNGetDocResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public byte[] FNGetDocResult;
        
        public FNGetDocResponse()
        {
        }
        
        public FNGetDocResponse(byte[] FNGetDocResult)
        {
            this.FNGetDocResult = FNGetDocResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNGetDocInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNGetDocInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNClassName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string DocId;
        
        public FNGetDocInfoRequest()
        {
        }
        
        public FNGetDocInfoRequest(string key, string FNClassName, string DocId)
        {
            this.key = key;
            this.FNClassName = FNClassName;
            this.DocId = DocId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNGetDocInfoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNGetDocInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public FNInfo FNGetDocInfoResult;
        
        public FNGetDocInfoResponse()
        {
        }
        
        public FNGetDocInfoResponse(FNInfo FNGetDocInfoResult)
        {
            this.FNGetDocInfoResult = FNGetDocInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNSaveDocInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNSaveDocInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNClassName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework")]
        public FNAttribute[] data;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public byte[] fileData;
        
        public FNSaveDocInfoRequest()
        {
        }
        
        public FNSaveDocInfoRequest(string key, string FNClassName, FNAttribute[] data, string FileName, byte[] fileData)
        {
            this.key = key;
            this.FNClassName = FNClassName;
            this.data = data;
            this.FileName = FileName;
            this.fileData = fileData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNSaveDocInfoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNSaveDocInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FNSaveDocInfoResult;
        
        public FNSaveDocInfoResponse()
        {
        }
        
        public FNSaveDocInfoResponse(string FNSaveDocInfoResult)
        {
            this.FNSaveDocInfoResult = FNSaveDocInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNDeleteDocInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNDeleteDocInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string DocId;
        
        public FNDeleteDocInfoRequest()
        {
        }
        
        public FNDeleteDocInfoRequest(string key, string DocId)
        {
            this.key = key;
            this.DocId = DocId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FNDeleteDocInfoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FNDeleteDocInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool FNDeleteDocInfoResult;
        
        public FNDeleteDocInfoResponse()
        {
        }
        
        public FNDeleteDocInfoResponse(bool FNDeleteDocInfoResult)
        {
            this.FNDeleteDocInfoResult = FNDeleteDocInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ShearchInAD", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ShearchInADRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string textShearch;
        
        public ShearchInADRequest()
        {
        }
        
        public ShearchInADRequest(string key, string textShearch)
        {
            this.key = key;
            this.textShearch = textShearch;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ShearchInADResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ShearchInADResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Services")]
        public ADUser[] ShearchInADResult;
        
        public ShearchInADResponse()
        {
        }
        
        public ShearchInADResponse(ADUser[] ShearchInADResult)
        {
            this.ShearchInADResult = ShearchInADResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EfileLogout", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EfileLogoutRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string token;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public bool IsDev;
        
        public EfileLogoutRequest()
        {
        }
        
        public EfileLogoutRequest(string key, string token, bool IsDev)
        {
            this.key = key;
            this.token = token;
            this.IsDev = IsDev;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EfileLogoutResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EfileLogoutResponse
    {
        
        public EfileLogoutResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EfileLogin", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EfileLoginRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string clientId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string secret;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public bool isDev;
        
        public EfileLoginRequest()
        {
        }
        
        public EfileLoginRequest(string key, string clientId, string secret, string NID, string password, bool isDev)
        {
            this.key = key;
            this.clientId = clientId;
            this.secret = secret;
            this.NID = NID;
            this.password = password;
            this.isDev = isDev;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EfileLoginResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EfileLoginResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string EfileLoginResult;
        
        public EfileLoginResponse()
        {
        }
        
        public EfileLoginResponse(string EfileLoginResult)
        {
            this.EfileLoginResult = EfileLoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEFileUserDataByNID", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEFileUserDataByNIDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string clientid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string secret;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public bool IsDev;
        
        public GetEFileUserDataByNIDRequest()
        {
        }
        
        public GetEFileUserDataByNIDRequest(string key, string NID, string clientid, string secret, bool IsDev)
        {
            this.key = key;
            this.NID = NID;
            this.clientid = clientid;
            this.secret = secret;
            this.IsDev = IsDev;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEFileUserDataByNIDResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEFileUserDataByNIDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ContactOfficerModel GetEFileUserDataByNIDResult;
        
        public GetEFileUserDataByNIDResponse()
        {
        }
        
        public GetEFileUserDataByNIDResponse(ContactOfficerModel GetEFileUserDataByNIDResult)
        {
            this.GetEFileUserDataByNIDResult = GetEFileUserDataByNIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllCRForNationalId", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllCRForNationalIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetAllCRForNationalIdRequest()
        {
        }
        
        public GetAllCRForNationalIdRequest(string key, string NationalId)
        {
            this.key = key;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllCRForNationalIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllCRForNationalIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
        public CRForPerson[] GetAllCRForNationalIdResult;
        
        public GetAllCRForNationalIdResponse()
        {
        }
        
        public GetAllCRForNationalIdResponse(CRForPerson[] GetAllCRForNationalIdResult)
        {
            this.GetAllCRForNationalIdResult = GetAllCRForNationalIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllPersonsForCR", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllPersonsForCRRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        public GetAllPersonsForCRRequest()
        {
        }
        
        public GetAllPersonsForCRRequest(string key, string CR)
        {
            this.key = key;
            this.CR = CR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllPersonsForCRResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllPersonsForCRResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
        public CRPerson[] GetAllPersonsForCRResult;
        
        public GetAllPersonsForCRResponse()
        {
        }
        
        public GetAllPersonsForCRResponse(CRPerson[] GetAllPersonsForCRResult)
        {
            this.GetAllPersonsForCRResult = GetAllPersonsForCRResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetFakeAllPersonsForCR", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetFakeAllPersonsForCRRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        public GetFakeAllPersonsForCRRequest()
        {
        }
        
        public GetFakeAllPersonsForCRRequest(string key, string CR)
        {
            this.key = key;
            this.CR = CR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetFakeAllPersonsForCRResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetFakeAllPersonsForCRResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
        public CRPerson[] GetFakeAllPersonsForCRResult;
        
        public GetFakeAllPersonsForCRResponse()
        {
        }
        
        public GetFakeAllPersonsForCRResponse(CRPerson[] GetFakeAllPersonsForCRResult)
        {
            this.GetFakeAllPersonsForCRResult = GetFakeAllPersonsForCRResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GenerateSadadBill", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GenerateSadadBillRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public GenerateBillSadadRequest model;
        
        public GenerateSadadBillRequest()
        {
        }
        
        public GenerateSadadBillRequest(string key, GenerateBillSadadRequest model)
        {
            this.key = key;
            this.model = model;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GenerateSadadBillResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GenerateSadadBillResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public GenerateBillSadadResponse GenerateSadadBillResult;
        
        public GenerateSadadBillResponse()
        {
        }
        
        public GenerateSadadBillResponse(GenerateBillSadadResponse GenerateSadadBillResult)
        {
            this.GenerateSadadBillResult = GenerateSadadBillResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetBillDetail", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetBillDetailRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public GetBillDetailRequest model;
        
        public GetBillDetailRequest1()
        {
        }
        
        public GetBillDetailRequest1(string key, GetBillDetailRequest model)
        {
            this.key = key;
            this.model = model;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetBillDetailResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetBillDetailResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public GetBillDetailResponse GetBillDetailResult;
        
        public GetBillDetailResponse1()
        {
        }
        
        public GetBillDetailResponse1(GetBillDetailResponse GetBillDetailResult)
        {
            this.GetBillDetailResult = GetBillDetailResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CancelBill", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CancelBillRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CancelBillRequest model;
        
        public CancelBillRequest1()
        {
        }
        
        public CancelBillRequest1(string key, CancelBillRequest model)
        {
            this.key = key;
            this.model = model;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CancelBillResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CancelBillResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ChangeBillResponse CancelBillResult;
        
        public CancelBillResponse()
        {
        }
        
        public CancelBillResponse(ChangeBillResponse CancelBillResult)
        {
            this.CancelBillResult = CancelBillResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRBranches", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRBranchesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        public GetCRBranchesRequest()
        {
        }
        
        public GetCRBranchesRequest(string Apikey, string CR)
        {
            this.Apikey = Apikey;
            this.CR = CR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRBranchesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRBranchesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
        public CR[] GetCRBranchesResult;
        
        public GetCRBranchesResponse()
        {
        }
        
        public GetCRBranchesResponse(CR[] GetCRBranchesResult)
        {
            this.GetCRBranchesResult = GetCRBranchesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDelegatedReferences", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDelegatedReferencesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string clientid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string secret;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string delegatorNid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CRNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public bool IsDev;
        
        public GetDelegatedReferencesRequest()
        {
        }
        
        public GetDelegatedReferencesRequest(string Apikey, string NID, string clientid, string secret, string delegatorNid, string CRNumber, bool IsDev)
        {
            this.Apikey = Apikey;
            this.NID = NID;
            this.clientid = clientid;
            this.secret = secret;
            this.delegatorNid = delegatorNid;
            this.CRNumber = CRNumber;
            this.IsDev = IsDev;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDelegatedReferencesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDelegatedReferencesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
        public EFileServiceDelegated[] GetDelegatedReferencesResult;
        
        public GetDelegatedReferencesResponse()
        {
        }
        
        public GetDelegatedReferencesResponse(EFileServiceDelegated[] GetDelegatedReferencesResult)
        {
            this.GetDelegatedReferencesResult = GetDelegatedReferencesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMultiCRsInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetMultiCRsInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] CRs;
        
        public GetMultiCRsInfoRequest()
        {
        }
        
        public GetMultiCRsInfoRequest(string Apikey, string[] CRs)
        {
            this.Apikey = Apikey;
            this.CRs = CRs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMultiCRsInfoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetMultiCRsInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
        public CR[] GetMultiCRsInfoResult;
        
        public GetMultiCRsInfoResponse()
        {
        }
        
        public GetMultiCRsInfoResponse(CR[] GetMultiCRsInfoResult)
        {
            this.GetMultiCRsInfoResult = GetMultiCRsInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GenrateMCISadadBill", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GenrateMCISadadBillRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public MCISadadModel model;
        
        public GenrateMCISadadBillRequest()
        {
        }
        
        public GenrateMCISadadBillRequest(string Apikey, MCISadadModel model)
        {
            this.Apikey = Apikey;
            this.model = model;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GenrateMCISadadBillResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GenrateMCISadadBillResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public long GenrateMCISadadBillResult;
        
        public GenrateMCISadadBillResponse()
        {
        }
        
        public GenrateMCISadadBillResponse(long GenrateMCISadadBillResult)
        {
            this.GenrateMCISadadBillResult = GenrateMCISadadBillResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMCISadadBillStatus", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetMCISadadBillStatusRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string BillingNumber;
        
        public GetMCISadadBillStatusRequest()
        {
        }
        
        public GetMCISadadBillStatusRequest(string Apikey, string BillingNumber)
        {
            this.Apikey = Apikey;
            this.BillingNumber = BillingNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMCISadadBillStatusResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetMCISadadBillStatusResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetMCISadadBillStatusResult;
        
        public GetMCISadadBillStatusResponse()
        {
        }
        
        public GetMCISadadBillStatusResponse(string GetMCISadadBillStatusResult)
        {
            this.GetMCISadadBillStatusResult = GetMCISadadBillStatusResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllTMForNationalId", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllTMForNationalIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetAllTMForNationalIdRequest()
        {
        }
        
        public GetAllTMForNationalIdRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllTMForNationalIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllTMForNationalIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.TMS")]
        public TradeMarkInfo[] GetAllTMForNationalIdResult;
        
        public GetAllTMForNationalIdResponse()
        {
        }
        
        public GetAllTMForNationalIdResponse(TradeMarkInfo[] GetAllTMForNationalIdResult)
        {
            this.GetAllTMForNationalIdResult = GetAllTMForNationalIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllProfessionsForNationalId", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllProfessionsForNationalIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetAllProfessionsForNationalIdRequest()
        {
        }
        
        public GetAllProfessionsForNationalIdRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllProfessionsForNationalIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllProfessionsForNationalIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Professions")]
        public ProfessionInfo[] GetAllProfessionsForNationalIdResult;
        
        public GetAllProfessionsForNationalIdResponse()
        {
        }
        
        public GetAllProfessionsForNationalIdResponse(ProfessionInfo[] GetAllProfessionsForNationalIdResult)
        {
            this.GetAllProfessionsForNationalIdResult = GetAllProfessionsForNationalIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPersonForCRWithCOC", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPersonForCRWithCOCRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CRNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string BirthDate;
        
        public GetPersonForCRWithCOCRequest()
        {
        }
        
        public GetPersonForCRWithCOCRequest(string Apikey, string CRNumber, string NationalId, string BirthDate)
        {
            this.Apikey = Apikey;
            this.CRNumber = CRNumber;
            this.NationalId = NationalId;
            this.BirthDate = BirthDate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPersonForCRWithCOCResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPersonForCRWithCOCResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public PersonForCRWithCOC GetPersonForCRWithCOCResult;
        
        public GetPersonForCRWithCOCResponse()
        {
        }
        
        public GetPersonForCRWithCOCResponse(PersonForCRWithCOC GetPersonForCRWithCOCResult)
        {
            this.GetPersonForCRWithCOCResult = GetPersonForCRWithCOCResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMonshaatRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetMonshaatRequestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CRNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public bool IsConsolidated;
        
        public GetMonshaatRequestRequest()
        {
        }
        
        public GetMonshaatRequestRequest(string Apikey, string CRNo, bool IsConsolidated)
        {
            this.Apikey = Apikey;
            this.CRNo = CRNo;
            this.IsConsolidated = IsConsolidated;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMonshaatRequestResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetMonshaatRequestResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
        public GetMonshaatRequestResult[] GetMonshaatRequestResult;
        
        public GetMonshaatRequestResponse()
        {
        }
        
        public GetMonshaatRequestResponse(GetMonshaatRequestResult[] GetMonshaatRequestResult)
        {
            this.GetMonshaatRequestResult = GetMonshaatRequestResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOwnerMobileByCRNumber", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetOwnerMobileByCRNumberRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CRNumber;
        
        public GetOwnerMobileByCRNumberRequest()
        {
        }
        
        public GetOwnerMobileByCRNumberRequest(string Apikey, string CRNumber)
        {
            this.Apikey = Apikey;
            this.CRNumber = CRNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOwnerMobileByCRNumberResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetOwnerMobileByCRNumberResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CROwnerInfo GetOwnerMobileByCRNumberResult;
        
        public GetOwnerMobileByCRNumberResponse()
        {
        }
        
        public GetOwnerMobileByCRNumberResponse(CROwnerInfo GetOwnerMobileByCRNumberResult)
        {
            this.GetOwnerMobileByCRNumberResult = GetOwnerMobileByCRNumberResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllTicketsForCRNumber", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllTicketsForCRNumberRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CRNumber;
        
        public GetAllTicketsForCRNumberRequest()
        {
        }
        
        public GetAllTicketsForCRNumberRequest(string Apikey, string CRNumber)
        {
            this.Apikey = Apikey;
            this.CRNumber = CRNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllTicketsForCRNumberResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllTicketsForCRNumberResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Professions")]
        public TicketInfo[] GetAllTicketsForCRNumberResult;
        
        public GetAllTicketsForCRNumberResponse()
        {
        }
        
        public GetAllTicketsForCRNumberResponse(TicketInfo[] GetAllTicketsForCRNumberResult)
        {
            this.GetAllTicketsForCRNumberResult = GetAllTicketsForCRNumberResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllRelatedCrsForCRNumber", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllRelatedCrsForCRNumberRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        public GetAllRelatedCrsForCRNumberRequest()
        {
        }
        
        public GetAllRelatedCrsForCRNumberRequest(string Apikey, string CR)
        {
            this.Apikey = Apikey;
            this.CR = CR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllRelatedCrsForCRNumberResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllRelatedCrsForCRNumberResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
        public CR[] GetAllRelatedCrsForCRNumberResult;
        
        public GetAllRelatedCrsForCRNumberResponse()
        {
        }
        
        public GetAllRelatedCrsForCRNumberResponse(CR[] GetAllRelatedCrsForCRNumberResult)
        {
            this.GetAllRelatedCrsForCRNumberResult = GetAllRelatedCrsForCRNumberResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllTicketsForNationalId", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllTicketsForNationalIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetAllTicketsForNationalIdRequest()
        {
        }
        
        public GetAllTicketsForNationalIdRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllTicketsForNationalIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllTicketsForNationalIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.Professions")]
        public TicketInfo[] GetAllTicketsForNationalIdResult;
        
        public GetAllTicketsForNationalIdResponse()
        {
        }
        
        public GetAllTicketsForNationalIdResponse(TicketInfo[] GetAllTicketsForNationalIdResult)
        {
            this.GetAllTicketsForNationalIdResult = GetAllTicketsForNationalIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllGPMLicensesForNationalId", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllGPMLicensesForNationalIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetAllGPMLicensesForNationalIdRequest()
        {
        }
        
        public GetAllGPMLicensesForNationalIdRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllGPMLicensesForNationalIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllGPMLicensesForNationalIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.GPMLicenses")]
        public GPMLicensesInfo[] GetAllGPMLicensesForNationalIdResult;
        
        public GetAllGPMLicensesForNationalIdResponse()
        {
        }
        
        public GetAllGPMLicensesForNationalIdResponse(GPMLicensesInfo[] GetAllGPMLicensesForNationalIdResult)
        {
            this.GetAllGPMLicensesForNationalIdResult = GetAllGPMLicensesForNationalIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllLabLicensesForNationalId", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllLabLicensesForNationalIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetAllLabLicensesForNationalIdRequest()
        {
        }
        
        public GetAllLabLicensesForNationalIdRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllLabLicensesForNationalIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllLabLicensesForNationalIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models.LabLicenses")]
        public LabLicensesInfo[] GetAllLabLicensesForNationalIdResult;
        
        public GetAllLabLicensesForNationalIdResponse()
        {
        }
        
        public GetAllLabLicensesForNationalIdResponse(LabLicensesInfo[] GetAllLabLicensesForNationalIdResult)
        {
            this.GetAllLabLicensesForNationalIdResult = GetAllLabLicensesForNationalIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllCRForNationalIdWithoutDuplication", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllCRForNationalIdWithoutDuplicationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetAllCRForNationalIdWithoutDuplicationRequest()
        {
        }
        
        public GetAllCRForNationalIdWithoutDuplicationRequest(string key, string NationalId)
        {
            this.key = key;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllCRForNationalIdWithoutDuplicationResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllCRForNationalIdWithoutDuplicationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/MCI.Models")]
        public CRForPerson[] GetAllCRForNationalIdWithoutDuplicationResult;
        
        public GetAllCRForNationalIdWithoutDuplicationResponse()
        {
        }
        
        public GetAllCRForNationalIdWithoutDuplicationResponse(CRForPerson[] GetAllCRForNationalIdWithoutDuplicationResult)
        {
            this.GetAllCRForNationalIdWithoutDuplicationResult = GetAllCRForNationalIdWithoutDuplicationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRCountWithStatusForNationalId", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRCountWithStatusForNationalIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetCRCountWithStatusForNationalIdRequest()
        {
        }
        
        public GetCRCountWithStatusForNationalIdRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRCountWithStatusForNationalIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRCountWithStatusForNationalIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
        public ServicesCountsModel[] GetCRCountWithStatusForNationalIdResult;
        
        public GetCRCountWithStatusForNationalIdResponse()
        {
        }
        
        public GetCRCountWithStatusForNationalIdResponse(ServicesCountsModel[] GetCRCountWithStatusForNationalIdResult)
        {
            this.GetCRCountWithStatusForNationalIdResult = GetCRCountWithStatusForNationalIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLicenseCountWithStatusForNationalId", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetLicenseCountWithStatusForNationalIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetLicenseCountWithStatusForNationalIdRequest()
        {
        }
        
        public GetLicenseCountWithStatusForNationalIdRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLicenseCountWithStatusForNationalIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetLicenseCountWithStatusForNationalIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
        public ServicesCountsModel[] GetLicenseCountWithStatusForNationalIdResult;
        
        public GetLicenseCountWithStatusForNationalIdResponse()
        {
        }
        
        public GetLicenseCountWithStatusForNationalIdResponse(ServicesCountsModel[] GetLicenseCountWithStatusForNationalIdResult)
        {
            this.GetLicenseCountWithStatusForNationalIdResult = GetLicenseCountWithStatusForNationalIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTrademarkCountWithStatusForNationalId", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetTrademarkCountWithStatusForNationalIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetTrademarkCountWithStatusForNationalIdRequest()
        {
        }
        
        public GetTrademarkCountWithStatusForNationalIdRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTrademarkCountWithStatusForNationalIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetTrademarkCountWithStatusForNationalIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
        public ServicesCountsModel[] GetTrademarkCountWithStatusForNationalIdResult;
        
        public GetTrademarkCountWithStatusForNationalIdResponse()
        {
        }
        
        public GetTrademarkCountWithStatusForNationalIdResponse(ServicesCountsModel[] GetTrademarkCountWithStatusForNationalIdResult)
        {
            this.GetTrademarkCountWithStatusForNationalIdResult = GetTrademarkCountWithStatusForNationalIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetViolationCountWithStatusForNationalId", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetViolationCountWithStatusForNationalIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetViolationCountWithStatusForNationalIdRequest()
        {
        }
        
        public GetViolationCountWithStatusForNationalIdRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetViolationCountWithStatusForNationalIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetViolationCountWithStatusForNationalIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework.Models")]
        public ServicesCountsModel[] GetViolationCountWithStatusForNationalIdResult;
        
        public GetViolationCountWithStatusForNationalIdResponse()
        {
        }
        
        public GetViolationCountWithStatusForNationalIdResponse(ServicesCountsModel[] GetViolationCountWithStatusForNationalIdResult)
        {
            this.GetViolationCountWithStatusForNationalIdResult = GetViolationCountWithStatusForNationalIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRQRImage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRQRImageRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        public GetCRQRImageRequest()
        {
        }
        
        public GetCRQRImageRequest(string Apikey, string CR)
        {
            this.Apikey = Apikey;
            this.CR = CR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRQRImageResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRQRImageResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CRQRResult GetCRQRImageResult;
        
        public GetCRQRImageResponse()
        {
        }
        
        public GetCRQRImageResponse(CRQRResult GetCRQRImageResult)
        {
            this.GetCRQRImageResult = GetCRQRImageResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRCertificate", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRCertificateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        public GetCRCertificateRequest()
        {
        }
        
        public GetCRCertificateRequest(string Apikey, string CR)
        {
            this.Apikey = Apikey;
            this.CR = CR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRCertificateResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRCertificateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CRCertificateResult GetCRCertificateResult;
        
        public GetCRCertificateResponse()
        {
        }
        
        public GetCRCertificateResponse(CRCertificateResult GetCRCertificateResult)
        {
            this.GetCRCertificateResult = GetCRCertificateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendNewEfadaRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendNewEfadaRequestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public bool IsCRMain;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public SendNewEfadaRequestRequest()
        {
        }
        
        public SendNewEfadaRequestRequest(string Apikey, string CR, bool IsCRMain, string NationalId)
        {
            this.Apikey = Apikey;
            this.CR = CR;
            this.IsCRMain = IsCRMain;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendNewEfadaRequestResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendNewEfadaRequestResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public EfadaResponse SendNewEfadaRequestResult;
        
        public SendNewEfadaRequestResponse()
        {
        }
        
        public SendNewEfadaRequestResponse(EfadaResponse SendNewEfadaRequestResult)
        {
            this.SendNewEfadaRequestResult = SendNewEfadaRequestResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEfadaRequests", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEfadaRequestsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetEfadaRequestsRequest()
        {
        }
        
        public GetEfadaRequestsRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEfadaRequestsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEfadaRequestsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public EfadaRequests GetEfadaRequestsResult;
        
        public GetEfadaRequestsResponse()
        {
        }
        
        public GetEfadaRequestsResponse(EfadaRequests GetEfadaRequestsResult)
        {
            this.GetEfadaRequestsResult = GetEfadaRequestsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRQRUrl", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRQRUrlRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        public GetCRQRUrlRequest()
        {
        }
        
        public GetCRQRUrlRequest(string Apikey, string CR)
        {
            this.Apikey = Apikey;
            this.CR = CR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCRQRUrlResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCRQRUrlResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CRQRUrlResult GetCRQRUrlResult;
        
        public GetCRQRUrlResponse()
        {
        }
        
        public GetCRQRUrlResponse(CRQRUrlResult GetCRQRUrlResult)
        {
            this.GetCRQRUrlResult = GetCRQRUrlResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidateShareholdersRecordUpdate", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ValidateShareholdersRecordUpdateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        public ValidateShareholdersRecordUpdateRequest()
        {
        }
        
        public ValidateShareholdersRecordUpdateRequest(string Apikey, string CR)
        {
            this.Apikey = Apikey;
            this.CR = CR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidateShareholdersRecordUpdateResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ValidateShareholdersRecordUpdateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int ValidateShareholdersRecordUpdateResult;
        
        public ValidateShareholdersRecordUpdateResponse()
        {
        }
        
        public ValidateShareholdersRecordUpdateResponse(int ValidateShareholdersRecordUpdateResult)
        {
            this.ValidateShareholdersRecordUpdateResult = ValidateShareholdersRecordUpdateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetShareholdersListByCRNumber", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetShareholdersListByCRNumberRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CR;
        
        public GetShareholdersListByCRNumberRequest()
        {
        }
        
        public GetShareholdersListByCRNumberRequest(string Apikey, string CR)
        {
            this.Apikey = Apikey;
            this.CR = CR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetShareholdersListByCRNumberResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetShareholdersListByCRNumberResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework")]
        public GetShareholdersListByCRNumber_Result[] GetShareholdersListByCRNumberResult;
        
        public GetShareholdersListByCRNumberResponse()
        {
        }
        
        public GetShareholdersListByCRNumberResponse(GetShareholdersListByCRNumber_Result[] GetShareholdersListByCRNumberResult)
        {
            this.GetShareholdersListByCRNumberResult = GetShareholdersListByCRNumberResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetShareholderCRsByIdentityNumber", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetShareholderCRsByIdentityNumberRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Apikey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NationalId;
        
        public GetShareholderCRsByIdentityNumberRequest()
        {
        }
        
        public GetShareholderCRsByIdentityNumberRequest(string Apikey, string NationalId)
        {
            this.Apikey = Apikey;
            this.NationalId = NationalId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetShareholderCRsByIdentityNumberResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetShareholderCRsByIdentityNumberResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Framework")]
        public GetShareholderCRsByIdentityNumber_Result[] GetShareholderCRsByIdentityNumberResult;
        
        public GetShareholderCRsByIdentityNumberResponse()
        {
        }
        
        public GetShareholderCRsByIdentityNumberResponse(GetShareholderCRsByIdentityNumber_Result[] GetShareholderCRsByIdentityNumberResult)
        {
            this.GetShareholderCRsByIdentityNumberResult = GetShareholderCRsByIdentityNumberResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIMCIGateWayServiceChannel : IIMCIGateWayService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MCIGateWayServiceClient : System.ServiceModel.ClientBase<IIMCIGateWayService>, IIMCIGateWayService
    {
        
        public MCIGateWayServiceClient()
        {
        }
        
        public MCIGateWayServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public MCIGateWayServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public MCIGateWayServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public MCIGateWayServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SendEmailResponse IIMCIGateWayService.SendEmail(SendEmailRequest request)
        {
            return base.Channel.SendEmail(request);
        }
        
        public ReturnResults SendEmail(string ApiKey, string[] To, string[] Cc, string[] Bcc, string TemplateCode, string Subject, string[] BodyParameters)
        {
            SendEmailRequest inValue = new SendEmailRequest();
            inValue.ApiKey = ApiKey;
            inValue.To = To;
            inValue.Cc = Cc;
            inValue.Bcc = Bcc;
            inValue.TemplateCode = TemplateCode;
            inValue.Subject = Subject;
            inValue.BodyParameters = BodyParameters;
            SendEmailResponse retVal = ((IIMCIGateWayService)(this)).SendEmail(inValue);
            return retVal.SendEmailResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SendEmailKeyValResponse IIMCIGateWayService.SendEmailKeyVal(SendEmailKeyValRequest request)
        {
            return base.Channel.SendEmailKeyVal(request);
        }
        
        public ReturnResults SendEmailKeyVal(string ApiKey, string[] To, string[] Cc, string[] Bcc, string TemplateCode, string Subject, EmailParam[] BodyParametersKeyValue)
        {
            SendEmailKeyValRequest inValue = new SendEmailKeyValRequest();
            inValue.ApiKey = ApiKey;
            inValue.To = To;
            inValue.Cc = Cc;
            inValue.Bcc = Bcc;
            inValue.TemplateCode = TemplateCode;
            inValue.Subject = Subject;
            inValue.BodyParametersKeyValue = BodyParametersKeyValue;
            SendEmailKeyValResponse retVal = ((IIMCIGateWayService)(this)).SendEmailKeyVal(inValue);
            return retVal.SendEmailKeyValResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SendSMSResponse IIMCIGateWayService.SendSMS(SendSMSRequest request)
        {
            return base.Channel.SendSMS(request);
        }
        
        public ReturnResults SendSMS(string ApiKey, string Mobile, string TemplateCode, string[] BodyParameters)
        {
            SendSMSRequest inValue = new SendSMSRequest();
            inValue.ApiKey = ApiKey;
            inValue.Mobile = Mobile;
            inValue.TemplateCode = TemplateCode;
            inValue.BodyParameters = BodyParameters;
            SendSMSResponse retVal = ((IIMCIGateWayService)(this)).SendSMS(inValue);
            return retVal.SendSMSResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetCRInfoResponse IIMCIGateWayService.GetCRInfo(GetCRInfoRequest request)
        {
            return base.Channel.GetCRInfo(request);
        }
        
        public CR GetCRInfo(string Apikey, string CR)
        {
            GetCRInfoRequest inValue = new GetCRInfoRequest();
            inValue.Apikey = Apikey;
            inValue.CR = CR;
            GetCRInfoResponse retVal = ((IIMCIGateWayService)(this)).GetCRInfo(inValue);
            return retVal.GetCRInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetPersonInfoResponse IIMCIGateWayService.GetPersonInfo(GetPersonInfoRequest request)
        {
            return base.Channel.GetPersonInfo(request);
        }
        
        public YaqeenInfo GetPersonInfo(string Apikey, double NationalId, string date, int uType)
        {
            GetPersonInfoRequest inValue = new GetPersonInfoRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            inValue.date = date;
            inValue.uType = uType;
            GetPersonInfoResponse retVal = ((IIMCIGateWayService)(this)).GetPersonInfo(inValue);
            return retVal.GetPersonInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MakeOTPRequestResponse IIMCIGateWayService.MakeOTPRequest(MakeOTPRequestRequest request)
        {
            return base.Channel.MakeOTPRequest(request);
        }
        
        public long MakeOTPRequest(string Apikey, string Username, bool isAbsherOTP)
        {
            MakeOTPRequestRequest inValue = new MakeOTPRequestRequest();
            inValue.Apikey = Apikey;
            inValue.Username = Username;
            inValue.isAbsherOTP = isAbsherOTP;
            MakeOTPRequestResponse retVal = ((IIMCIGateWayService)(this)).MakeOTPRequest(inValue);
            return retVal.MakeOTPRequestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MakeOTPRequestByNIDResponse IIMCIGateWayService.MakeOTPRequestByNID(MakeOTPRequestByNIDRequest request)
        {
            return base.Channel.MakeOTPRequestByNID(request);
        }
        
        public long MakeOTPRequestByNID(string Apikey, string NationalId)
        {
            MakeOTPRequestByNIDRequest inValue = new MakeOTPRequestByNIDRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            MakeOTPRequestByNIDResponse retVal = ((IIMCIGateWayService)(this)).MakeOTPRequestByNID(inValue);
            return retVal.MakeOTPRequestByNIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CheckOTPIsValidResponse IIMCIGateWayService.CheckOTPIsValid(CheckOTPIsValidRequest request)
        {
            return base.Channel.CheckOTPIsValid(request);
        }
        
        public bool CheckOTPIsValid(string Apikey, long RequestId, int OTP)
        {
            CheckOTPIsValidRequest inValue = new CheckOTPIsValidRequest();
            inValue.Apikey = Apikey;
            inValue.RequestId = RequestId;
            inValue.OTP = OTP;
            CheckOTPIsValidResponse retVal = ((IIMCIGateWayService)(this)).CheckOTPIsValid(inValue);
            return retVal.CheckOTPIsValidResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetEFileContactOfficerResponse IIMCIGateWayService.GetEFileContactOfficer(GetEFileContactOfficerRequest request)
        {
            return base.Channel.GetEFileContactOfficer(request);
        }
        
        public ContactOfficerModel GetEFileContactOfficer(string key, string token, string clientid, string clientPassword, bool IsDev)
        {
            GetEFileContactOfficerRequest inValue = new GetEFileContactOfficerRequest();
            inValue.key = key;
            inValue.token = token;
            inValue.clientid = clientid;
            inValue.clientPassword = clientPassword;
            inValue.IsDev = IsDev;
            GetEFileContactOfficerResponse retVal = ((IIMCIGateWayService)(this)).GetEFileContactOfficer(inValue);
            return retVal.GetEFileContactOfficerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AuthenticateByADResponse IIMCIGateWayService.AuthenticateByAD(AuthenticateByADRequest request)
        {
            return base.Channel.AuthenticateByAD(request);
        }
        
        public bool AuthenticateByAD(string key, string UserName, string Password)
        {
            AuthenticateByADRequest inValue = new AuthenticateByADRequest();
            inValue.key = key;
            inValue.UserName = UserName;
            inValue.Password = Password;
            AuthenticateByADResponse retVal = ((IIMCIGateWayService)(this)).AuthenticateByAD(inValue);
            return retVal.AuthenticateByADResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetADUserResponse IIMCIGateWayService.GetADUser(GetADUserRequest request)
        {
            return base.Channel.GetADUser(request);
        }
        
        public ADUser GetADUser(string key, string UserName)
        {
            GetADUserRequest inValue = new GetADUserRequest();
            inValue.key = key;
            inValue.UserName = UserName;
            GetADUserResponse retVal = ((IIMCIGateWayService)(this)).GetADUser(inValue);
            return retVal.GetADUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetEmployeeDataResponse IIMCIGateWayService.GetEmployeeData(GetEmployeeDataRequest request)
        {
            return base.Channel.GetEmployeeData(request);
        }
        
        public EmployeeFullData GetEmployeeData(string key, string Email, string NID, string UserName, System.Nullable<int> EmpId)
        {
            GetEmployeeDataRequest inValue = new GetEmployeeDataRequest();
            inValue.key = key;
            inValue.Email = Email;
            inValue.NID = NID;
            inValue.UserName = UserName;
            inValue.EmpId = EmpId;
            GetEmployeeDataResponse retVal = ((IIMCIGateWayService)(this)).GetEmployeeData(inValue);
            return retVal.GetEmployeeDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FNSaveDocResponse IIMCIGateWayService.FNSaveDoc(FNSaveDocRequest request)
        {
            return base.Channel.FNSaveDoc(request);
        }
        
        public string FNSaveDoc(string key, string FNUserName, string FNPassword, string FNUrl, string FNOS, string FNClassName, FNAttribute[] data, string FileName, byte[] fileData)
        {
            FNSaveDocRequest inValue = new FNSaveDocRequest();
            inValue.key = key;
            inValue.FNUserName = FNUserName;
            inValue.FNPassword = FNPassword;
            inValue.FNUrl = FNUrl;
            inValue.FNOS = FNOS;
            inValue.FNClassName = FNClassName;
            inValue.data = data;
            inValue.FileName = FileName;
            inValue.fileData = fileData;
            FNSaveDocResponse retVal = ((IIMCIGateWayService)(this)).FNSaveDoc(inValue);
            return retVal.FNSaveDocResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FNDeleteDocResponse IIMCIGateWayService.FNDeleteDoc(FNDeleteDocRequest request)
        {
            return base.Channel.FNDeleteDoc(request);
        }
        
        public bool FNDeleteDoc(string key, string FNUserName, string FNPassword, string FNUrl, string FNOS, string DocId)
        {
            FNDeleteDocRequest inValue = new FNDeleteDocRequest();
            inValue.key = key;
            inValue.FNUserName = FNUserName;
            inValue.FNPassword = FNPassword;
            inValue.FNUrl = FNUrl;
            inValue.FNOS = FNOS;
            inValue.DocId = DocId;
            FNDeleteDocResponse retVal = ((IIMCIGateWayService)(this)).FNDeleteDoc(inValue);
            return retVal.FNDeleteDocResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FNGetDocResponse IIMCIGateWayService.FNGetDoc(FNGetDocRequest request)
        {
            return base.Channel.FNGetDoc(request);
        }
        
        public byte[] FNGetDoc(string key, string FNUserName, string FNPassword, string FNUrl, string FNOS, string FNClassName, string DocId)
        {
            FNGetDocRequest inValue = new FNGetDocRequest();
            inValue.key = key;
            inValue.FNUserName = FNUserName;
            inValue.FNPassword = FNPassword;
            inValue.FNUrl = FNUrl;
            inValue.FNOS = FNOS;
            inValue.FNClassName = FNClassName;
            inValue.DocId = DocId;
            FNGetDocResponse retVal = ((IIMCIGateWayService)(this)).FNGetDoc(inValue);
            return retVal.FNGetDocResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FNGetDocInfoResponse IIMCIGateWayService.FNGetDocInfo(FNGetDocInfoRequest request)
        {
            return base.Channel.FNGetDocInfo(request);
        }
        
        public FNInfo FNGetDocInfo(string key, string FNClassName, string DocId)
        {
            FNGetDocInfoRequest inValue = new FNGetDocInfoRequest();
            inValue.key = key;
            inValue.FNClassName = FNClassName;
            inValue.DocId = DocId;
            FNGetDocInfoResponse retVal = ((IIMCIGateWayService)(this)).FNGetDocInfo(inValue);
            return retVal.FNGetDocInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FNSaveDocInfoResponse IIMCIGateWayService.FNSaveDocInfo(FNSaveDocInfoRequest request)
        {
            return base.Channel.FNSaveDocInfo(request);
        }
        
        public string FNSaveDocInfo(string key, string FNClassName, FNAttribute[] data, string FileName, byte[] fileData)
        {
            FNSaveDocInfoRequest inValue = new FNSaveDocInfoRequest();
            inValue.key = key;
            inValue.FNClassName = FNClassName;
            inValue.data = data;
            inValue.FileName = FileName;
            inValue.fileData = fileData;
            FNSaveDocInfoResponse retVal = ((IIMCIGateWayService)(this)).FNSaveDocInfo(inValue);
            return retVal.FNSaveDocInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FNDeleteDocInfoResponse IIMCIGateWayService.FNDeleteDocInfo(FNDeleteDocInfoRequest request)
        {
            return base.Channel.FNDeleteDocInfo(request);
        }
        
        public bool FNDeleteDocInfo(string key, string DocId)
        {
            FNDeleteDocInfoRequest inValue = new FNDeleteDocInfoRequest();
            inValue.key = key;
            inValue.DocId = DocId;
            FNDeleteDocInfoResponse retVal = ((IIMCIGateWayService)(this)).FNDeleteDocInfo(inValue);
            return retVal.FNDeleteDocInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ShearchInADResponse IIMCIGateWayService.ShearchInAD(ShearchInADRequest request)
        {
            return base.Channel.ShearchInAD(request);
        }
        
        public ADUser[] ShearchInAD(string key, string textShearch)
        {
            ShearchInADRequest inValue = new ShearchInADRequest();
            inValue.key = key;
            inValue.textShearch = textShearch;
            ShearchInADResponse retVal = ((IIMCIGateWayService)(this)).ShearchInAD(inValue);
            return retVal.ShearchInADResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EfileLogoutResponse IIMCIGateWayService.EfileLogout(EfileLogoutRequest request)
        {
            return base.Channel.EfileLogout(request);
        }
        
        public void EfileLogout(string key, string token, bool IsDev)
        {
            EfileLogoutRequest inValue = new EfileLogoutRequest();
            inValue.key = key;
            inValue.token = token;
            inValue.IsDev = IsDev;
            EfileLogoutResponse retVal = ((IIMCIGateWayService)(this)).EfileLogout(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EfileLoginResponse IIMCIGateWayService.EfileLogin(EfileLoginRequest request)
        {
            return base.Channel.EfileLogin(request);
        }
        
        public string EfileLogin(string key, string clientId, string secret, string NID, string password, bool isDev)
        {
            EfileLoginRequest inValue = new EfileLoginRequest();
            inValue.key = key;
            inValue.clientId = clientId;
            inValue.secret = secret;
            inValue.NID = NID;
            inValue.password = password;
            inValue.isDev = isDev;
            EfileLoginResponse retVal = ((IIMCIGateWayService)(this)).EfileLogin(inValue);
            return retVal.EfileLoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetEFileUserDataByNIDResponse IIMCIGateWayService.GetEFileUserDataByNID(GetEFileUserDataByNIDRequest request)
        {
            return base.Channel.GetEFileUserDataByNID(request);
        }
        
        public ContactOfficerModel GetEFileUserDataByNID(string key, string NID, string clientid, string secret, bool IsDev)
        {
            GetEFileUserDataByNIDRequest inValue = new GetEFileUserDataByNIDRequest();
            inValue.key = key;
            inValue.NID = NID;
            inValue.clientid = clientid;
            inValue.secret = secret;
            inValue.IsDev = IsDev;
            GetEFileUserDataByNIDResponse retVal = ((IIMCIGateWayService)(this)).GetEFileUserDataByNID(inValue);
            return retVal.GetEFileUserDataByNIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAllCRForNationalIdResponse IIMCIGateWayService.GetAllCRForNationalId(GetAllCRForNationalIdRequest request)
        {
            return base.Channel.GetAllCRForNationalId(request);
        }
        
        public CRForPerson[] GetAllCRForNationalId(string key, string NationalId)
        {
            GetAllCRForNationalIdRequest inValue = new GetAllCRForNationalIdRequest();
            inValue.key = key;
            inValue.NationalId = NationalId;
            GetAllCRForNationalIdResponse retVal = ((IIMCIGateWayService)(this)).GetAllCRForNationalId(inValue);
            return retVal.GetAllCRForNationalIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAllPersonsForCRResponse IIMCIGateWayService.GetAllPersonsForCR(GetAllPersonsForCRRequest request)
        {
            return base.Channel.GetAllPersonsForCR(request);
        }
        
        public CRPerson[] GetAllPersonsForCR(string key, string CR)
        {
            GetAllPersonsForCRRequest inValue = new GetAllPersonsForCRRequest();
            inValue.key = key;
            inValue.CR = CR;
            GetAllPersonsForCRResponse retVal = ((IIMCIGateWayService)(this)).GetAllPersonsForCR(inValue);
            return retVal.GetAllPersonsForCRResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetFakeAllPersonsForCRResponse IIMCIGateWayService.GetFakeAllPersonsForCR(GetFakeAllPersonsForCRRequest request)
        {
            return base.Channel.GetFakeAllPersonsForCR(request);
        }
        
        public CRPerson[] GetFakeAllPersonsForCR(string key, string CR)
        {
            GetFakeAllPersonsForCRRequest inValue = new GetFakeAllPersonsForCRRequest();
            inValue.key = key;
            inValue.CR = CR;
            GetFakeAllPersonsForCRResponse retVal = ((IIMCIGateWayService)(this)).GetFakeAllPersonsForCR(inValue);
            return retVal.GetFakeAllPersonsForCRResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GenerateSadadBillResponse IIMCIGateWayService.GenerateSadadBill(GenerateSadadBillRequest request)
        {
            return base.Channel.GenerateSadadBill(request);
        }
        
        public GenerateBillSadadResponse GenerateSadadBill(string key, GenerateBillSadadRequest model)
        {
            GenerateSadadBillRequest inValue = new GenerateSadadBillRequest();
            inValue.key = key;
            inValue.model = model;
            GenerateSadadBillResponse retVal = ((IIMCIGateWayService)(this)).GenerateSadadBill(inValue);
            return retVal.GenerateSadadBillResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetBillDetailResponse1 IIMCIGateWayService.GetBillDetail(GetBillDetailRequest1 request)
        {
            return base.Channel.GetBillDetail(request);
        }
        
        public GetBillDetailResponse GetBillDetail(string key, GetBillDetailRequest model)
        {
            GetBillDetailRequest1 inValue = new GetBillDetailRequest1();
            inValue.key = key;
            inValue.model = model;
            GetBillDetailResponse1 retVal = ((IIMCIGateWayService)(this)).GetBillDetail(inValue);
            return retVal.GetBillDetailResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CancelBillResponse IIMCIGateWayService.CancelBill(CancelBillRequest1 request)
        {
            return base.Channel.CancelBill(request);
        }
        
        public ChangeBillResponse CancelBill(string key, CancelBillRequest model)
        {
            CancelBillRequest1 inValue = new CancelBillRequest1();
            inValue.key = key;
            inValue.model = model;
            CancelBillResponse retVal = ((IIMCIGateWayService)(this)).CancelBill(inValue);
            return retVal.CancelBillResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetCRBranchesResponse IIMCIGateWayService.GetCRBranches(GetCRBranchesRequest request)
        {
            return base.Channel.GetCRBranches(request);
        }
        
        public CR[] GetCRBranches(string Apikey, string CR)
        {
            GetCRBranchesRequest inValue = new GetCRBranchesRequest();
            inValue.Apikey = Apikey;
            inValue.CR = CR;
            GetCRBranchesResponse retVal = ((IIMCIGateWayService)(this)).GetCRBranches(inValue);
            return retVal.GetCRBranchesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetDelegatedReferencesResponse IIMCIGateWayService.GetDelegatedReferences(GetDelegatedReferencesRequest request)
        {
            return base.Channel.GetDelegatedReferences(request);
        }
        
        public EFileServiceDelegated[] GetDelegatedReferences(string Apikey, string NID, string clientid, string secret, string delegatorNid, string CRNumber, bool IsDev)
        {
            GetDelegatedReferencesRequest inValue = new GetDelegatedReferencesRequest();
            inValue.Apikey = Apikey;
            inValue.NID = NID;
            inValue.clientid = clientid;
            inValue.secret = secret;
            inValue.delegatorNid = delegatorNid;
            inValue.CRNumber = CRNumber;
            inValue.IsDev = IsDev;
            GetDelegatedReferencesResponse retVal = ((IIMCIGateWayService)(this)).GetDelegatedReferences(inValue);
            return retVal.GetDelegatedReferencesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetMultiCRsInfoResponse IIMCIGateWayService.GetMultiCRsInfo(GetMultiCRsInfoRequest request)
        {
            return base.Channel.GetMultiCRsInfo(request);
        }
        
        public CR[] GetMultiCRsInfo(string Apikey, string[] CRs)
        {
            GetMultiCRsInfoRequest inValue = new GetMultiCRsInfoRequest();
            inValue.Apikey = Apikey;
            inValue.CRs = CRs;
            GetMultiCRsInfoResponse retVal = ((IIMCIGateWayService)(this)).GetMultiCRsInfo(inValue);
            return retVal.GetMultiCRsInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GenrateMCISadadBillResponse IIMCIGateWayService.GenrateMCISadadBill(GenrateMCISadadBillRequest request)
        {
            return base.Channel.GenrateMCISadadBill(request);
        }
        
        public long GenrateMCISadadBill(string Apikey, MCISadadModel model)
        {
            GenrateMCISadadBillRequest inValue = new GenrateMCISadadBillRequest();
            inValue.Apikey = Apikey;
            inValue.model = model;
            GenrateMCISadadBillResponse retVal = ((IIMCIGateWayService)(this)).GenrateMCISadadBill(inValue);
            return retVal.GenrateMCISadadBillResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetMCISadadBillStatusResponse IIMCIGateWayService.GetMCISadadBillStatus(GetMCISadadBillStatusRequest request)
        {
            return base.Channel.GetMCISadadBillStatus(request);
        }
        
        public string GetMCISadadBillStatus(string Apikey, string BillingNumber)
        {
            GetMCISadadBillStatusRequest inValue = new GetMCISadadBillStatusRequest();
            inValue.Apikey = Apikey;
            inValue.BillingNumber = BillingNumber;
            GetMCISadadBillStatusResponse retVal = ((IIMCIGateWayService)(this)).GetMCISadadBillStatus(inValue);
            return retVal.GetMCISadadBillStatusResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAllTMForNationalIdResponse IIMCIGateWayService.GetAllTMForNationalId(GetAllTMForNationalIdRequest request)
        {
            return base.Channel.GetAllTMForNationalId(request);
        }
        
        public TradeMarkInfo[] GetAllTMForNationalId(string Apikey, string NationalId)
        {
            GetAllTMForNationalIdRequest inValue = new GetAllTMForNationalIdRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetAllTMForNationalIdResponse retVal = ((IIMCIGateWayService)(this)).GetAllTMForNationalId(inValue);
            return retVal.GetAllTMForNationalIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAllProfessionsForNationalIdResponse IIMCIGateWayService.GetAllProfessionsForNationalId(GetAllProfessionsForNationalIdRequest request)
        {
            return base.Channel.GetAllProfessionsForNationalId(request);
        }
        
        public ProfessionInfo[] GetAllProfessionsForNationalId(string Apikey, string NationalId)
        {
            GetAllProfessionsForNationalIdRequest inValue = new GetAllProfessionsForNationalIdRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetAllProfessionsForNationalIdResponse retVal = ((IIMCIGateWayService)(this)).GetAllProfessionsForNationalId(inValue);
            return retVal.GetAllProfessionsForNationalIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetPersonForCRWithCOCResponse IIMCIGateWayService.GetPersonForCRWithCOC(GetPersonForCRWithCOCRequest request)
        {
            return base.Channel.GetPersonForCRWithCOC(request);
        }
        
        public PersonForCRWithCOC GetPersonForCRWithCOC(string Apikey, string CRNumber, string NationalId, string BirthDate)
        {
            GetPersonForCRWithCOCRequest inValue = new GetPersonForCRWithCOCRequest();
            inValue.Apikey = Apikey;
            inValue.CRNumber = CRNumber;
            inValue.NationalId = NationalId;
            inValue.BirthDate = BirthDate;
            GetPersonForCRWithCOCResponse retVal = ((IIMCIGateWayService)(this)).GetPersonForCRWithCOC(inValue);
            return retVal.GetPersonForCRWithCOCResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetMonshaatRequestResponse IIMCIGateWayService.GetMonshaatRequest(GetMonshaatRequestRequest request)
        {
            return base.Channel.GetMonshaatRequest(request);
        }
        
        public GetMonshaatRequestResult[] GetMonshaatRequest(string Apikey, string CRNo, bool IsConsolidated)
        {
            GetMonshaatRequestRequest inValue = new GetMonshaatRequestRequest();
            inValue.Apikey = Apikey;
            inValue.CRNo = CRNo;
            inValue.IsConsolidated = IsConsolidated;
            GetMonshaatRequestResponse retVal = ((IIMCIGateWayService)(this)).GetMonshaatRequest(inValue);
            return retVal.GetMonshaatRequestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetOwnerMobileByCRNumberResponse IIMCIGateWayService.GetOwnerMobileByCRNumber(GetOwnerMobileByCRNumberRequest request)
        {
            return base.Channel.GetOwnerMobileByCRNumber(request);
        }
        
        public CROwnerInfo GetOwnerMobileByCRNumber(string Apikey, string CRNumber)
        {
            GetOwnerMobileByCRNumberRequest inValue = new GetOwnerMobileByCRNumberRequest();
            inValue.Apikey = Apikey;
            inValue.CRNumber = CRNumber;
            GetOwnerMobileByCRNumberResponse retVal = ((IIMCIGateWayService)(this)).GetOwnerMobileByCRNumber(inValue);
            return retVal.GetOwnerMobileByCRNumberResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAllTicketsForCRNumberResponse IIMCIGateWayService.GetAllTicketsForCRNumber(GetAllTicketsForCRNumberRequest request)
        {
            return base.Channel.GetAllTicketsForCRNumber(request);
        }
        
        public TicketInfo[] GetAllTicketsForCRNumber(string Apikey, string CRNumber)
        {
            GetAllTicketsForCRNumberRequest inValue = new GetAllTicketsForCRNumberRequest();
            inValue.Apikey = Apikey;
            inValue.CRNumber = CRNumber;
            GetAllTicketsForCRNumberResponse retVal = ((IIMCIGateWayService)(this)).GetAllTicketsForCRNumber(inValue);
            return retVal.GetAllTicketsForCRNumberResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAllRelatedCrsForCRNumberResponse IIMCIGateWayService.GetAllRelatedCrsForCRNumber(GetAllRelatedCrsForCRNumberRequest request)
        {
            return base.Channel.GetAllRelatedCrsForCRNumber(request);
        }
        
        public CR[] GetAllRelatedCrsForCRNumber(string Apikey, string CR)
        {
            GetAllRelatedCrsForCRNumberRequest inValue = new GetAllRelatedCrsForCRNumberRequest();
            inValue.Apikey = Apikey;
            inValue.CR = CR;
            GetAllRelatedCrsForCRNumberResponse retVal = ((IIMCIGateWayService)(this)).GetAllRelatedCrsForCRNumber(inValue);
            return retVal.GetAllRelatedCrsForCRNumberResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAllTicketsForNationalIdResponse IIMCIGateWayService.GetAllTicketsForNationalId(GetAllTicketsForNationalIdRequest request)
        {
            return base.Channel.GetAllTicketsForNationalId(request);
        }
        
        public TicketInfo[] GetAllTicketsForNationalId(string Apikey, string NationalId)
        {
            GetAllTicketsForNationalIdRequest inValue = new GetAllTicketsForNationalIdRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetAllTicketsForNationalIdResponse retVal = ((IIMCIGateWayService)(this)).GetAllTicketsForNationalId(inValue);
            return retVal.GetAllTicketsForNationalIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAllGPMLicensesForNationalIdResponse IIMCIGateWayService.GetAllGPMLicensesForNationalId(GetAllGPMLicensesForNationalIdRequest request)
        {
            return base.Channel.GetAllGPMLicensesForNationalId(request);
        }
        
        public GPMLicensesInfo[] GetAllGPMLicensesForNationalId(string Apikey, string NationalId)
        {
            GetAllGPMLicensesForNationalIdRequest inValue = new GetAllGPMLicensesForNationalIdRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetAllGPMLicensesForNationalIdResponse retVal = ((IIMCIGateWayService)(this)).GetAllGPMLicensesForNationalId(inValue);
            return retVal.GetAllGPMLicensesForNationalIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAllLabLicensesForNationalIdResponse IIMCIGateWayService.GetAllLabLicensesForNationalId(GetAllLabLicensesForNationalIdRequest request)
        {
            return base.Channel.GetAllLabLicensesForNationalId(request);
        }
        
        public LabLicensesInfo[] GetAllLabLicensesForNationalId(string Apikey, string NationalId)
        {
            GetAllLabLicensesForNationalIdRequest inValue = new GetAllLabLicensesForNationalIdRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetAllLabLicensesForNationalIdResponse retVal = ((IIMCIGateWayService)(this)).GetAllLabLicensesForNationalId(inValue);
            return retVal.GetAllLabLicensesForNationalIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetAllCRForNationalIdWithoutDuplicationResponse IIMCIGateWayService.GetAllCRForNationalIdWithoutDuplication(GetAllCRForNationalIdWithoutDuplicationRequest request)
        {
            return base.Channel.GetAllCRForNationalIdWithoutDuplication(request);
        }
        
        public CRForPerson[] GetAllCRForNationalIdWithoutDuplication(string key, string NationalId)
        {
            GetAllCRForNationalIdWithoutDuplicationRequest inValue = new GetAllCRForNationalIdWithoutDuplicationRequest();
            inValue.key = key;
            inValue.NationalId = NationalId;
            GetAllCRForNationalIdWithoutDuplicationResponse retVal = ((IIMCIGateWayService)(this)).GetAllCRForNationalIdWithoutDuplication(inValue);
            return retVal.GetAllCRForNationalIdWithoutDuplicationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetCRCountWithStatusForNationalIdResponse IIMCIGateWayService.GetCRCountWithStatusForNationalId(GetCRCountWithStatusForNationalIdRequest request)
        {
            return base.Channel.GetCRCountWithStatusForNationalId(request);
        }
        
        public ServicesCountsModel[] GetCRCountWithStatusForNationalId(string Apikey, string NationalId)
        {
            GetCRCountWithStatusForNationalIdRequest inValue = new GetCRCountWithStatusForNationalIdRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetCRCountWithStatusForNationalIdResponse retVal = ((IIMCIGateWayService)(this)).GetCRCountWithStatusForNationalId(inValue);
            return retVal.GetCRCountWithStatusForNationalIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetLicenseCountWithStatusForNationalIdResponse IIMCIGateWayService.GetLicenseCountWithStatusForNationalId(GetLicenseCountWithStatusForNationalIdRequest request)
        {
            return base.Channel.GetLicenseCountWithStatusForNationalId(request);
        }
        
        public ServicesCountsModel[] GetLicenseCountWithStatusForNationalId(string Apikey, string NationalId)
        {
            GetLicenseCountWithStatusForNationalIdRequest inValue = new GetLicenseCountWithStatusForNationalIdRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetLicenseCountWithStatusForNationalIdResponse retVal = ((IIMCIGateWayService)(this)).GetLicenseCountWithStatusForNationalId(inValue);
            return retVal.GetLicenseCountWithStatusForNationalIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetTrademarkCountWithStatusForNationalIdResponse IIMCIGateWayService.GetTrademarkCountWithStatusForNationalId(GetTrademarkCountWithStatusForNationalIdRequest request)
        {
            return base.Channel.GetTrademarkCountWithStatusForNationalId(request);
        }
        
        public ServicesCountsModel[] GetTrademarkCountWithStatusForNationalId(string Apikey, string NationalId)
        {
            GetTrademarkCountWithStatusForNationalIdRequest inValue = new GetTrademarkCountWithStatusForNationalIdRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetTrademarkCountWithStatusForNationalIdResponse retVal = ((IIMCIGateWayService)(this)).GetTrademarkCountWithStatusForNationalId(inValue);
            return retVal.GetTrademarkCountWithStatusForNationalIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetViolationCountWithStatusForNationalIdResponse IIMCIGateWayService.GetViolationCountWithStatusForNationalId(GetViolationCountWithStatusForNationalIdRequest request)
        {
            return base.Channel.GetViolationCountWithStatusForNationalId(request);
        }
        
        public ServicesCountsModel[] GetViolationCountWithStatusForNationalId(string Apikey, string NationalId)
        {
            GetViolationCountWithStatusForNationalIdRequest inValue = new GetViolationCountWithStatusForNationalIdRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetViolationCountWithStatusForNationalIdResponse retVal = ((IIMCIGateWayService)(this)).GetViolationCountWithStatusForNationalId(inValue);
            return retVal.GetViolationCountWithStatusForNationalIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetCRQRImageResponse IIMCIGateWayService.GetCRQRImage(GetCRQRImageRequest request)
        {
            return base.Channel.GetCRQRImage(request);
        }
        
        public CRQRResult GetCRQRImage(string Apikey, string CR)
        {
            GetCRQRImageRequest inValue = new GetCRQRImageRequest();
            inValue.Apikey = Apikey;
            inValue.CR = CR;
            GetCRQRImageResponse retVal = ((IIMCIGateWayService)(this)).GetCRQRImage(inValue);
            return retVal.GetCRQRImageResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetCRCertificateResponse IIMCIGateWayService.GetCRCertificate(GetCRCertificateRequest request)
        {
            return base.Channel.GetCRCertificate(request);
        }
        
        public CRCertificateResult GetCRCertificate(string Apikey, string CR)
        {
            GetCRCertificateRequest inValue = new GetCRCertificateRequest();
            inValue.Apikey = Apikey;
            inValue.CR = CR;
            GetCRCertificateResponse retVal = ((IIMCIGateWayService)(this)).GetCRCertificate(inValue);
            return retVal.GetCRCertificateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SendNewEfadaRequestResponse IIMCIGateWayService.SendNewEfadaRequest(SendNewEfadaRequestRequest request)
        {
            return base.Channel.SendNewEfadaRequest(request);
        }
        
        public EfadaResponse SendNewEfadaRequest(string Apikey, string CR, bool IsCRMain, string NationalId)
        {
            SendNewEfadaRequestRequest inValue = new SendNewEfadaRequestRequest();
            inValue.Apikey = Apikey;
            inValue.CR = CR;
            inValue.IsCRMain = IsCRMain;
            inValue.NationalId = NationalId;
            SendNewEfadaRequestResponse retVal = ((IIMCIGateWayService)(this)).SendNewEfadaRequest(inValue);
            return retVal.SendNewEfadaRequestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetEfadaRequestsResponse IIMCIGateWayService.GetEfadaRequests(GetEfadaRequestsRequest request)
        {
            return base.Channel.GetEfadaRequests(request);
        }
        
        public EfadaRequests GetEfadaRequests(string Apikey, string NationalId)
        {
            GetEfadaRequestsRequest inValue = new GetEfadaRequestsRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetEfadaRequestsResponse retVal = ((IIMCIGateWayService)(this)).GetEfadaRequests(inValue);
            return retVal.GetEfadaRequestsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetCRQRUrlResponse IIMCIGateWayService.GetCRQRUrl(GetCRQRUrlRequest request)
        {
            return base.Channel.GetCRQRUrl(request);
        }
        
        public CRQRUrlResult GetCRQRUrl(string Apikey, string CR)
        {
            GetCRQRUrlRequest inValue = new GetCRQRUrlRequest();
            inValue.Apikey = Apikey;
            inValue.CR = CR;
            GetCRQRUrlResponse retVal = ((IIMCIGateWayService)(this)).GetCRQRUrl(inValue);
            return retVal.GetCRQRUrlResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ValidateShareholdersRecordUpdateResponse IIMCIGateWayService.ValidateShareholdersRecordUpdate(ValidateShareholdersRecordUpdateRequest request)
        {
            return base.Channel.ValidateShareholdersRecordUpdate(request);
        }
        
        public int ValidateShareholdersRecordUpdate(string Apikey, string CR)
        {
            ValidateShareholdersRecordUpdateRequest inValue = new ValidateShareholdersRecordUpdateRequest();
            inValue.Apikey = Apikey;
            inValue.CR = CR;
            ValidateShareholdersRecordUpdateResponse retVal = ((IIMCIGateWayService)(this)).ValidateShareholdersRecordUpdate(inValue);
            return retVal.ValidateShareholdersRecordUpdateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetShareholdersListByCRNumberResponse IIMCIGateWayService.GetShareholdersListByCRNumber(GetShareholdersListByCRNumberRequest request)
        {
            return base.Channel.GetShareholdersListByCRNumber(request);
        }
        
        public GetShareholdersListByCRNumber_Result[] GetShareholdersListByCRNumber(string Apikey, string CR)
        {
            GetShareholdersListByCRNumberRequest inValue = new GetShareholdersListByCRNumberRequest();
            inValue.Apikey = Apikey;
            inValue.CR = CR;
            GetShareholdersListByCRNumberResponse retVal = ((IIMCIGateWayService)(this)).GetShareholdersListByCRNumber(inValue);
            return retVal.GetShareholdersListByCRNumberResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetShareholderCRsByIdentityNumberResponse IIMCIGateWayService.GetShareholderCRsByIdentityNumber(GetShareholderCRsByIdentityNumberRequest request)
        {
            return base.Channel.GetShareholderCRsByIdentityNumber(request);
        }
        
        public GetShareholderCRsByIdentityNumber_Result[] GetShareholderCRsByIdentityNumber(string Apikey, string NationalId)
        {
            GetShareholderCRsByIdentityNumberRequest inValue = new GetShareholderCRsByIdentityNumberRequest();
            inValue.Apikey = Apikey;
            inValue.NationalId = NationalId;
            GetShareholderCRsByIdentityNumberResponse retVal = ((IIMCIGateWayService)(this)).GetShareholderCRsByIdentityNumber(inValue);
            return retVal.GetShareholderCRsByIdentityNumberResult;
        }
    }
}

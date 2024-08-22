using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace SerenePSM.Default.Columns;

[ColumnsScript("Default.Pfk7101")]
[BasedOnRow(typeof(Pfk7101Row), CheckNames = true)]
public class Pfk7101Columns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string DevelopmentCode { get; set; }
    public string CustomerNameSimply { get; set; }
    public string CustomerName { get; set; }
    public string Representative { get; set; }
    public string FaxNo { get; set; }
    public string AddressNo { get; set; }
    public string TelephoneCompany { get; set; }
    public string Email { get; set; }
    //public string CustomerCode { get; set; }
    //public byte[] QrCode { get; set; }
    //public string ACodeReceivable { get; set; }
    //public string ACodePayable { get; set; }
    
    //public string QrCodeName { get; set; }
    //public string QrCodeTel { get; set; }
    
    //public string CustomerName1 { get; set; }
    
    //public string CustomerNameSimply1 { get; set; }
    //public Guid FaceId { get; set; }
    //public string SePassWord { get; set; }
    //public string CdPassWord { get; set; }
    //public string SeDeliveryTerm { get; set; }
    //public string CdDeliveryTerm { get; set; }
    //public string SePaymentTerm { get; set; }
    //public string CdPaymentTerm { get; set; }
    //public string SePaymentCondition { get; set; }
    //public string CdPaymentCondition { get; set; }
    //public string SePaymentDay { get; set; }
    //public string CdPaymentDay { get; set; }
    //public string SePaymentTime { get; set; }
    //public string CdPaymentTime { get; set; }
    //public string SeSite { get; set; }
    //public string CdSite { get; set; }
    //public string SeTeam { get; set; }
    //public string CdTeam { get; set; }
    //public string ForeignName1 { get; set; }
    //public string ForeignName2 { get; set; }
    //public string CompanyId { get; set; }
    //public string CompanyType { get; set; }
    //public string CompanyItem { get; set; }
    
    
    //public string Address1 { get; set; }
    //public string Address2 { get; set; }
    //public string Destination { get; set; }
    //public string FinalShop { get; set; }
    //public string Country { get; set; }
    //public string InvoiceAccount { get; set; }
    //public string TaxExempt { get; set; }
    //public string SeSupplierGroup { get; set; }
    //public string CdSupplierGroup { get; set; }
    //public string SePoGroup { get; set; }
    //public string CdPoGroup { get; set; }
    //public string SeSoGroup { get; set; }
    //public string CdSoGroup { get; set; }
    
    //public string TelephoneHand { get; set; }
    
    
    //public string BeneficiaryName { get; set; }
    //public string AccountNumber { get; set; }
    //public string BankName { get; set; }
    //public string BankAddress { get; set; }
    //public string SwiftCode { get; set; }
    //public string CdFactory { get; set; }
    //public string CheckKindCustomer { get; set; }
    //public string SeCancelDate { get; set; }
    //public string CdCancelDate { get; set; }
    //public string SeCustomerDivision { get; set; }
    //public string CdCustomerDivision { get; set; }
    //public string SeCustomerLocation { get; set; }
    //public string CdCustomerLocation { get; set; }
    //public string SeTaxGroup { get; set; }
    //public string CdTaxGroup { get; set; }
    //public string InCharge { get; set; }
    //public string InChargeSale { get; set; }
    //public string CheckTax { get; set; }
    //public string CheckCustomer { get; set; }
    //public string CheckSupplier { get; set; }
    //public string CheckEmployee { get; set; }
    //public string CheckInside { get; set; }
    //public string CheckOutside { get; set; }
    //public string CheckOthers { get; set; }
    //public string CheckUse { get; set; }
    //public string InchargeInsert { get; set; }
    //public string InchargeUpdate { get; set; }
    //public string DateInsert { get; set; }
    //public string DateUpdate { get; set; }
    //public string TimeInsert { get; set; }
    //public string TimeUpdate { get; set; }
    //public string TimeLast { get; set; }
    //public string DateActive { get; set; }
    //public string DateDeactive { get; set; }
    //public string CheckActive { get; set; }
    //public decimal ParaNo1 { get; set; }
    //public decimal ParaNo2 { get; set; }
    //public decimal ParaNo3 { get; set; }
    //public string CheckSync { get; set; }
    //public string CheckCustomerStatus { get; set; }
    //public string DateComplete { get; set; }
    //public string DateApproved { get; set; }
    //public string DateCancel { get; set; }
    //public string DatePending1 { get; set; }
    //public string DatePending2 { get; set; }
    //public string Remark { get; set; }
    //public string CheckOption1 { get; set; }
    //public string CheckOption2 { get; set; }
    //public string CheckOption3 { get; set; }
    //public string CheckOption4 { get; set; }
    //public string CheckOption5 { get; set; }
    //public string CheckOption6 { get; set; }
    //public string CheckOption7 { get; set; }
    //public string CheckOption8 { get; set; }
    //public string CheckOption9 { get; set; }
    //public string CheckOption10 { get; set; }
    //public string Shipper { get; set; }
    //public string ShipperTo { get; set; }
    //public string Buyer { get; set; }
    //public string Consignee { get; set; }
    //public string LcNo { get; set; }
    //public string DateLc { get; set; }
    //public string Notifyparty { get; set; }
    //public string NotifypartyAnd { get; set; }
    //public string VisAllName { get; set; }
    //public string DateDepart { get; set; }
    //public string FlightNo { get; set; }
    //public string ShipFrom { get; set; }
    //public string ShipTo { get; set; }
    //public string ShipMark { get; set; }
    //public string Remarks { get; set; }
    //public string TermPri { get; set; }
    //public string Shipper1 { get; set; }
    //public string ShipperTo1 { get; set; }
    //public string Buyer1 { get; set; }
    //public string Consignee1 { get; set; }
    //public string LcNo1 { get; set; }
    //public string DateLc1 { get; set; }
    //public string Notifyparty1 { get; set; }
    //public string NotifypartyAnd1 { get; set; }
    //public string VisAllName1 { get; set; }
    //public string DateDepart1 { get; set; }
    //public string FlightNo1 { get; set; }
    //public string ShipFrom1 { get; set; }
    //public string ShipTo1 { get; set; }
    //public string ShipMark1 { get; set; }
    //public string Remarks1 { get; set; }
    //public string TermPri1 { get; set; }
}
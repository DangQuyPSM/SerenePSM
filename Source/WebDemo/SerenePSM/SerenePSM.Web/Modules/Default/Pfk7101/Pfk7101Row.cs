using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace SerenePSM.Default;

[ConnectionKey("Default"), Module("Default"), TableName("PFK7101")]
[DisplayName("Pfk7101"), InstanceName("Pfk7101")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class Pfk7101Row : Row<Pfk7101Row.RowFields>, IIdRow, INameRow
{
    [DisplayName("Mã khách hàng"), Column("K7101_DevelopmentCode"), Size(20), NotNull, IdProperty, QuickSearch, NameProperty]
    public string DevelopmentCode { get => fields.DevelopmentCode[this]; set => fields.DevelopmentCode[this] = value; }

    [DisplayName("Tên rút gọn"), Column("K7101_CustomerNameSimply"), Size(100), NotNull]
    public string CustomerNameSimply { get => fields.CustomerNameSimply[this]; set => fields.CustomerNameSimply[this] = value; }

    [DisplayName("Tên khách hàng"), Column("K7101_CustomerName"), Size(200), NotNull]
    public string CustomerName { get => fields.CustomerName[this]; set => fields.CustomerName[this] = value; }

    [DisplayName("Người liên hệ"), Column("K7101_Representative"), Size(50), NotNull]
    public string Representative { get => fields.Representative[this]; set => fields.Representative[this] = value; }

    [DisplayName("Mã số thuế"), Column("K7101_FaxNo"), Size(20), NotNull]
    public string FaxNo { get => fields.FaxNo[this]; set => fields.FaxNo[this] = value; }

    [DisplayName("Địa chỉ"), Column("K7101_AddressNo"), Size(100), NotNull]
    public string AddressNo { get => fields.AddressNo[this]; set => fields.AddressNo[this] = value; }

    [DisplayName("SĐT Công ty"), Column("K7101_TelephoneCompany"), Size(50), NotNull]
    public string TelephoneCompany { get => fields.TelephoneCompany[this]; set => fields.TelephoneCompany[this] = value; }

    [DisplayName("Email"), Column("K7101_Email"), Size(50), NotNull]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Customer Code"), Column("K7101_CustomerCode"), Size(6), PrimaryKey, NotNull, /*IdProperty, QuickSearch, NameProperty*/Hidden]
    public string CustomerCode { get => fields.CustomerCode[this]; set => fields.CustomerCode[this] = value; }

    [DisplayName("Qr Code"), Column("K7101_QRCode"), Hidden]
    public byte[] QrCode { get => fields.QrCode[this]; set => fields.QrCode[this] = value; }

    [DisplayName("A Code Receivable"), Column("K7101_ACodeReceivable"), Size(20), Hidden]
    public string ACodeReceivable { get => fields.ACodeReceivable[this]; set => fields.ACodeReceivable[this] = value; }

    [DisplayName("A Code Payable"), Column("K7101_ACodePayable"), Size(20), Hidden]
    public string ACodePayable { get => fields.ACodePayable[this]; set => fields.ACodePayable[this] = value; }

    

    [DisplayName("Qr Code Name"), Column("K7101_QRCodeName"), Size(200), NotNull, Hidden]
    public string QrCodeName { get => fields.QrCodeName[this]; set => fields.QrCodeName[this] = value; }

    [DisplayName("Qr Code Tel"), Column("K7101_QRCodeTel"), Size(200), NotNull, Hidden]
    public string QrCodeTel { get => fields.QrCodeTel[this]; set => fields.QrCodeTel[this] = value; }

    

    [DisplayName("Customer Name1"), Column("K7101_CustomerName1"), Size(200), Hidden]
    public string CustomerName1 { get => fields.CustomerName1[this]; set => fields.CustomerName1[this] = value; }

    

    [DisplayName("Customer Name Simply1"), Column("K7101_CustomerNameSimply1"), Size(100), Hidden]
    public string CustomerNameSimply1 { get => fields.CustomerNameSimply1[this]; set => fields.CustomerNameSimply1[this] = value; }

    [DisplayName("Face Id"), Column("K7101_FaceID"), Hidden]
    public Guid? FaceId { get => fields.FaceId[this]; set => fields.FaceId[this] = value; }

    [DisplayName("Se Pass Word"), Column("K7101_sePassWord"), Size(3), Hidden]
    public string SePassWord { get => fields.SePassWord[this]; set => fields.SePassWord[this] = value; }

    [DisplayName("Cd Pass Word"), Column("K7101_cdPassWord"), Size(3), Hidden]
    public string CdPassWord { get => fields.CdPassWord[this]; set => fields.CdPassWord[this] = value; }

    [DisplayName("Se Delivery Term"), Column("K7101_seDeliveryTerm"), Size(3), Hidden]
    public string SeDeliveryTerm { get => fields.SeDeliveryTerm[this]; set => fields.SeDeliveryTerm[this] = value; }

    [DisplayName("Cd Delivery Term"), Column("K7101_cdDeliveryTerm"), Size(3), Hidden]
    public string CdDeliveryTerm { get => fields.CdDeliveryTerm[this]; set => fields.CdDeliveryTerm[this] = value; }

    [DisplayName("Se Payment Term"), Column("K7101_sePaymentTerm"), Size(3), Hidden]
    public string SePaymentTerm { get => fields.SePaymentTerm[this]; set => fields.SePaymentTerm[this] = value; }

    [DisplayName("Cd Payment Term"), Column("K7101_cdPaymentTerm"), Size(3), Hidden]
    public string CdPaymentTerm { get => fields.CdPaymentTerm[this]; set => fields.CdPaymentTerm[this] = value; }

    [DisplayName("Se Payment Condition"), Column("K7101_sePaymentCondition"), Size(3), Hidden]
    public string SePaymentCondition { get => fields.SePaymentCondition[this]; set => fields.SePaymentCondition[this] = value; }

    [DisplayName("Cd Payment Condition"), Column("K7101_cdPaymentCondition"), Size(3), Hidden]
    public string CdPaymentCondition { get => fields.CdPaymentCondition[this]; set => fields.CdPaymentCondition[this] = value; }

    [DisplayName("Se Payment Day"), Column("K7101_sePaymentDay"), Size(3), Hidden]
    public string SePaymentDay { get => fields.SePaymentDay[this]; set => fields.SePaymentDay[this] = value; }

    [DisplayName("Cd Payment Day"), Column("K7101_cdPaymentDay"), Size(3), Hidden]
    public string CdPaymentDay { get => fields.CdPaymentDay[this]; set => fields.CdPaymentDay[this] = value; }

    [DisplayName("Se Payment Time"), Column("K7101_sePaymentTime"), Size(3), Hidden]
    public string SePaymentTime { get => fields.SePaymentTime[this]; set => fields.SePaymentTime[this] = value; }

    [DisplayName("Cd Payment Time"), Column("K7101_cdPaymentTime"), Size(3), Hidden]
    public string CdPaymentTime { get => fields.CdPaymentTime[this]; set => fields.CdPaymentTime[this] = value; }

    [DisplayName("Se Site"), Column("K7101_seSite"), Size(3), Hidden]
    public string SeSite { get => fields.SeSite[this]; set => fields.SeSite[this] = value; }

    [DisplayName("Cd Site"), Column("K7101_cdSite"), Size(3), Hidden]
    public string CdSite { get => fields.CdSite[this]; set => fields.CdSite[this] = value; }

    [DisplayName("Se Team"), Column("K7101_seTeam"), Size(3), Hidden]
    public string SeTeam { get => fields.SeTeam[this]; set => fields.SeTeam[this] = value; }

    [DisplayName("Cd Team"), Column("K7101_cdTeam"), Size(3), Hidden]
    public string CdTeam { get => fields.CdTeam[this]; set => fields.CdTeam[this] = value; }

    [DisplayName("Foreign Name1"), Column("K7101_ForeignName1"), Size(100), NotNull]
    public string ForeignName1 { get => fields.ForeignName1[this]; set => fields.ForeignName1[this] = value; }

    [DisplayName("Foreign Name2"), Column("K7101_ForeignName2"), Size(100), NotNull]
    public string ForeignName2 { get => fields.ForeignName2[this]; set => fields.ForeignName2[this] = value; }

    [DisplayName("Company Id"), Column("K7101_CompanyID"), Size(30), NotNull]
    public string CompanyId { get => fields.CompanyId[this]; set => fields.CompanyId[this] = value; }

    [DisplayName("Company Type"), Column("K7101_CompanyType"), Size(50), NotNull]
    public string CompanyType { get => fields.CompanyType[this]; set => fields.CompanyType[this] = value; }

    [DisplayName("Company Item"), Column("K7101_CompanyItem"), Size(50), NotNull]
    public string CompanyItem { get => fields.CompanyItem[this]; set => fields.CompanyItem[this] = value; }

    

    

    [DisplayName("Address1"), Column("K7101_Address1"), Size(500), NotNull]
    public string Address1 { get => fields.Address1[this]; set => fields.Address1[this] = value; }

    [DisplayName("Address2"), Column("K7101_Address2"), Size(500), NotNull]
    public string Address2 { get => fields.Address2[this]; set => fields.Address2[this] = value; }

    [DisplayName("Destination"), Column("K7101_Destination"), Size(500), Hidden]
    public string Destination { get => fields.Destination[this]; set => fields.Destination[this] = value; }

    [DisplayName("Final Shop"), Column("K7101_FinalShop"), Size(500)]
    public string FinalShop { get => fields.FinalShop[this]; set => fields.FinalShop[this] = value; }

    [DisplayName("Country"), Column("K7101_Country"), Size(500)]
    public string Country { get => fields.Country[this]; set => fields.Country[this] = value; }

    [DisplayName("Invoice Account"), Column("K7101_InvoiceAccount"), Size(50)]
    public string InvoiceAccount { get => fields.InvoiceAccount[this]; set => fields.InvoiceAccount[this] = value; }

    [DisplayName("Tax Exempt"), Column("K7101_TaxExempt"), Size(50)]
    public string TaxExempt { get => fields.TaxExempt[this]; set => fields.TaxExempt[this] = value; }

    [DisplayName("Se Supplier Group"), Column("K7101_seSupplierGroup"), Size(3), Hidden]
    public string SeSupplierGroup { get => fields.SeSupplierGroup[this]; set => fields.SeSupplierGroup[this] = value; }

    [DisplayName("Cd Supplier Group"), Column("K7101_cdSupplierGroup"), Size(3), Hidden]
    public string CdSupplierGroup { get => fields.CdSupplierGroup[this]; set => fields.CdSupplierGroup[this] = value; }

    [DisplayName("Se Po Group"), Column("K7101_sePOGroup"), Size(3), Hidden]
    public string SePoGroup { get => fields.SePoGroup[this]; set => fields.SePoGroup[this] = value; }

    [DisplayName("Cd Po Group"), Column("K7101_cdPOGroup"), Size(3), Hidden]
    public string CdPoGroup { get => fields.CdPoGroup[this]; set => fields.CdPoGroup[this] = value; }

    [DisplayName("Se So Group"), Column("K7101_seSOGroup"), Size(3), Hidden]
    public string SeSoGroup { get => fields.SeSoGroup[this]; set => fields.SeSoGroup[this] = value; }

    [DisplayName("Cd So Group"), Column("K7101_cdSOGroup"), Size(3), Hidden]
    public string CdSoGroup { get => fields.CdSoGroup[this]; set => fields.CdSoGroup[this] = value; }

    

    [DisplayName("Telephone Hand"), Column("K7101_TelephoneHand"), Size(50), NotNull, Hidden]
    public string TelephoneHand { get => fields.TelephoneHand[this]; set => fields.TelephoneHand[this] = value; }

    

    [DisplayName("Beneficiary Name"), Column("K7101_BeneficiaryName"), Size(500), Hidden]
    public string BeneficiaryName { get => fields.BeneficiaryName[this]; set => fields.BeneficiaryName[this] = value; }

    [DisplayName("Account Number"), Column("K7101_AccountNumber"), Size(500), Hidden]
    public string AccountNumber { get => fields.AccountNumber[this]; set => fields.AccountNumber[this] = value; }

    [DisplayName("Bank Name"), Column("K7101_BankName"), Size(500), Hidden]
    public string BankName { get => fields.BankName[this]; set => fields.BankName[this] = value; }

    [DisplayName("Bank Address"), Column("K7101_BankAddress"), Size(500), Hidden]
    public string BankAddress { get => fields.BankAddress[this]; set => fields.BankAddress[this] = value; }

    [DisplayName("Swift Code"), Column("K7101_SwiftCode"), Size(500), Hidden]
    public string SwiftCode { get => fields.SwiftCode[this]; set => fields.SwiftCode[this] = value; }

    [DisplayName("Cd Factory"), Column("K7101_cdFactory"), Size(3), NotNull]
    public string CdFactory { get => fields.CdFactory[this]; set => fields.CdFactory[this] = value; }

    [DisplayName("Check Kind Customer"), Column("K7101_CheckKindCustomer"), Size(1), NotNull]
    public string CheckKindCustomer { get => fields.CheckKindCustomer[this]; set => fields.CheckKindCustomer[this] = value; }

    [DisplayName("Se Cancel Date"), Column("K7101_seCancelDate"), Size(3), Hidden]
    public string SeCancelDate { get => fields.SeCancelDate[this]; set => fields.SeCancelDate[this] = value; }

    [DisplayName("Cd Cancel Date"), Column("K7101_cdCancelDate"), Size(3), Hidden]
    public string CdCancelDate { get => fields.CdCancelDate[this]; set => fields.CdCancelDate[this] = value; }

    [DisplayName("Se Customer Division"), Column("K7101_seCustomerDivision"), Size(3), NotNull]
    public string SeCustomerDivision { get => fields.SeCustomerDivision[this]; set => fields.SeCustomerDivision[this] = value; }

    [DisplayName("Cd Customer Division"), Column("K7101_cdCustomerDivision"), Size(3), NotNull]
    public string CdCustomerDivision { get => fields.CdCustomerDivision[this]; set => fields.CdCustomerDivision[this] = value; }

    [DisplayName("Se Customer Location"), Column("K7101_seCustomerLocation"), Size(3), NotNull]
    public string SeCustomerLocation { get => fields.SeCustomerLocation[this]; set => fields.SeCustomerLocation[this] = value; }

    [DisplayName("Cd Customer Location"), Column("K7101_cdCustomerLocation"), Size(3), NotNull]
    public string CdCustomerLocation { get => fields.CdCustomerLocation[this]; set => fields.CdCustomerLocation[this] = value; }

    [DisplayName("Se Tax Group"), Column("K7101_seTaxGroup"), Size(3), Hidden]
    public string SeTaxGroup { get => fields.SeTaxGroup[this]; set => fields.SeTaxGroup[this] = value; }

    [DisplayName("Cd Tax Group"), Column("K7101_cdTaxGroup"), Size(3), Hidden]
    public string CdTaxGroup { get => fields.CdTaxGroup[this]; set => fields.CdTaxGroup[this] = value; }

    [DisplayName("In Charge"), Column("K7101_InCharge"), Size(8), NotNull, Hidden]
    public string InCharge { get => fields.InCharge[this]; set => fields.InCharge[this] = value; }

    [DisplayName("In Charge Sale"), Column("K7101_InChargeSale"), Size(8), NotNull, Hidden]
    public string InChargeSale { get => fields.InChargeSale[this]; set => fields.InChargeSale[this] = value; }

    [DisplayName("Check Tax"), Column("K7101_CheckTax"), Size(1), NotNull, Hidden]
    public string CheckTax { get => fields.CheckTax[this]; set => fields.CheckTax[this] = value; }

    [DisplayName("Check Customer"), Column("K7101_CheckCustomer"), Size(1), NotNull, Hidden]
    public string CheckCustomer { get => fields.CheckCustomer[this]; set => fields.CheckCustomer[this] = value; }

    [DisplayName("Check Supplier"), Column("K7101_CheckSupplier"), Size(1), NotNull, Hidden]
    public string CheckSupplier { get => fields.CheckSupplier[this]; set => fields.CheckSupplier[this] = value; }

    [DisplayName("Check Employee"), Column("K7101_CheckEmployee"), Size(1), NotNull, Hidden]
    public string CheckEmployee { get => fields.CheckEmployee[this]; set => fields.CheckEmployee[this] = value; }

    [DisplayName("Check Inside"), Column("K7101_CheckInside"), Size(1), NotNull, Hidden]
    public string CheckInside { get => fields.CheckInside[this]; set => fields.CheckInside[this] = value; }

    [DisplayName("Check Outside"), Column("K7101_CheckOutside"), Size(1), NotNull, Hidden]
    public string CheckOutside { get => fields.CheckOutside[this]; set => fields.CheckOutside[this] = value; }

    [DisplayName("Check Others"), Column("K7101_CheckOthers"), Size(1), NotNull, Hidden]
    public string CheckOthers { get => fields.CheckOthers[this]; set => fields.CheckOthers[this] = value; }

    [DisplayName("Check Use"), Column("K7101_CheckUse"), Size(1), NotNull, Hidden]
    public string CheckUse { get => fields.CheckUse[this]; set => fields.CheckUse[this] = value; }

    [DisplayName("Incharge Insert"), Column("K7101_InchargeInsert"), Size(8), Hidden]
    public string InchargeInsert { get => fields.InchargeInsert[this]; set => fields.InchargeInsert[this] = value; }

    [DisplayName("Incharge Update"), Column("K7101_InchargeUpdate"), Size(8), Hidden]
    public string InchargeUpdate { get => fields.InchargeUpdate[this]; set => fields.InchargeUpdate[this] = value; }

    [DisplayName("Date Insert"), Column("K7101_DateInsert"), Size(8), NotNull, Hidden]
    public string DateInsert { get => fields.DateInsert[this]; set => fields.DateInsert[this] = value; }

    [DisplayName("Date Update"), Column("K7101_DateUpdate"), Size(8), NotNull, Hidden]
    public string DateUpdate { get => fields.DateUpdate[this]; set => fields.DateUpdate[this] = value; }

    [DisplayName("Time Insert"), Column("K7101_TimeInsert"), Size(14), NotNull, Hidden]
    public string TimeInsert { get => fields.TimeInsert[this]; set => fields.TimeInsert[this] = value; }

    [DisplayName("Time Update"), Column("K7101_TimeUpdate"), Size(14), NotNull, Hidden]
    public string TimeUpdate { get => fields.TimeUpdate[this]; set => fields.TimeUpdate[this] = value; }

    [DisplayName("Time Last"), Column("K7101_TimeLast"), Size(14), NotNull, Hidden]
    public string TimeLast { get => fields.TimeLast[this]; set => fields.TimeLast[this] = value; }

    [DisplayName("Date Active"), Column("K7101_DateActive"), Size(8), NotNull, Hidden]
    public string DateActive { get => fields.DateActive[this]; set => fields.DateActive[this] = value; }

    [DisplayName("Date Deactive"), Column("K7101_DateDeactive"), Size(8), NotNull, Hidden]
    public string DateDeactive { get => fields.DateDeactive[this]; set => fields.DateDeactive[this] = value; }

    [DisplayName("Check Active"), Column("K7101_CheckActive"), Size(1), NotNull, Hidden]
    public string CheckActive { get => fields.CheckActive[this]; set => fields.CheckActive[this] = value; }

    [DisplayName("Para No1"), Column("K7101_ParaNo1"), Size(18), Scale(4), Hidden]
    public decimal? ParaNo1 { get => fields.ParaNo1[this]; set => fields.ParaNo1[this] = value; }

    [DisplayName("Para No2"), Column("K7101_ParaNo2"), Size(18), Scale(4), Hidden]
    public decimal? ParaNo2 { get => fields.ParaNo2[this]; set => fields.ParaNo2[this] = value; }

    [DisplayName("Para No3"), Column("K7101_ParaNo3"), Size(18), Scale(4), Hidden]
    public decimal? ParaNo3 { get => fields.ParaNo3[this]; set => fields.ParaNo3[this] = value; }

    [DisplayName("Check Sync"), Column("K7101_CheckSync"), Size(1), Hidden]
    public string CheckSync { get => fields.CheckSync[this]; set => fields.CheckSync[this] = value; }

    [DisplayName("Check Customer Status"), Column("K7101_CheckCustomerStatus"), Size(1), Hidden]
    public string CheckCustomerStatus { get => fields.CheckCustomerStatus[this]; set => fields.CheckCustomerStatus[this] = value; }

    [DisplayName("Date Complete"), Column("K7101_DateComplete"), Size(8), Hidden]
    public string DateComplete { get => fields.DateComplete[this]; set => fields.DateComplete[this] = value; }

    [DisplayName("Date Approved"), Column("K7101_DateApproved"), Size(8), Hidden]
    public string DateApproved { get => fields.DateApproved[this]; set => fields.DateApproved[this] = value; }

    [DisplayName("Date Cancel"), Column("K7101_DateCancel"), Size(8), Hidden]
    public string DateCancel { get => fields.DateCancel[this]; set => fields.DateCancel[this] = value; }

    [DisplayName("Date Pending1"), Column("K7101_DatePending1"), Size(8), Hidden]
    public string DatePending1 { get => fields.DatePending1[this]; set => fields.DatePending1[this] = value; }

    [DisplayName("Date Pending2"), Column("K7101_DatePending2"), Size(8), Hidden]
    public string DatePending2 { get => fields.DatePending2[this]; set => fields.DatePending2[this] = value; }

    [DisplayName("Remark"), Column("K7101_Remark"), Size(300), NotNull, Hidden]
    public string Remark { get => fields.Remark[this]; set => fields.Remark[this] = value; }

    [DisplayName("Check Option1"), Column("K7101_CheckOption1"), Size(1), Hidden]
    public string CheckOption1 { get => fields.CheckOption1[this]; set => fields.CheckOption1[this] = value; }

    [DisplayName("Check Option2"), Column("K7101_CheckOption2"), Size(1), Hidden]
    public string CheckOption2 { get => fields.CheckOption2[this]; set => fields.CheckOption2[this] = value; }

    [DisplayName("Check Option3"), Column("K7101_CheckOption3"), Size(1), Hidden]
    public string CheckOption3 { get => fields.CheckOption3[this]; set => fields.CheckOption3[this] = value; }

    [DisplayName("Check Option4"), Column("K7101_CheckOption4"), Size(1), Hidden]
    public string CheckOption4 { get => fields.CheckOption4[this]; set => fields.CheckOption4[this] = value; }

    [DisplayName("Check Option5"), Column("K7101_CheckOption5"), Size(1), Hidden]
    public string CheckOption5 { get => fields.CheckOption5[this]; set => fields.CheckOption5[this] = value; }

    [DisplayName("Check Option6"), Column("K7101_CheckOption6"), Size(1), Hidden]
    public string CheckOption6 { get => fields.CheckOption6[this]; set => fields.CheckOption6[this] = value; }

    [DisplayName("Check Option7"), Column("K7101_CheckOption7"), Size(1), Hidden]
    public string CheckOption7 { get => fields.CheckOption7[this]; set => fields.CheckOption7[this] = value; }

    [DisplayName("Check Option8"), Column("K7101_CheckOption8"), Size(1), Hidden]
    public string CheckOption8 { get => fields.CheckOption8[this]; set => fields.CheckOption8[this] = value; }

    [DisplayName("Check Option9"), Column("K7101_CheckOption9"), Size(1), Hidden]
    public string CheckOption9 { get => fields.CheckOption9[this]; set => fields.CheckOption9[this] = value; }

    [DisplayName("Check Option10"), Column("K7101_CheckOption10"), Size(1), Hidden]
    public string CheckOption10 { get => fields.CheckOption10[this]; set => fields.CheckOption10[this] = value; }

    [DisplayName("Shipper"), Column("K7101_Shipper"), Size(200), Hidden]
    public string Shipper { get => fields.Shipper[this]; set => fields.Shipper[this] = value; }

    [DisplayName("Shipper To"), Column("K7101_ShipperTo"), Size(200), Hidden]
    public string ShipperTo { get => fields.ShipperTo[this]; set => fields.ShipperTo[this] = value; }

    [DisplayName("Buyer"), Column("K7101_Buyer"), Size(200), Hidden]
    public string Buyer { get => fields.Buyer[this]; set => fields.Buyer[this] = value; }

    [DisplayName("Consignee"), Column("K7101_Consignee"), Size(200), Hidden]
    public string Consignee { get => fields.Consignee[this]; set => fields.Consignee[this] = value; }

    [DisplayName("Lc No"), Column("K7101_LCNo"), Size(200), Hidden]
    public string LcNo { get => fields.LcNo[this]; set => fields.LcNo[this] = value; }

    [DisplayName("Date Lc"), Column("K7101_DateLC"), Size(200), Hidden]
    public string DateLc { get => fields.DateLc[this]; set => fields.DateLc[this] = value; }

    [DisplayName("Notifyparty"), Column("K7101_Notifyparty"), Size(1000), Hidden]
    public string Notifyparty { get => fields.Notifyparty[this]; set => fields.Notifyparty[this] = value; }

    [DisplayName("Notifyparty And"), Column("K7101_NotifypartyAnd"), Size(200), Hidden]
    public string NotifypartyAnd { get => fields.NotifypartyAnd[this]; set => fields.NotifypartyAnd[this] = value; }

    [DisplayName("Vis All Name"), Column("K7101_VisAllName"), Size(200), Hidden]
    public string VisAllName { get => fields.VisAllName[this]; set => fields.VisAllName[this] = value; }

    [DisplayName("Date Depart"), Column("K7101_DateDepart"), Size(200), Hidden]
    public string DateDepart { get => fields.DateDepart[this]; set => fields.DateDepart[this] = value; }

    [DisplayName("Flight No"), Column("K7101_FlightNo"), Size(200), Hidden]
    public string FlightNo { get => fields.FlightNo[this]; set => fields.FlightNo[this] = value; }

    [DisplayName("Ship From"), Column("K7101_ShipFrom"), Size(200), Hidden]
    public string ShipFrom { get => fields.ShipFrom[this]; set => fields.ShipFrom[this] = value; }

    [DisplayName("Ship To"), Column("K7101_ShipTo"), Size(200), Hidden]
    public string ShipTo { get => fields.ShipTo[this]; set => fields.ShipTo[this] = value; }

    [DisplayName("Ship Mark"), Column("K7101_ShipMark"), Size(200), Hidden]
    public string ShipMark { get => fields.ShipMark[this]; set => fields.ShipMark[this] = value; }

    [DisplayName("Remarks"), Column("K7101_Remarks"), Size(1000), Hidden]
    public string Remarks { get => fields.Remarks[this]; set => fields.Remarks[this] = value; }

    [DisplayName("Term Pri"), Column("K7101_TermPri"), Size(200), Hidden]
    public string TermPri { get => fields.TermPri[this]; set => fields.TermPri[this] = value; }

    [DisplayName("Shipper1"), Column("K7101_Shipper1"), Size(200), Hidden]
    public string Shipper1 { get => fields.Shipper1[this]; set => fields.Shipper1[this] = value; }

    [DisplayName("Shipper To1"), Column("K7101_ShipperTo1"), Size(200), Hidden]
    public string ShipperTo1 { get => fields.ShipperTo1[this]; set => fields.ShipperTo1[this] = value; }

    [DisplayName("Buyer1"), Column("K7101_Buyer1"), Size(200), Hidden]
    public string Buyer1 { get => fields.Buyer1[this]; set => fields.Buyer1[this] = value; }

    [DisplayName("Consignee1"), Column("K7101_Consignee1"), Size(200), Hidden]
    public string Consignee1 { get => fields.Consignee1[this]; set => fields.Consignee1[this] = value; }

    [DisplayName("Lc No1"), Column("K7101_LCNo1"), Size(200), Hidden]
    public string LcNo1 { get => fields.LcNo1[this]; set => fields.LcNo1[this] = value; }

    [DisplayName("Date Lc1"), Column("K7101_DateLC1"), Size(200), Hidden]
    public string DateLc1 { get => fields.DateLc1[this]; set => fields.DateLc1[this] = value; }

    [DisplayName("Notifyparty1"), Column("K7101_Notifyparty1"), Size(1000), Hidden]
    public string Notifyparty1 { get => fields.Notifyparty1[this]; set => fields.Notifyparty1[this] = value; }

    [DisplayName("Notifyparty And1"), Column("K7101_NotifypartyAnd1"), Size(200), Hidden]
    public string NotifypartyAnd1 { get => fields.NotifypartyAnd1[this]; set => fields.NotifypartyAnd1[this] = value; }

    [DisplayName("Vis All Name1"), Column("K7101_VisAllName1"), Size(200), Hidden]
    public string VisAllName1 { get => fields.VisAllName1[this]; set => fields.VisAllName1[this] = value; }

    [DisplayName("Date Depart1"), Column("K7101_DateDepart1"), Size(200), Hidden]
    public string DateDepart1 { get => fields.DateDepart1[this]; set => fields.DateDepart1[this] = value; }

    [DisplayName("Flight No1"), Column("K7101_FlightNo1"), Size(200), Hidden]
    public string FlightNo1 { get => fields.FlightNo1[this]; set => fields.FlightNo1[this] = value; }

    [DisplayName("Ship From1"), Column("K7101_ShipFrom1"), Size(200), Hidden]
    public string ShipFrom1 { get => fields.ShipFrom1[this]; set => fields.ShipFrom1[this] = value; }

    [DisplayName("Ship To1"), Column("K7101_ShipTo1"), Size(200), Hidden]
    public string ShipTo1 { get => fields.ShipTo1[this]; set => fields.ShipTo1[this] = value; }

    [DisplayName("Ship Mark1"), Column("K7101_ShipMark1"), Size(200), Hidden]
    public string ShipMark1 { get => fields.ShipMark1[this]; set => fields.ShipMark1[this] = value; }

    [DisplayName("Remarks1"), Column("K7101_Remarks1"), Size(1000), Hidden]
    public string Remarks1 { get => fields.Remarks1[this]; set => fields.Remarks1[this] = value; }

    [DisplayName("Term Pri1"), Column("K7101_TermPri1"), Size(200), Hidden]
    public string TermPri1 { get => fields.TermPri1[this]; set => fields.TermPri1[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public StringField CustomerCode;
        public ByteArrayField QrCode;
        public StringField ACodeReceivable;
        public StringField ACodePayable;
        public StringField DevelopmentCode;
        public StringField QrCodeName;
        public StringField QrCodeTel;
        public StringField CustomerName;
        public StringField CustomerName1;
        public StringField CustomerNameSimply;
        public StringField CustomerNameSimply1;
        public GuidField FaceId;
        public StringField SePassWord;
        public StringField CdPassWord;
        public StringField SeDeliveryTerm;
        public StringField CdDeliveryTerm;
        public StringField SePaymentTerm;
        public StringField CdPaymentTerm;
        public StringField SePaymentCondition;
        public StringField CdPaymentCondition;
        public StringField SePaymentDay;
        public StringField CdPaymentDay;
        public StringField SePaymentTime;
        public StringField CdPaymentTime;
        public StringField SeSite;
        public StringField CdSite;
        public StringField SeTeam;
        public StringField CdTeam;
        public StringField ForeignName1;
        public StringField ForeignName2;
        public StringField CompanyId;
        public StringField CompanyType;
        public StringField CompanyItem;
        public StringField Representative;
        public StringField AddressNo;
        public StringField Address1;
        public StringField Address2;
        public StringField Destination;
        public StringField FinalShop;
        public StringField Country;
        public StringField InvoiceAccount;
        public StringField TaxExempt;
        public StringField SeSupplierGroup;
        public StringField CdSupplierGroup;
        public StringField SePoGroup;
        public StringField CdPoGroup;
        public StringField SeSoGroup;
        public StringField CdSoGroup;
        public StringField TelephoneCompany;
        public StringField TelephoneHand;
        public StringField FaxNo;
        public StringField Email;
        public StringField BeneficiaryName;
        public StringField AccountNumber;
        public StringField BankName;
        public StringField BankAddress;
        public StringField SwiftCode;
        public StringField CdFactory;
        public StringField CheckKindCustomer;
        public StringField SeCancelDate;
        public StringField CdCancelDate;
        public StringField SeCustomerDivision;
        public StringField CdCustomerDivision;
        public StringField SeCustomerLocation;
        public StringField CdCustomerLocation;
        public StringField SeTaxGroup;
        public StringField CdTaxGroup;
        public StringField InCharge;
        public StringField InChargeSale;
        public StringField CheckTax;
        public StringField CheckCustomer;
        public StringField CheckSupplier;
        public StringField CheckEmployee;
        public StringField CheckInside;
        public StringField CheckOutside;
        public StringField CheckOthers;
        public StringField CheckUse;
        public StringField InchargeInsert;
        public StringField InchargeUpdate;
        public StringField DateInsert;
        public StringField DateUpdate;
        public StringField TimeInsert;
        public StringField TimeUpdate;
        public StringField TimeLast;
        public StringField DateActive;
        public StringField DateDeactive;
        public StringField CheckActive;
        public DecimalField ParaNo1;
        public DecimalField ParaNo2;
        public DecimalField ParaNo3;
        public StringField CheckSync;
        public StringField CheckCustomerStatus;
        public StringField DateComplete;
        public StringField DateApproved;
        public StringField DateCancel;
        public StringField DatePending1;
        public StringField DatePending2;
        public StringField Remark;
        public StringField CheckOption1;
        public StringField CheckOption2;
        public StringField CheckOption3;
        public StringField CheckOption4;
        public StringField CheckOption5;
        public StringField CheckOption6;
        public StringField CheckOption7;
        public StringField CheckOption8;
        public StringField CheckOption9;
        public StringField CheckOption10;
        public StringField Shipper;
        public StringField ShipperTo;
        public StringField Buyer;
        public StringField Consignee;
        public StringField LcNo;
        public StringField DateLc;
        public StringField Notifyparty;
        public StringField NotifypartyAnd;
        public StringField VisAllName;
        public StringField DateDepart;
        public StringField FlightNo;
        public StringField ShipFrom;
        public StringField ShipTo;
        public StringField ShipMark;
        public StringField Remarks;
        public StringField TermPri;
        public StringField Shipper1;
        public StringField ShipperTo1;
        public StringField Buyer1;
        public StringField Consignee1;
        public StringField LcNo1;
        public StringField DateLc1;
        public StringField Notifyparty1;
        public StringField NotifypartyAnd1;
        public StringField VisAllName1;
        public StringField DateDepart1;
        public StringField FlightNo1;
        public StringField ShipFrom1;
        public StringField ShipTo1;
        public StringField ShipMark1;
        public StringField Remarks1;
        public StringField TermPri1;

    }
}
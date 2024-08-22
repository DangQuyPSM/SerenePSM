using Serenity.ComponentModel;
using System.ComponentModel;

namespace SerenePSM.Default.Columns;

[ColumnsScript("Default.Pfk7231")]
[BasedOnRow(typeof(Pfk7231Row), CheckNames = true)]
public class Pfk7231Columns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string MaterialCode { get; set; }
    public string MaterialPName { get; set; }

    public string MaterialSimple { get; set; }

    public string Hscode { get; set; }
    public string MaterialName { get; set; }

    public string ImportCode { get; set; }

    public string Width { get; set; }

    public string SeUnitPrice { get; set; }

    public string SeUnitPacking { get; set; }

    public string DateInsert { get; set; }

    public decimal QtyBasic { get; set; }

    public decimal MaxInventory { get; set; }
    public decimal MinInventory { get; set; }

    public string CheckUse { get; set; }
    //public string MaterialColor { get; set; }
    //public string SeImportGroup { get; set; }
    //public string CdImportGroup { get; set; }
    
    //public string LogisticCodeSg { get; set; }
    
    //public string ImportName { get; set; }
    //public string Hscode1 { get; set; }
    //public string ImportCode1 { get; set; }
    //public string ImportName1 { get; set; }
    //public string AccountCode { get; set; }
    //public string AccountName { get; set; }
    //public string OtherCode1 { get; set; }
    //public string OtherCode2 { get; set; }
    //public string DevelopmentCode { get; set; }
    //public string DevelopmentName { get; set; }
    //public string MaterialForeign1 { get; set; }
    //public string MaterialForeign2 { get; set; }
    
    //public string Height { get; set; }
    //public string SizeName { get; set; }
    //public string CheckPrint { get; set; }
    //public string CheckSp { get; set; }
    //public string SeSpecial { get; set; }
    //public string CdSpecial { get; set; }
    //public string SizeRangeTool { get; set; }
    //public string CheckKindMaterial { get; set; }
    //public string CheckMarketType { get; set; }
    
    //public string CdUnitPrice { get; set; }
    //public string DateExchangePrice { get; set; }
    //public decimal ExchangePrice { get; set; }
    //public decimal PriceUsd { get; set; }
    //public decimal PriceVnd { get; set; }
    //public string SeDepartment { get; set; }
    //public string CdDepartment { get; set; }
    //public string SeLargeGroupMaterial { get; set; }
    //public string CdLargeGroupMaterial { get; set; }
    //public string SeSemiGroupMaterial { get; set; }
    //public string CdSemiGroupMaterial { get; set; }
    //public string SeDetailGroupMaterial { get; set; }
    //public string CdDetailGroupMaterial { get; set; }
    //public string SeSpecGroup1 { get; set; }
    //public string CdSpecGroup1 { get; set; }
    //public string SeSpecGroup2 { get; set; }
    //public string CdSpecGroup2 { get; set; }
    //public string SeSpecGroup3 { get; set; }
    //public string CdSpecGroup3 { get; set; }
    //public string SeSpecGroup4 { get; set; }
    //public string CdSpecGroup4 { get; set; }
    //public string SeSpecGroup5 { get; set; }
    //public string CdSpecGroup5 { get; set; }
    //public string SeUnitMaterial { get; set; }
    //public string CdUnitMaterial { get; set; }
    
    //public string CdUnitPacking { get; set; }
    //public string SeTax { get; set; }
    //public string CdTax { get; set; }
    //public decimal PerTaxImport { get; set; }
    //public decimal PerTaxVat { get; set; }
    
    //public decimal QtyOptimum { get; set; }
    //public decimal DayOptimum { get; set; }
    //public decimal DayEstimate { get; set; }
    //public decimal PriceMaterial { get; set; }
    //public decimal QtyMoq { get; set; }
    
    //public decimal ReOrderQty { get; set; }
    //public string CheckDevRnD { get; set; }
    //public string StatusMaterial { get; set; }
    //public string BomType { get; set; }
    //public string ApplyType { get; set; }
    //public string DateStart { get; set; }
    //public string DateOptimum { get; set; }
    //public string DateEstimate { get; set; }
    //public string DateInBound { get; set; }
    //public string DateOutBound { get; set; }
    //public string SupplyName { get; set; }
    //public string SupplyCode { get; set; }
    //public string SalesCode { get; set; }
    //public string Check1 { get; set; }
    //public string Check2 { get; set; }
    //public string Check3 { get; set; }
    //public string Check4 { get; set; }
    //public string Check5 { get; set; }
    //public string Check6 { get; set; }
    //public string Check7 { get; set; }
    //public string Check8 { get; set; }
    //public string Check9 { get; set; }
    //public string Check10 { get; set; }
    //public string CheckName1 { get; set; }
    //public string CheckName2 { get; set; }
    //public string CheckName3 { get; set; }
    //public string CheckName4 { get; set; }
    //public string CheckName5 { get; set; }
    //public string CheckName6 { get; set; }
    //public string CheckName7 { get; set; }
    //public string CheckName8 { get; set; }
    //public string CheckName9 { get; set; }
    //public string CheckName10 { get; set; }
    //public string ACodeMaterial { get; set; }
    //public string ACodeTax1 { get; set; }
    //public string ACodeTax2 { get; set; }
    //public string ACodeTax3 { get; set; }
    //public string ACodeSales { get; set; }
    //public string ACodeIntSales { get; set; }
    //public string ACodeCogs { get; set; }
    //public string ACodeReturn { get; set; }
    //public string ACodeDiscount { get; set; }
    //public string ACodeWip { get; set; }
    //public string CheckInventory { get; set; }
    //public string CheckPosition { get; set; }
    //public string CheckLotNo { get; set; }
    //public string CheckPrice { get; set; }
    //public string SeTax1 { get; set; }
    //public string CdTax1 { get; set; }
    //public decimal PerTax1 { get; set; }
    //public string SeTax2 { get; set; }
    //public string CdTax2 { get; set; }
    //public decimal PerTax2 { get; set; }
    //public string SeTax3 { get; set; }
    //public string CdTax3 { get; set; }
    //public decimal PerTax3 { get; set; }
    //public string SeTaxVat { get; set; }
    //public string CdTaxVat { get; set; }
    //public string SeTaxImport { get; set; }
    //public string CdTaxImport { get; set; }
    //public string SeTaxExport { get; set; }
    //public string CdTaxExport { get; set; }
    //public string SeTaxSpecial { get; set; }
    //public string CdTaxSpecial { get; set; }
    //public string SeAccMaterial { get; set; }
    //public string CdAccMaterial { get; set; }
    //public string SeAccSales { get; set; }
    //public string CdAccSales { get; set; }
    //public string SeAccIntSales { get; set; }
    //public string CdAccIntSales { get; set; }
    //public string SeAccCogs { get; set; }
    //public string CdAccCogs { get; set; }
    //public string SeAccReturn { get; set; }
    //public string CdAccReturn { get; set; }
    //public string SeAccDiscount { get; set; }
    //public string CdAccDiscount { get; set; }
    //public string SeAccWip { get; set; }
    //public string CdAccWip { get; set; }
    
    //public string DateUpdate { get; set; }
    //public string InchargeInsert { get; set; }
    //public string InchargeUpdate { get; set; }
    //public string InchargeComplete { get; set; }
    //public string InchargeCancel { get; set; }
    //public string InchargeApproved { get; set; }
    //public string InchargePending1 { get; set; }
    //public string InchargePending2 { get; set; }
    
    //public string DateActive { get; set; }
    //public string DateDeactive { get; set; }
    //public string CheckActive { get; set; }
    //public string DateComplete { get; set; }
    //public string DateApproved { get; set; }
    //public string DateCancel { get; set; }
    //public string DatePending1 { get; set; }
    //public string DatePending2 { get; set; }
    //public string CheckSync { get; set; }
    //public string MaterialFullName { get; set; }
    //public string MaterialOldName { get; set; }
    //public string Remark { get; set; }
    //public string SeSite { get; set; }
    //public string CdSite { get; set; }
}
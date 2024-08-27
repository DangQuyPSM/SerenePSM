using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SerenePSM.Default;

[ConnectionKey("Default"), Module("Default"), TableName("PFK7231")]
[DisplayName("Danh mục vật tư-(PFP72310)"), InstanceName("Pfk7231")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class Pfk7231Row : Row<Pfk7231Row.RowFields>, IIdRow, INameRow
{
    [DisplayName("Mã vật tư"), Column("K7231_MaterialCode"), Size(6), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string MaterialCode { get => fields.MaterialCode[this]; set => fields.MaterialCode[this] = value; }

    [DisplayName("Mã HĐGC"), Column("K7231_MaterialPName"), Size(500)]
    public string MaterialPName { get => fields.MaterialPName[this]; set => fields.MaterialPName[this] = value; }

    [DisplayName("Logistic"), Column("K7231_MaterialSimple"), Size(500)]
    public string MaterialSimple { get => fields.MaterialSimple[this]; set => fields.MaterialSimple[this] = value; }
    [DisplayName("Hs Code"), Column("K7231_HSCODE"), Size(50)]
    public string Hscode { get => fields.Hscode[this]; set => fields.Hscode[this] = value; }

    [DisplayName("Tên vật tư"), Column("K7231_MaterialName"), Size(500)]
    public string MaterialName { get => fields.MaterialName[this]; set => fields.MaterialName[this] = value; }

    [DisplayName("Mã CS"), Column("K7231_ImportCode"), Size(50)]
    public string ImportCode { get => fields.ImportCode[this]; set => fields.ImportCode[this] = value; }
    [DisplayName("Khổ"), Column("K7231_Width"), Size(20)]
    public string Width { get => fields.Width[this]; set => fields.Width[this] = value; }

    [DisplayName("Đơn vị tính"), Column("K7231_seUnitPrice"), Size(3)]
    public string SeUnitPrice { get => fields.SeUnitPrice[this]; set => fields.SeUnitPrice[this] = value; }

    [DisplayName("Đơn vị đóng"), Column("K7231_seUnitPacking"), Size(3)]
    public string SeUnitPacking { get => fields.SeUnitPacking[this]; set => fields.SeUnitPacking[this] = value; }

    [DisplayName("Ngày tạo"), Column("K7231_DateInsert"), Size(8)]
    public string DateInsert { get => fields.DateInsert[this]; set => fields.DateInsert[this] = value; }

    [DisplayName("Số lượng tồn kho"), Column("K7231_QtyBasic"), Size(18), Scale(3)]
    public decimal? QtyBasic { get => fields.QtyBasic[this]; set => fields.QtyBasic[this] = value; }

    [DisplayName("Nhóm lớn"), Column("K7231_MaxInventory"), Size(18), Scale(3)]
    public decimal? MaxInventory { get => fields.MaxInventory[this]; set => fields.MaxInventory[this] = value; }

    [DisplayName("Nhóm nhỏ"), Column("K7231_MinInventory"), Size(18), Scale(3)]
    public decimal? MinInventory { get => fields.MinInventory[this]; set => fields.MinInventory[this] = value; }

    [DisplayName("Sử dụng"), Column("K7231_CheckUse"), Size(1)]
    [BooleanEditor, CheckboxFormatter]
    public bool? CheckUse
    {
        get => fields.CheckUse[this] == "1";
        set => fields.CheckUse[this] = value == true ? "1" : "0";
    }


    [DisplayName("Material Color"), Column("K7231_MaterialColor"), Size(500), Hidden]
    public string MaterialColor { get => fields.MaterialColor[this]; set => fields.MaterialColor[this] = value; }

    [DisplayName("Se Import Group"), Column("K7231_seImportGroup"), Size(3), Hidden]
    public string SeImportGroup { get => fields.SeImportGroup[this]; set => fields.SeImportGroup[this] = value; }

    [DisplayName("Cd Import Group"), Column("K7231_cdImportGroup"), Size(3), Hidden]
    public string CdImportGroup { get => fields.CdImportGroup[this]; set => fields.CdImportGroup[this] = value; }

    [DisplayName("Logistic Code Sg"), Column("K7231_LogisticCodeSG"), Size(100), Hidden]
    public string LogisticCodeSg { get => fields.LogisticCodeSg[this]; set => fields.LogisticCodeSg[this] = value; }

    [DisplayName("Ngày tạo"), Column("K7231_DateActive"), Size(8), Hidden]
    public string DateActive { get => fields.DateActive[this]; set => fields.DateActive[this] = value; }

    [DisplayName("Import Name"), Column("K7231_ImportName"), Size(500), Hidden]
    public string ImportName { get => fields.ImportName[this]; set => fields.ImportName[this] = value; }

    [DisplayName("Hscode1"), Column("K7231_HSCODE1"), Size(50), Hidden]
    public string Hscode1 { get => fields.Hscode1[this]; set => fields.Hscode1[this] = value; }

    [DisplayName("Import Code1"), Column("K7231_ImportCode1"), Size(50), Hidden]
    public string ImportCode1 { get => fields.ImportCode1[this]; set => fields.ImportCode1[this] = value; }

    [DisplayName("Import Name1"), Column("K7231_ImportName1"), Size(500), Hidden]
    public string ImportName1 { get => fields.ImportName1[this]; set => fields.ImportName1[this] = value; }

    [DisplayName("Account Code"), Column("K7231_AccountCode"), Size(50)]
    public string AccountCode { get => fields.AccountCode[this]; set => fields.AccountCode[this] = value; }

    [DisplayName("Account Name"), Column("K7231_AccountName"), Size(50), Hidden]
    public string AccountName { get => fields.AccountName[this]; set => fields.AccountName[this] = value; }

    [DisplayName("Other Code1"), Column("K7231_OtherCode1"), Size(50), Hidden]
    public string OtherCode1 { get => fields.OtherCode1[this]; set => fields.OtherCode1[this] = value; }

    [DisplayName("Other Code2"), Column("K7231_OtherCode2"), Size(50), Hidden]
    public string OtherCode2 { get => fields.OtherCode2[this]; set => fields.OtherCode2[this] = value; }

    [DisplayName("Development Code"), Column("K7231_DevelopmentCode"), Size(50), Hidden]
    public string DevelopmentCode { get => fields.DevelopmentCode[this]; set => fields.DevelopmentCode[this] = value; }

    [DisplayName("Development Name"), Column("K7231_DevelopmentName"), Size(50), Hidden]
    public string DevelopmentName { get => fields.DevelopmentName[this]; set => fields.DevelopmentName[this] = value; }

    [DisplayName("Material Foreign1"), Column("K7231_MaterialForeign1"), Size(100), Hidden]
    public string MaterialForeign1 { get => fields.MaterialForeign1[this]; set => fields.MaterialForeign1[this] = value; }

    [DisplayName("Material Foreign2"), Column("K7231_MaterialForeign2"), Size(100), Hidden]
    public string MaterialForeign2 { get => fields.MaterialForeign2[this]; set => fields.MaterialForeign2[this] = value; }

    

    [DisplayName("Height"), Column("K7231_Height"), Size(20), Hidden]
    public string Height { get => fields.Height[this]; set => fields.Height[this] = value; }

    [DisplayName("Size Name"), Column("K7231_SizeName"), Size(100), Hidden]
    public string SizeName { get => fields.SizeName[this]; set => fields.SizeName[this] = value; }

    [DisplayName("Check Print"), Column("K7231_CheckPrint"), Size(1), Hidden]
    public string CheckPrint { get => fields.CheckPrint[this]; set => fields.CheckPrint[this] = value; }

    [DisplayName("Check Sp"), Column("K7231_CheckSP"), Size(1), Hidden]
    public string CheckSp { get => fields.CheckSp[this]; set => fields.CheckSp[this] = value; }

    [DisplayName("Se Special"), Column("K7231_seSpecial"), Size(3), Hidden]
    public string SeSpecial { get => fields.SeSpecial[this]; set => fields.SeSpecial[this] = value; }

    [DisplayName("Cd Special"), Column("K7231_cdSpecial"), Size(3), Hidden]
    public string CdSpecial { get => fields.CdSpecial[this]; set => fields.CdSpecial[this] = value; }

    [DisplayName("Size Range Tool"), Column("K7231_SizeRangeTool"), Size(6), Hidden]
    public string SizeRangeTool { get => fields.SizeRangeTool[this]; set => fields.SizeRangeTool[this] = value; }

    [DisplayName("Check Kind Material"), Column("K7231_CheckKindMaterial"), Size(1), Hidden]
    public string CheckKindMaterial { get => fields.CheckKindMaterial[this]; set => fields.CheckKindMaterial[this] = value; }

    [DisplayName("Check Market Type"), Column("K7231_CheckMarketType"), Size(1), Hidden]
    public string CheckMarketType { get => fields.CheckMarketType[this]; set => fields.CheckMarketType[this] = value; }

    

    [DisplayName("Cd Unit Price"), Column("K7231_cdUnitPrice"), Size(3), Hidden]
    public string CdUnitPrice { get => fields.CdUnitPrice[this]; set => fields.CdUnitPrice[this] = value; }

    [DisplayName("Date Exchange Price"), Column("K7231_DateExchangePrice"), Size(8), Hidden]
    public string DateExchangePrice { get => fields.DateExchangePrice[this]; set => fields.DateExchangePrice[this] = value; }

    [DisplayName("Exchange Price"), Column("K7231_ExchangePrice"), Size(18), Scale(6), Hidden]
    public decimal? ExchangePrice { get => fields.ExchangePrice[this]; set => fields.ExchangePrice[this] = value; }

    [DisplayName("Price Usd"), Column("K7231_PriceUSD"), Size(18), Scale(6), Hidden]
    public decimal? PriceUsd { get => fields.PriceUsd[this]; set => fields.PriceUsd[this] = value; }

    [DisplayName("Price Vnd"), Column("K7231_PriceVND"), Size(18), Scale(6), Hidden]
    public decimal? PriceVnd { get => fields.PriceVnd[this]; set => fields.PriceVnd[this] = value; }

    [DisplayName("Se Department"), Column("K7231_seDepartment"), Size(3), Hidden]
    public string SeDepartment { get => fields.SeDepartment[this]; set => fields.SeDepartment[this] = value; }

    [DisplayName("Cd Department"), Column("K7231_cdDepartment"), Size(3), Hidden]
    public string CdDepartment { get => fields.CdDepartment[this]; set => fields.CdDepartment[this] = value; }

    [DisplayName("Se Large Group Material"), Column("K7231_seLargeGroupMaterial"), Size(3), Hidden]
    public string SeLargeGroupMaterial { get => fields.SeLargeGroupMaterial[this]; set => fields.SeLargeGroupMaterial[this] = value; }

    [DisplayName("Cd Large Group Material"), Column("K7231_cdLargeGroupMaterial"), Size(3), Hidden]
    public string CdLargeGroupMaterial { get => fields.CdLargeGroupMaterial[this]; set => fields.CdLargeGroupMaterial[this] = value; }

    [DisplayName("Se Semi Group Material"), Column("K7231_seSemiGroupMaterial"), Size(3), Hidden]
    public string SeSemiGroupMaterial { get => fields.SeSemiGroupMaterial[this]; set => fields.SeSemiGroupMaterial[this] = value; }

    [DisplayName("Cd Semi Group Material"), Column("K7231_cdSemiGroupMaterial"), Size(3), Hidden]
    public string CdSemiGroupMaterial { get => fields.CdSemiGroupMaterial[this]; set => fields.CdSemiGroupMaterial[this] = value; }

    [DisplayName("Se Detail Group Material"), Column("K7231_seDetailGroupMaterial"), Size(3), Hidden]
    public string SeDetailGroupMaterial { get => fields.SeDetailGroupMaterial[this]; set => fields.SeDetailGroupMaterial[this] = value; }

    [DisplayName("Cd Detail Group Material"), Column("K7231_cdDetailGroupMaterial"), Size(3), Hidden]
    public string CdDetailGroupMaterial { get => fields.CdDetailGroupMaterial[this]; set => fields.CdDetailGroupMaterial[this] = value; }

    [DisplayName("Se Spec Group1"), Column("K7231_seSpecGroup1"), Size(3), Hidden]
    public string SeSpecGroup1 { get => fields.SeSpecGroup1[this]; set => fields.SeSpecGroup1[this] = value; }

    [DisplayName("Cd Spec Group1"), Column("K7231_cdSpecGroup1"), Size(3), Hidden]
    public string CdSpecGroup1 { get => fields.CdSpecGroup1[this]; set => fields.CdSpecGroup1[this] = value; }

    [DisplayName("Se Spec Group2"), Column("K7231_seSpecGroup2"), Size(3), Hidden]
    public string SeSpecGroup2 { get => fields.SeSpecGroup2[this]; set => fields.SeSpecGroup2[this] = value; }

    [DisplayName("Cd Spec Group2"), Column("K7231_cdSpecGroup2"), Size(3), Hidden]
    public string CdSpecGroup2 { get => fields.CdSpecGroup2[this]; set => fields.CdSpecGroup2[this] = value; }

    [DisplayName("Se Spec Group3"), Column("K7231_seSpecGroup3"), Size(3), Hidden]
    public string SeSpecGroup3 { get => fields.SeSpecGroup3[this]; set => fields.SeSpecGroup3[this] = value; }

    [DisplayName("Cd Spec Group3"), Column("K7231_cdSpecGroup3"), Size(3), Hidden]
    public string CdSpecGroup3 { get => fields.CdSpecGroup3[this]; set => fields.CdSpecGroup3[this] = value; }

    [DisplayName("Se Spec Group4"), Column("K7231_seSpecGroup4"), Size(3), Hidden]
    public string SeSpecGroup4 { get => fields.SeSpecGroup4[this]; set => fields.SeSpecGroup4[this] = value; }

    [DisplayName("Cd Spec Group4"), Column("K7231_cdSpecGroup4"), Size(3), Hidden]
    public string CdSpecGroup4 { get => fields.CdSpecGroup4[this]; set => fields.CdSpecGroup4[this] = value; }

    [DisplayName("Se Spec Group5"), Column("K7231_seSpecGroup5"), Size(3), Hidden]
    public string SeSpecGroup5 { get => fields.SeSpecGroup5[this]; set => fields.SeSpecGroup5[this] = value; }

    [DisplayName("Cd Spec Group5"), Column("K7231_cdSpecGroup5"), Size(3), Hidden]
    public string CdSpecGroup5 { get => fields.CdSpecGroup5[this]; set => fields.CdSpecGroup5[this] = value; }

    [DisplayName("Se Unit Material"), Column("K7231_seUnitMaterial"), Size(3), Hidden]
    public string SeUnitMaterial { get => fields.SeUnitMaterial[this]; set => fields.SeUnitMaterial[this] = value; }

    [DisplayName("Cd Unit Material"), Column("K7231_cdUnitMaterial"), Size(3), Hidden]
    public string CdUnitMaterial { get => fields.CdUnitMaterial[this]; set => fields.CdUnitMaterial[this] = value; }

    

    [DisplayName("Cd Unit Packing"), Column("K7231_cdUnitPacking"), Size(3), Hidden]
    public string CdUnitPacking { get => fields.CdUnitPacking[this]; set => fields.CdUnitPacking[this] = value; }

    [DisplayName("Se Tax"), Column("K7231_seTax"), Size(3), Hidden]
    public string SeTax { get => fields.SeTax[this]; set => fields.SeTax[this] = value; }

    [DisplayName("Cd Tax"), Column("K7231_cdTax"), Size(3), Hidden]
    public string CdTax { get => fields.CdTax[this]; set => fields.CdTax[this] = value; }

    [DisplayName("Per Tax Import"), Column("K7231_PerTaxImport"), Size(18), Scale(3)]
    public decimal? PerTaxImport { get => fields.PerTaxImport[this]; set => fields.PerTaxImport[this] = value; }

    [DisplayName("Per Tax Vat"), Column("K7231_PerTaxVAT"), Size(18), Scale(3)]
    public decimal? PerTaxVat { get => fields.PerTaxVat[this]; set => fields.PerTaxVat[this] = value; }

    

    [DisplayName("Qty Optimum"), Column("K7231_QtyOptimum"), Size(18), Scale(6)]
    public decimal? QtyOptimum { get => fields.QtyOptimum[this]; set => fields.QtyOptimum[this] = value; }

    [DisplayName("Day Optimum"), Column("K7231_DayOptimum"), Size(18), Scale(6)]
    public decimal? DayOptimum { get => fields.DayOptimum[this]; set => fields.DayOptimum[this] = value; }

    [DisplayName("Day Estimate"), Column("K7231_DayEstimate"), Size(18), Scale(3)]
    public decimal? DayEstimate { get => fields.DayEstimate[this]; set => fields.DayEstimate[this] = value; }

    [DisplayName("Price Material"), Column("K7231_PriceMaterial"), Size(18), Scale(6)]
    public decimal? PriceMaterial { get => fields.PriceMaterial[this]; set => fields.PriceMaterial[this] = value; }

    [DisplayName("Qty Moq"), Column("K7231_QtyMOQ"), Size(18), Scale(6)]
    public decimal? QtyMoq { get => fields.QtyMoq[this]; set => fields.QtyMoq[this] = value; }

    

    [DisplayName("Re Order Qty"), Column("K7231_ReOrderQty"), Size(18), Scale(3)]
    public decimal? ReOrderQty { get => fields.ReOrderQty[this]; set => fields.ReOrderQty[this] = value; }

    [DisplayName("Check Dev Rn D"), Column("K7231_CheckDevRnD"), Size(1)]
    public string CheckDevRnD { get => fields.CheckDevRnD[this]; set => fields.CheckDevRnD[this] = value; }

    [DisplayName("Status Material"), Column("K7231_StatusMaterial"), Size(1)]
    public string StatusMaterial { get => fields.StatusMaterial[this]; set => fields.StatusMaterial[this] = value; }

    [DisplayName("Bom Type"), Column("K7231_BOMType"), Size(1)]
    public string BomType { get => fields.BomType[this]; set => fields.BomType[this] = value; }

    [DisplayName("Apply Type"), Column("K7231_ApplyType"), Size(1)]
    public string ApplyType { get => fields.ApplyType[this]; set => fields.ApplyType[this] = value; }

    [DisplayName("Date Start"), Column("K7231_DateStart"), Size(8)]
    public string DateStart { get => fields.DateStart[this]; set => fields.DateStart[this] = value; }

    [DisplayName("Date Optimum"), Column("K7231_DateOptimum"), Size(8)]
    public string DateOptimum { get => fields.DateOptimum[this]; set => fields.DateOptimum[this] = value; }

    [DisplayName("Date Estimate"), Column("K7231_DateEstimate"), Size(8)]
    public string DateEstimate { get => fields.DateEstimate[this]; set => fields.DateEstimate[this] = value; }

    [DisplayName("Date In Bound"), Column("K7231_DateInBound"), Size(8)]
    public string DateInBound { get => fields.DateInBound[this]; set => fields.DateInBound[this] = value; }

    [DisplayName("Date Out Bound"), Column("K7231_DateOutBound"), Size(8)]
    public string DateOutBound { get => fields.DateOutBound[this]; set => fields.DateOutBound[this] = value; }

    [DisplayName("Supply Name"), Column("K7231_SupplyName"), Size(100)]
    public string SupplyName { get => fields.SupplyName[this]; set => fields.SupplyName[this] = value; }

    [DisplayName("Supply Code"), Column("K7231_SupplyCode"), Size(6)]
    public string SupplyCode { get => fields.SupplyCode[this]; set => fields.SupplyCode[this] = value; }

    [DisplayName("Sales Code"), Column("K7231_SalesCode"), Size(6)]
    public string SalesCode { get => fields.SalesCode[this]; set => fields.SalesCode[this] = value; }

    [DisplayName("Check1"), Column("K7231_Check1"), Size(20)]
    public string Check1 { get => fields.Check1[this]; set => fields.Check1[this] = value; }

    [DisplayName("Check2"), Column("K7231_Check2"), Size(20)]
    public string Check2 { get => fields.Check2[this]; set => fields.Check2[this] = value; }

    [DisplayName("Check3"), Column("K7231_Check3"), Size(20)]
    public string Check3 { get => fields.Check3[this]; set => fields.Check3[this] = value; }

    [DisplayName("Check4"), Column("K7231_Check4"), Size(20)]
    public string Check4 { get => fields.Check4[this]; set => fields.Check4[this] = value; }

    [DisplayName("Check5"), Column("K7231_Check5"), Size(20)]
    public string Check5 { get => fields.Check5[this]; set => fields.Check5[this] = value; }

    [DisplayName("Check6"), Column("K7231_Check6"), Size(10)]
    public string Check6 { get => fields.Check6[this]; set => fields.Check6[this] = value; }

    [DisplayName("Check7"), Column("K7231_Check7"), Size(10)]
    public string Check7 { get => fields.Check7[this]; set => fields.Check7[this] = value; }

    [DisplayName("Check8"), Column("K7231_Check8"), Size(10)]
    public string Check8 { get => fields.Check8[this]; set => fields.Check8[this] = value; }

    [DisplayName("Check9"), Column("K7231_Check9"), Size(10)]
    public string Check9 { get => fields.Check9[this]; set => fields.Check9[this] = value; }

    [DisplayName("Check10"), Column("K7231_Check10"), Size(10)]
    public string Check10 { get => fields.Check10[this]; set => fields.Check10[this] = value; }

    [DisplayName("Check Name1"), Column("K7231_CheckName1"), Size(20)]
    public string CheckName1 { get => fields.CheckName1[this]; set => fields.CheckName1[this] = value; }

    [DisplayName("Check Name2"), Column("K7231_CheckName2"), Size(20)]
    public string CheckName2 { get => fields.CheckName2[this]; set => fields.CheckName2[this] = value; }

    [DisplayName("Check Name3"), Column("K7231_CheckName3"), Size(20)]
    public string CheckName3 { get => fields.CheckName3[this]; set => fields.CheckName3[this] = value; }

    [DisplayName("Check Name4"), Column("K7231_CheckName4"), Size(20)]
    public string CheckName4 { get => fields.CheckName4[this]; set => fields.CheckName4[this] = value; }

    [DisplayName("Check Name5"), Column("K7231_CheckName5"), Size(20)]
    public string CheckName5 { get => fields.CheckName5[this]; set => fields.CheckName5[this] = value; }

    [DisplayName("Check Name6"), Column("K7231_CheckName6"), Size(20)]
    public string CheckName6 { get => fields.CheckName6[this]; set => fields.CheckName6[this] = value; }

    [DisplayName("Check Name7"), Column("K7231_CheckName7"), Size(20)]
    public string CheckName7 { get => fields.CheckName7[this]; set => fields.CheckName7[this] = value; }

    [DisplayName("Check Name8"), Column("K7231_CheckName8"), Size(20)]
    public string CheckName8 { get => fields.CheckName8[this]; set => fields.CheckName8[this] = value; }

    [DisplayName("Check Name9"), Column("K7231_CheckName9"), Size(20)]
    public string CheckName9 { get => fields.CheckName9[this]; set => fields.CheckName9[this] = value; }

    [DisplayName("Check Name10"), Column("K7231_CheckName10"), Size(20)]
    public string CheckName10 { get => fields.CheckName10[this]; set => fields.CheckName10[this] = value; }

    [DisplayName("A Code Material"), Column("K7231_ACodeMaterial"), Size(20)]
    public string ACodeMaterial { get => fields.ACodeMaterial[this]; set => fields.ACodeMaterial[this] = value; }

    [DisplayName("A Code Tax1"), Column("K7231_ACodeTax1"), Size(20)]
    public string ACodeTax1 { get => fields.ACodeTax1[this]; set => fields.ACodeTax1[this] = value; }

    [DisplayName("A Code Tax2"), Column("K7231_ACodeTax2"), Size(20)]
    public string ACodeTax2 { get => fields.ACodeTax2[this]; set => fields.ACodeTax2[this] = value; }

    [DisplayName("A Code Tax3"), Column("K7231_ACodeTax3"), Size(20)]
    public string ACodeTax3 { get => fields.ACodeTax3[this]; set => fields.ACodeTax3[this] = value; }

    [DisplayName("A Code Sales"), Column("K7231_ACodeSales"), Size(20)]
    public string ACodeSales { get => fields.ACodeSales[this]; set => fields.ACodeSales[this] = value; }

    [DisplayName("A Code Int Sales"), Column("K7231_ACodeIntSales"), Size(20)]
    public string ACodeIntSales { get => fields.ACodeIntSales[this]; set => fields.ACodeIntSales[this] = value; }

    [DisplayName("A Code Cogs"), Column("K7231_ACodeCOGS"), Size(20)]
    public string ACodeCogs { get => fields.ACodeCogs[this]; set => fields.ACodeCogs[this] = value; }

    [DisplayName("A Code Return"), Column("K7231_ACodeReturn"), Size(20)]
    public string ACodeReturn { get => fields.ACodeReturn[this]; set => fields.ACodeReturn[this] = value; }

    [DisplayName("A Code Discount"), Column("K7231_ACodeDiscount"), Size(20)]
    public string ACodeDiscount { get => fields.ACodeDiscount[this]; set => fields.ACodeDiscount[this] = value; }

    [DisplayName("A Code Wip"), Column("K7231_ACodeWIP"), Size(20)]
    public string ACodeWip { get => fields.ACodeWip[this]; set => fields.ACodeWip[this] = value; }

    [DisplayName("Check Inventory"), Column("K7231_CheckInventory"), Size(1)]
    public string CheckInventory { get => fields.CheckInventory[this]; set => fields.CheckInventory[this] = value; }

    [DisplayName("Check Position"), Column("K7231_CheckPosition"), Size(1)]
    public string CheckPosition { get => fields.CheckPosition[this]; set => fields.CheckPosition[this] = value; }

    [DisplayName("Check Lot No"), Column("K7231_CheckLotNo"), Size(1)]
    public string CheckLotNo { get => fields.CheckLotNo[this]; set => fields.CheckLotNo[this] = value; }

    [DisplayName("Check Price"), Column("K7231_CheckPrice"), Size(1)]
    public string CheckPrice { get => fields.CheckPrice[this]; set => fields.CheckPrice[this] = value; }

    [DisplayName("Se Tax1"), Column("K7231_seTax1"), Size(3), Hidden]
    public string SeTax1 { get => fields.SeTax1[this]; set => fields.SeTax1[this] = value; }

    [DisplayName("Cd Tax1"), Column("K7231_cdTax1"), Size(3), Hidden]
    public string CdTax1 { get => fields.CdTax1[this]; set => fields.CdTax1[this] = value; }

    [DisplayName("Per Tax1"), Column("K7231_PerTax1"), Size(18), Scale(3)]
    public decimal? PerTax1 { get => fields.PerTax1[this]; set => fields.PerTax1[this] = value; }

    [DisplayName("Se Tax2"), Column("K7231_seTax2"), Size(3), Hidden]
    public string SeTax2 { get => fields.SeTax2[this]; set => fields.SeTax2[this] = value; }

    [DisplayName("Cd Tax2"), Column("K7231_cdTax2"), Size(3), Hidden]
    public string CdTax2 { get => fields.CdTax2[this]; set => fields.CdTax2[this] = value; }

    [DisplayName("Per Tax2"), Column("K7231_PerTax2"), Size(18), Scale(3)]
    public decimal? PerTax2 { get => fields.PerTax2[this]; set => fields.PerTax2[this] = value; }

    [DisplayName("Se Tax3"), Column("K7231_seTax3"), Size(3), Hidden]
    public string SeTax3 { get => fields.SeTax3[this]; set => fields.SeTax3[this] = value; }

    [DisplayName("Cd Tax3"), Column("K7231_cdTax3"), Size(3), Hidden]
    public string CdTax3 { get => fields.CdTax3[this]; set => fields.CdTax3[this] = value; }

    [DisplayName("Per Tax3"), Column("K7231_PerTax3"), Size(18), Scale(3)]
    public decimal? PerTax3 { get => fields.PerTax3[this]; set => fields.PerTax3[this] = value; }

    [DisplayName("Se Tax Vat"), Column("K7231_seTaxVAT"), Size(3), Hidden]
    public string SeTaxVat { get => fields.SeTaxVat[this]; set => fields.SeTaxVat[this] = value; }

    [DisplayName("Cd Tax Vat"), Column("K7231_cdTaxVAT"), Size(3), Hidden]
    public string CdTaxVat { get => fields.CdTaxVat[this]; set => fields.CdTaxVat[this] = value; }

    [DisplayName("Se Tax Import"), Column("K7231_seTaxImport"), Size(3), Hidden]
    public string SeTaxImport { get => fields.SeTaxImport[this]; set => fields.SeTaxImport[this] = value; }

    [DisplayName("Cd Tax Import"), Column("K7231_cdTaxImport"), Size(3), Hidden]
    public string CdTaxImport { get => fields.CdTaxImport[this]; set => fields.CdTaxImport[this] = value; }

    [DisplayName("Se Tax Export"), Column("K7231_seTaxExport"), Size(3), Hidden]
    public string SeTaxExport { get => fields.SeTaxExport[this]; set => fields.SeTaxExport[this] = value; }

    [DisplayName("Cd Tax Export"), Column("K7231_cdTaxExport"), Size(3), Hidden]
    public string CdTaxExport { get => fields.CdTaxExport[this]; set => fields.CdTaxExport[this] = value; }

    [DisplayName("Se Tax Special"), Column("K7231_seTaxSpecial"), Size(3), Hidden]
    public string SeTaxSpecial { get => fields.SeTaxSpecial[this]; set => fields.SeTaxSpecial[this] = value; }

    [DisplayName("Cd Tax Special"), Column("K7231_cdTaxSpecial"), Size(3), Hidden]
    public string CdTaxSpecial { get => fields.CdTaxSpecial[this]; set => fields.CdTaxSpecial[this] = value; }

    [DisplayName("Se Acc Material"), Column("K7231_seAccMaterial"), Size(3), Hidden]
    public string SeAccMaterial { get => fields.SeAccMaterial[this]; set => fields.SeAccMaterial[this] = value; }

    [DisplayName("Cd Acc Material"), Column("K7231_cdAccMaterial"), Size(3), Hidden]
    public string CdAccMaterial { get => fields.CdAccMaterial[this]; set => fields.CdAccMaterial[this] = value; }

    [DisplayName("Se Acc Sales"), Column("K7231_seAccSales"), Size(3), Hidden]
    public string SeAccSales { get => fields.SeAccSales[this]; set => fields.SeAccSales[this] = value; }

    [DisplayName("Cd Acc Sales"), Column("K7231_cdAccSales"), Size(3), Hidden]
    public string CdAccSales { get => fields.CdAccSales[this]; set => fields.CdAccSales[this] = value; }

    [DisplayName("Se Acc Int Sales"), Column("K7231_seAccIntSales"), Size(3), Hidden]
    public string SeAccIntSales { get => fields.SeAccIntSales[this]; set => fields.SeAccIntSales[this] = value; }

    [DisplayName("Cd Acc Int Sales"), Column("K7231_cdAccIntSales"), Size(3), Hidden]
    public string CdAccIntSales { get => fields.CdAccIntSales[this]; set => fields.CdAccIntSales[this] = value; }

    [DisplayName("Se Acc Cogs"), Column("K7231_seAccCOGS"), Size(3), Hidden]
    public string SeAccCogs { get => fields.SeAccCogs[this]; set => fields.SeAccCogs[this] = value; }

    [DisplayName("Cd Acc Cogs"), Column("K7231_cdAccCOGS"), Size(3), Hidden]
    public string CdAccCogs { get => fields.CdAccCogs[this]; set => fields.CdAccCogs[this] = value; }

    [DisplayName("Se Acc Return"), Column("K7231_seAccReturn"), Size(3), Hidden]
    public string SeAccReturn { get => fields.SeAccReturn[this]; set => fields.SeAccReturn[this] = value; }

    [DisplayName("Cd Acc Return"), Column("K7231_cdAccReturn"), Size(3), Hidden]
    public string CdAccReturn { get => fields.CdAccReturn[this]; set => fields.CdAccReturn[this] = value; }

    [DisplayName("Se Acc Discount"), Column("K7231_seAccDiscount"), Size(3), Hidden]
    public string SeAccDiscount { get => fields.SeAccDiscount[this]; set => fields.SeAccDiscount[this] = value; }

    [DisplayName("Cd Acc Discount"), Column("K7231_cdAccDiscount"), Size(3), Hidden]
    public string CdAccDiscount { get => fields.CdAccDiscount[this]; set => fields.CdAccDiscount[this] = value; }

    [DisplayName("Se Acc Wip"), Column("K7231_seAccWIP"), Size(3), Hidden]
    public string SeAccWip { get => fields.SeAccWip[this]; set => fields.SeAccWip[this] = value; }

    [DisplayName("Cd Acc Wip"), Column("K7231_cdAccWIP"), Size(3), Hidden]
    public string CdAccWip { get => fields.CdAccWip[this]; set => fields.CdAccWip[this] = value; }

    

    [DisplayName("Date Update"), Column("K7231_DateUpdate"), Size(8), Hidden]
    public string DateUpdate { get => fields.DateUpdate[this]; set => fields.DateUpdate[this] = value; }

    [DisplayName("Incharge Insert"), Column("K7231_InchargeInsert"), Size(8), Hidden]
    public string InchargeInsert { get => fields.InchargeInsert[this]; set => fields.InchargeInsert[this] = value; }

    [DisplayName("Incharge Update"), Column("K7231_InchargeUpdate"), Size(8), Hidden]
    public string InchargeUpdate { get => fields.InchargeUpdate[this]; set => fields.InchargeUpdate[this] = value; }

    [DisplayName("Incharge Complete"), Column("K7231_InchargeComplete"), Size(8), Hidden]
    public string InchargeComplete { get => fields.InchargeComplete[this]; set => fields.InchargeComplete[this] = value; }

    [DisplayName("Incharge Cancel"), Column("K7231_InchargeCancel"), Size(8), Hidden]
    public string InchargeCancel { get => fields.InchargeCancel[this]; set => fields.InchargeCancel[this] = value; }

    [DisplayName("Incharge Approved"), Column("K7231_InchargeApproved"), Size(8), Hidden]
    public string InchargeApproved { get => fields.InchargeApproved[this]; set => fields.InchargeApproved[this] = value; }

    [DisplayName("Incharge Pending1"), Column("K7231_InchargePending1"), Size(8), Hidden]
    public string InchargePending1 { get => fields.InchargePending1[this]; set => fields.InchargePending1[this] = value; }

    [DisplayName("Incharge Pending2"), Column("K7231_InchargePending2"), Size(8), Hidden]
    public string InchargePending2 { get => fields.InchargePending2[this]; set => fields.InchargePending2[this] = value; }  

    [DisplayName("Date Deactive"), Column("K7231_DateDeactive"), Size(8), Hidden]
    public string DateDeactive { get => fields.DateDeactive[this]; set => fields.DateDeactive[this] = value; }

    [DisplayName("Check Active"), Column("K7231_CheckActive"), Size(1), Hidden]
    public string CheckActive { get => fields.CheckActive[this]; set => fields.CheckActive[this] = value; }

    [DisplayName("Date Complete"), Column("K7231_DateComplete"), Size(8), Hidden]
    public string DateComplete { get => fields.DateComplete[this]; set => fields.DateComplete[this] = value; }

    [DisplayName("Date Approved"), Column("K7231_DateApproved"), Size(8), Hidden]
    public string DateApproved { get => fields.DateApproved[this]; set => fields.DateApproved[this] = value; }

    [DisplayName("Date Cancel"), Column("K7231_DateCancel"), Size(8), Hidden]
    public string DateCancel { get => fields.DateCancel[this]; set => fields.DateCancel[this] = value; }

    [DisplayName("Date Pending1"), Column("K7231_DatePending1"), Size(8), Hidden]
    public string DatePending1 { get => fields.DatePending1[this]; set => fields.DatePending1[this] = value; }

    [DisplayName("Date Pending2"), Column("K7231_DatePending2"), Size(8), Hidden]
    public string DatePending2 { get => fields.DatePending2[this]; set => fields.DatePending2[this] = value; }

    [DisplayName("Check Sync"), Column("K7231_CheckSync"), Size(1), Hidden]
    public string CheckSync { get => fields.CheckSync[this]; set => fields.CheckSync[this] = value; }

    [DisplayName("Material Full Name"), Column("K7231_MaterialFullName"), Size(500), Hidden]
    public string MaterialFullName { get => fields.MaterialFullName[this]; set => fields.MaterialFullName[this] = value; }

    [DisplayName("Material Old Name"), Column("K7231_MaterialOldName"), Size(200), Hidden]
    public string MaterialOldName { get => fields.MaterialOldName[this]; set => fields.MaterialOldName[this] = value; }

    [DisplayName("Remark"), Column("K7231_Remark"), Size(500), Hidden]
    public string Remark { get => fields.Remark[this]; set => fields.Remark[this] = value; }

    [DisplayName("Se Site"), Column("K7231_seSite"), Size(3), NotNull, Hidden]
    public string SeSite { get => fields.SeSite[this]; set => fields.SeSite[this] = value; }

    [DisplayName("Cd Site"), Column("K7231_cdSite"), Size(3), NotNull, Hidden]
    public string CdSite { get => fields.CdSite[this]; set => fields.CdSite[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public StringField MaterialCode;
        public StringField MaterialName;
        public StringField MaterialPName;
        public StringField MaterialSimple;
        public StringField MaterialColor;
        public StringField SeImportGroup;
        public StringField CdImportGroup;
        public StringField Hscode;
        public StringField LogisticCodeSg;
        public StringField ImportCode;
        public StringField ImportName;
        public StringField Hscode1;
        public StringField ImportCode1;
        public StringField ImportName1;
        public StringField AccountCode;
        public StringField AccountName;
        public StringField OtherCode1;
        public StringField OtherCode2;
        public StringField DevelopmentCode;
        public StringField DevelopmentName;
        public StringField MaterialForeign1;
        public StringField MaterialForeign2;
        public StringField Width;
        public StringField Height;
        public StringField SizeName;
        public StringField CheckPrint;
        public StringField CheckSp;
        public StringField SeSpecial;
        public StringField CdSpecial;
        public StringField SizeRangeTool;
        public StringField CheckKindMaterial;
        public StringField CheckMarketType;
        public StringField SeUnitPrice;
        public StringField CdUnitPrice;
        public StringField DateExchangePrice;
        public DecimalField ExchangePrice;
        public DecimalField PriceUsd;
        public DecimalField PriceVnd;
        public StringField SeDepartment;
        public StringField CdDepartment;
        public StringField SeLargeGroupMaterial;
        public StringField CdLargeGroupMaterial;
        public StringField SeSemiGroupMaterial;
        public StringField CdSemiGroupMaterial;
        public StringField SeDetailGroupMaterial;
        public StringField CdDetailGroupMaterial;
        public StringField SeSpecGroup1;
        public StringField CdSpecGroup1;
        public StringField SeSpecGroup2;
        public StringField CdSpecGroup2;
        public StringField SeSpecGroup3;
        public StringField CdSpecGroup3;
        public StringField SeSpecGroup4;
        public StringField CdSpecGroup4;
        public StringField SeSpecGroup5;
        public StringField CdSpecGroup5;
        public StringField SeUnitMaterial;
        public StringField CdUnitMaterial;
        public StringField SeUnitPacking;
        public StringField CdUnitPacking;
        public StringField SeTax;
        public StringField CdTax;
        public DecimalField PerTaxImport;
        public DecimalField PerTaxVat;
        public DecimalField QtyBasic;
        public DecimalField QtyOptimum;
        public DecimalField DayOptimum;
        public DecimalField DayEstimate;
        public DecimalField PriceMaterial;
        public DecimalField QtyMoq;
        public DecimalField MaxInventory;
        public DecimalField MinInventory;
        public DecimalField ReOrderQty;
        public StringField CheckDevRnD;
        public StringField StatusMaterial;
        public StringField BomType;
        public StringField ApplyType;
        public StringField DateStart;
        public StringField DateOptimum;
        public StringField DateEstimate;
        public StringField DateInBound;
        public StringField DateOutBound;
        public StringField SupplyName;
        public StringField SupplyCode;
        public StringField SalesCode;
        public StringField Check1;
        public StringField Check2;
        public StringField Check3;
        public StringField Check4;
        public StringField Check5;
        public StringField Check6;
        public StringField Check7;
        public StringField Check8;
        public StringField Check9;
        public StringField Check10;
        public StringField CheckName1;
        public StringField CheckName2;
        public StringField CheckName3;
        public StringField CheckName4;
        public StringField CheckName5;
        public StringField CheckName6;
        public StringField CheckName7;
        public StringField CheckName8;
        public StringField CheckName9;
        public StringField CheckName10;
        public StringField ACodeMaterial;
        public StringField ACodeTax1;
        public StringField ACodeTax2;
        public StringField ACodeTax3;
        public StringField ACodeSales;
        public StringField ACodeIntSales;
        public StringField ACodeCogs;
        public StringField ACodeReturn;
        public StringField ACodeDiscount;
        public StringField ACodeWip;
        public StringField CheckInventory;
        public StringField CheckPosition;
        public StringField CheckLotNo;
        public StringField CheckPrice;
        public StringField SeTax1;
        public StringField CdTax1;
        public DecimalField PerTax1;
        public StringField SeTax2;
        public StringField CdTax2;
        public DecimalField PerTax2;
        public StringField SeTax3;
        public StringField CdTax3;
        public DecimalField PerTax3;
        public StringField SeTaxVat;
        public StringField CdTaxVat;
        public StringField SeTaxImport;
        public StringField CdTaxImport;
        public StringField SeTaxExport;
        public StringField CdTaxExport;
        public StringField SeTaxSpecial;
        public StringField CdTaxSpecial;
        public StringField SeAccMaterial;
        public StringField CdAccMaterial;
        public StringField SeAccSales;
        public StringField CdAccSales;
        public StringField SeAccIntSales;
        public StringField CdAccIntSales;
        public StringField SeAccCogs;
        public StringField CdAccCogs;
        public StringField SeAccReturn;
        public StringField CdAccReturn;
        public StringField SeAccDiscount;
        public StringField CdAccDiscount;
        public StringField SeAccWip;
        public StringField CdAccWip;
        public StringField DateInsert;
        public StringField DateUpdate;
        public StringField InchargeInsert;
        public StringField InchargeUpdate;
        public StringField InchargeComplete;
        public StringField InchargeCancel;
        public StringField InchargeApproved;
        public StringField InchargePending1;
        public StringField InchargePending2;
        public StringField CheckUse;
        public StringField DateActive;
        public StringField DateDeactive;
        public StringField CheckActive;
        public StringField DateComplete;
        public StringField DateApproved;
        public StringField DateCancel;
        public StringField DatePending1;
        public StringField DatePending2;
        public StringField CheckSync;
        public StringField MaterialFullName;
        public StringField MaterialOldName;
        public StringField Remark;
        public StringField SeSite;
        public StringField CdSite;

    }
}
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SerenePSM.Default;

[ConnectionKey("Default"), Module("Default"), TableName("PFK7106")]
[DisplayName("Danh mục sản phẩm-(Pfk7106)"), InstanceName("Pfk7106")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class Pfk7106Row : Row<Pfk7106Row.RowFields>, IIdRow, INameRow
{
    [DisplayName("Shoes Code"), Column("K7106_ShoesCode"), Size(6), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string ShoesCode { get => fields.ShoesCode[this]; set => fields.ShoesCode[this] = value; }

    [DisplayName("Shoes Code Base"), Column("K7106_ShoesCodeBase"), Size(6)]
    public string ShoesCodeBase { get => fields.ShoesCodeBase[this]; set => fields.ShoesCodeBase[this] = value; }

    [DisplayName("Customercode"), Column("K7106_Customercode"), Size(6), NotNull]
    public string Customercode { get => fields.Customercode[this]; set => fields.Customercode[this] = value; }

    [DisplayName("Back Color"), Column("K7106_BackColor"), Size(20)]
    public string BackColor { get => fields.BackColor[this]; set => fields.BackColor[this] = value; }

    [DisplayName("Cust Spec No"), Column("K7106_CustSpecNo"), Size(50)]
    public string CustSpecNo { get => fields.CustSpecNo[this]; set => fields.CustSpecNo[this] = value; }

    [DisplayName("Product Code"), Column("K7106_ProductCode"), Size(50)]
    public string ProductCode { get => fields.ProductCode[this]; set => fields.ProductCode[this] = value; }

    [DisplayName("Style"), Column("K7106_Style"), Size(100)]
    public string Style { get => fields.Style[this]; set => fields.Style[this] = value; }

    [DisplayName("Article"), Column("K7106_Article"), Size(100)]
    public string Article { get => fields.Article[this]; set => fields.Article[this] = value; }

    [DisplayName("Line"), Column("K7106_Line"), Size(100)]
    public string Line { get => fields.Line[this]; set => fields.Line[this] = value; }

    [DisplayName("Mcode"), Column("K7106_MCODE"), Size(50)]
    public string Mcode { get => fields.Mcode[this]; set => fields.Mcode[this] = value; }

    [DisplayName("Color Code"), Column("K7106_ColorCode"), Size(50)]
    public string ColorCode { get => fields.ColorCode[this]; set => fields.ColorCode[this] = value; }

    [DisplayName("Mcode Name"), Column("K7106_MCODEName"), Size(50)]
    public string McodeName { get => fields.McodeName[this]; set => fields.McodeName[this] = value; }

    [DisplayName("Color Name"), Column("K7106_ColorName"), Size(50)]
    public string ColorName { get => fields.ColorName[this]; set => fields.ColorName[this] = value; }

    [DisplayName("Ver All"), Column("K7106_VerALL"), Size(50)]
    public string VerAll { get => fields.VerAll[this]; set => fields.VerAll[this] = value; }

    [DisplayName("Ver Sam"), Column("K7106_VerSAM"), Size(5)]
    public string VerSam { get => fields.VerSam[this]; set => fields.VerSam[this] = value; }

    [DisplayName("Ver Bom"), Column("K7106_VerBOM"), Size(50)]
    public string VerBom { get => fields.VerBom[this]; set => fields.VerBom[this] = value; }

    [DisplayName("Ver Cbd"), Column("K7106_VerCBD"), Size(50)]
    public string VerCbd { get => fields.VerCbd[this]; set => fields.VerCbd[this] = value; }

    [DisplayName("Ver Rot"), Column("K7106_VerROT"), Size(50)]
    public string VerRot { get => fields.VerRot[this]; set => fields.VerRot[this] = value; }

    [DisplayName("Ver Job"), Column("K7106_VerJOB"), Size(50)]
    public string VerJob { get => fields.VerJob[this]; set => fields.VerJob[this] = value; }

    [DisplayName("Cust Spec No1"), Column("K7106_CustSpecNo1"), Size(50)]
    public string CustSpecNo1 { get => fields.CustSpecNo1[this]; set => fields.CustSpecNo1[this] = value; }

    [DisplayName("Se Product Type"), Column("K7106_seProductType"), Size(3)]
    public string SeProductType { get => fields.SeProductType[this]; set => fields.SeProductType[this] = value; }

    [DisplayName("Cd Product Type"), Column("K7106_cdProductType"), Size(3)]
    public string CdProductType { get => fields.CdProductType[this]; set => fields.CdProductType[this] = value; }

    [DisplayName("Se Product Size"), Column("K7106_seProductSize"), Size(3)]
    public string SeProductSize { get => fields.SeProductSize[this]; set => fields.SeProductSize[this] = value; }

    [DisplayName("Cd Product Size"), Column("K7106_cdProductSize"), Size(3)]
    public string CdProductSize { get => fields.CdProductSize[this]; set => fields.CdProductSize[this] = value; }

    [DisplayName("Se Spec State"), Column("K7106_seSpecState"), Size(3)]
    public string SeSpecState { get => fields.SeSpecState[this]; set => fields.SeSpecState[this] = value; }

    [DisplayName("Cd Spec State"), Column("K7106_cdSpecState"), Size(3)]
    public string CdSpecState { get => fields.CdSpecState[this]; set => fields.CdSpecState[this] = value; }

    [DisplayName("Szno"), Column("K7106_Szno"), Size(2)]
    public string Szno { get => fields.Szno[this]; set => fields.Szno[this] = value; }

    [DisplayName("Specitic Size"), Column("K7106_SpeciticSize"), Size(4)]
    public string SpeciticSize { get => fields.SpeciticSize[this]; set => fields.SpeciticSize[this] = value; }

    [DisplayName("Se Season"), Column("K7106_seSeason"), Size(3)]
    public string SeSeason { get => fields.SeSeason[this]; set => fields.SeSeason[this] = value; }

    [DisplayName("Cd Season"), Column("K7106_cdSeason"), Size(3)]
    public string CdSeason { get => fields.CdSeason[this]; set => fields.CdSeason[this] = value; }

    [DisplayName("Se Gender"), Column("K7106_seGender"), Size(3)]
    public string SeGender { get => fields.SeGender[this]; set => fields.SeGender[this] = value; }

    [DisplayName("Cd Gender"), Column("K7106_cdGender"), Size(3)]
    public string CdGender { get => fields.CdGender[this]; set => fields.CdGender[this] = value; }

    [DisplayName("Last Code"), Column("K7106_LastCode"), Size(6)]
    public string LastCode { get => fields.LastCode[this]; set => fields.LastCode[this] = value; }

    [DisplayName("Last Width"), Column("K7106_LastWidth"), Size(50)]
    public string LastWidth { get => fields.LastWidth[this]; set => fields.LastWidth[this] = value; }

    [DisplayName("Last Qty"), Column("K7106_LastQty"), Size(6)]
    public decimal? LastQty { get => fields.LastQty[this]; set => fields.LastQty[this] = value; }

    [DisplayName("Mold Code"), Column("K7106_MoldCode"), Size(6)]
    public string MoldCode { get => fields.MoldCode[this]; set => fields.MoldCode[this] = value; }

    [DisplayName("Mold Spec"), Column("K7106_MoldSpec"), Size(50)]
    public string MoldSpec { get => fields.MoldSpec[this]; set => fields.MoldSpec[this] = value; }

    [DisplayName("Mold Qty"), Column("K7106_MoldQty"), Size(6)]
    public decimal? MoldQty { get => fields.MoldQty[this]; set => fields.MoldQty[this] = value; }

    [DisplayName("Qty Average"), Column("K7106_QtyAverage"), Size(18)]
    public decimal? QtyAverage { get => fields.QtyAverage[this]; set => fields.QtyAverage[this] = value; }

    [DisplayName("Qty Average1"), Column("K7106_QtyAverage1"), Size(18)]
    public decimal? QtyAverage1 { get => fields.QtyAverage1[this]; set => fields.QtyAverage1[this] = value; }

    [DisplayName("Qty Average2"), Column("K7106_QtyAverage2"), Size(18)]
    public decimal? QtyAverage2 { get => fields.QtyAverage2[this]; set => fields.QtyAverage2[this] = value; }

    [DisplayName("Qty Average3"), Column("K7106_QtyAverage3"), Size(18)]
    public decimal? QtyAverage3 { get => fields.QtyAverage3[this]; set => fields.QtyAverage3[this] = value; }

    [DisplayName("Cutting Die Code"), Column("K7106_CuttingDieCode"), Size(6)]
    public string CuttingDieCode { get => fields.CuttingDieCode[this]; set => fields.CuttingDieCode[this] = value; }

    [DisplayName("Texon Code"), Column("K7106_TexonCode"), Size(6)]
    public string TexonCode { get => fields.TexonCode[this]; set => fields.TexonCode[this] = value; }

    [DisplayName("Texon Color"), Column("K7106_TexonColor"), Size(50)]
    public string TexonColor { get => fields.TexonColor[this]; set => fields.TexonColor[this] = value; }

    [DisplayName("Insole Code"), Column("K7106_InsoleCode"), Size(6)]
    public string InsoleCode { get => fields.InsoleCode[this]; set => fields.InsoleCode[this] = value; }

    [DisplayName("Insole Color"), Column("K7106_InsoleColor"), Size(50)]
    public string InsoleColor { get => fields.InsoleColor[this]; set => fields.InsoleColor[this] = value; }

    [DisplayName("Outsole Code"), Column("K7106_OutsoleCode"), Size(6)]
    public string OutsoleCode { get => fields.OutsoleCode[this]; set => fields.OutsoleCode[this] = value; }

    [DisplayName("Outsole Color"), Column("K7106_OutsoleColor"), Size(200)]
    public string OutsoleColor { get => fields.OutsoleColor[this]; set => fields.OutsoleColor[this] = value; }

    [DisplayName("Outsole Color Code"), Column("K7106_OutsoleColorCode"), Size(200)]
    public string OutsoleColorCode { get => fields.OutsoleColorCode[this]; set => fields.OutsoleColorCode[this] = value; }

    [DisplayName("Mid Sole Code"), Column("K7106_MidSoleCode"), Size(6)]
    public string MidSoleCode { get => fields.MidSoleCode[this]; set => fields.MidSoleCode[this] = value; }

    [DisplayName("Midsole Color"), Column("K7106_MidsoleColor"), Size(200)]
    public string MidsoleColor { get => fields.MidsoleColor[this]; set => fields.MidsoleColor[this] = value; }

    [DisplayName("Logo Code"), Column("K7106_LogoCode"), Size(6)]
    public string LogoCode { get => fields.LogoCode[this]; set => fields.LogoCode[this] = value; }

    [DisplayName("Logo Color"), Column("K7106_LogoColor"), Size(50)]
    public string LogoColor { get => fields.LogoColor[this]; set => fields.LogoColor[this] = value; }

    [DisplayName("Logo Color Code"), Column("K7106_LogoColorCode"), Size(50)]
    public string LogoColorCode { get => fields.LogoColorCode[this]; set => fields.LogoColorCode[this] = value; }

    [DisplayName("Size Range"), Column("K7106_SizeRange"), Size(6)]
    public string SizeRange { get => fields.SizeRange[this]; set => fields.SizeRange[this] = value; }

    [DisplayName("Note0"), Column("K7106_Note0"), Size(50)]
    public string Note0 { get => fields.Note0[this]; set => fields.Note0[this] = value; }

    [DisplayName("Note1"), Column("K7106_Note1"), Size(50)]
    public string Note1 { get => fields.Note1[this]; set => fields.Note1[this] = value; }

    [DisplayName("Note2"), Column("K7106_Note2"), Size(50)]
    public string Note2 { get => fields.Note2[this]; set => fields.Note2[this] = value; }

    [DisplayName("Note3"), Column("K7106_Note3"), Size(50)]
    public string Note3 { get => fields.Note3[this]; set => fields.Note3[this] = value; }

    [DisplayName("Note4"), Column("K7106_Note4"), Size(50)]
    public string Note4 { get => fields.Note4[this]; set => fields.Note4[this] = value; }

    [DisplayName("Note5"), Column("K7106_Note5"), Size(50)]
    public string Note5 { get => fields.Note5[this]; set => fields.Note5[this] = value; }

    [DisplayName("Note6"), Column("K7106_Note6"), Size(50)]
    public string Note6 { get => fields.Note6[this]; set => fields.Note6[this] = value; }

    [DisplayName("Note7"), Column("K7106_Note7"), Size(50)]
    public string Note7 { get => fields.Note7[this]; set => fields.Note7[this] = value; }

    [DisplayName("Note8"), Column("K7106_Note8"), Size(50)]
    public string Note8 { get => fields.Note8[this]; set => fields.Note8[this] = value; }

    [DisplayName("Note9"), Column("K7106_Note9"), Size(50)]
    public string Note9 { get => fields.Note9[this]; set => fields.Note9[this] = value; }

    [DisplayName("Note10"), Column("K7106_Note10"), Size(50)]
    public string Note10 { get => fields.Note10[this]; set => fields.Note10[this] = value; }

    [DisplayName("Date Exchange Price"), Column("K7106_DateExchangePrice"), Size(8)]
    public string DateExchangePrice { get => fields.DateExchangePrice[this]; set => fields.DateExchangePrice[this] = value; }

    [DisplayName("Exchange Price"), Column("K7106_ExchangePrice"), Size(18), Scale(3)]
    public decimal? ExchangePrice { get => fields.ExchangePrice[this]; set => fields.ExchangePrice[this] = value; }

    [DisplayName("Price Usd"), Column("K7106_PriceUSD"), Size(18), Scale(4)]
    public decimal? PriceUsd { get => fields.PriceUsd[this]; set => fields.PriceUsd[this] = value; }

    [DisplayName("Price Vnd"), Column("K7106_PriceVND"), Size(18), Scale(4)]
    public decimal? PriceVnd { get => fields.PriceVnd[this]; set => fields.PriceVnd[this] = value; }

    [DisplayName("Date Lable1"), Column("K7106_DateLable1"), Size(8)]
    public string DateLable1 { get => fields.DateLable1[this]; set => fields.DateLable1[this] = value; }

    [DisplayName("Date Lable2"), Column("K7106_DateLable2"), Size(8)]
    public string DateLable2 { get => fields.DateLable2[this]; set => fields.DateLable2[this] = value; }

    [DisplayName("Date Lable3"), Column("K7106_DateLable3"), Size(8)]
    public string DateLable3 { get => fields.DateLable3[this]; set => fields.DateLable3[this] = value; }

    [DisplayName("Date Insert"), Column("K7106_DateInsert"), Size(8)]
    public string DateInsert { get => fields.DateInsert[this]; set => fields.DateInsert[this] = value; }

    [DisplayName("Date Update"), Column("K7106_DateUpdate"), Size(8)]
    public string DateUpdate { get => fields.DateUpdate[this]; set => fields.DateUpdate[this] = value; }

    [DisplayName("Incharge Designer"), Column("K7106_InchargeDesigner"), Size(8)]
    public string InchargeDesigner { get => fields.InchargeDesigner[this]; set => fields.InchargeDesigner[this] = value; }

    [DisplayName("Incharge Step1"), Column("K7106_InchargeStep1"), Size(8)]
    public string InchargeStep1 { get => fields.InchargeStep1[this]; set => fields.InchargeStep1[this] = value; }

    [DisplayName("Incharge Step2"), Column("K7106_InchargeStep2"), Size(8)]
    public string InchargeStep2 { get => fields.InchargeStep2[this]; set => fields.InchargeStep2[this] = value; }

    [DisplayName("Incharge Step3"), Column("K7106_InchargeStep3"), Size(8)]
    public string InchargeStep3 { get => fields.InchargeStep3[this]; set => fields.InchargeStep3[this] = value; }

    [DisplayName("Incharge Insert"), Column("K7106_InchargeInsert"), Size(8)]
    public string InchargeInsert { get => fields.InchargeInsert[this]; set => fields.InchargeInsert[this] = value; }

    [DisplayName("Incharge Update"), Column("K7106_InchargeUpdate"), Size(8)]
    public string InchargeUpdate { get => fields.InchargeUpdate[this]; set => fields.InchargeUpdate[this] = value; }

    [DisplayName("Incharge Cbd I"), Column("K7106_InchargeCBD_I"), Size(8)]
    public string InchargeCbdI { get => fields.InchargeCbdI[this]; set => fields.InchargeCbdI[this] = value; }

    [DisplayName("Incharge Cbd U"), Column("K7106_InchargeCBD_U"), Size(8)]
    public string InchargeCbdU { get => fields.InchargeCbdU[this]; set => fields.InchargeCbdU[this] = value; }

    [DisplayName("Incharge Bom I"), Column("K7106_InchargeBOM_I"), Size(8)]
    public string InchargeBomI { get => fields.InchargeBomI[this]; set => fields.InchargeBomI[this] = value; }

    [DisplayName("Incharge Bom U"), Column("K7106_InchargeBOM_U"), Size(8)]
    public string InchargeBomU { get => fields.InchargeBomU[this]; set => fields.InchargeBomU[this] = value; }

    [DisplayName("Incharge Con I"), Column("K7106_InchargeCON_I"), Size(8)]
    public string InchargeConI { get => fields.InchargeConI[this]; set => fields.InchargeConI[this] = value; }

    [DisplayName("Incharge Con U"), Column("K7106_InchargeCON_U"), Size(8)]
    public string InchargeConU { get => fields.InchargeConU[this]; set => fields.InchargeConU[this] = value; }

    [DisplayName("Check Parent"), Column("K7106_CheckParent"), Size(1)]
    public string CheckParent { get => fields.CheckParent[this]; set => fields.CheckParent[this] = value; }

    [DisplayName("Shoes Parent"), Column("K7106_ShoesParent"), Size(6)]
    public string ShoesParent { get => fields.ShoesParent[this]; set => fields.ShoesParent[this] = value; }

    [DisplayName("Check Use"), Column("K7106_CheckUse"), Size(1)]
    public string CheckUse { get => fields.CheckUse[this]; set => fields.CheckUse[this] = value; }

    [DisplayName("Time Insert"), Column("K7106_TimeInsert"), Size(14)]
    public string TimeInsert { get => fields.TimeInsert[this]; set => fields.TimeInsert[this] = value; }

    [DisplayName("Time Update"), Column("K7106_TimeUpdate"), Size(14)]
    public string TimeUpdate { get => fields.TimeUpdate[this]; set => fields.TimeUpdate[this] = value; }

    [DisplayName("Check Complete"), Column("K7106_CheckComplete"), Size(1)]
    public string CheckComplete { get => fields.CheckComplete[this]; set => fields.CheckComplete[this] = value; }

    [DisplayName("Incharge Complete"), Column("K7106_InchargeComplete"), Size(8)]
    public string InchargeComplete { get => fields.InchargeComplete[this]; set => fields.InchargeComplete[this] = value; }

    [DisplayName("Date Complete"), Column("K7106_DateComplete"), Size(8)]
    public string DateComplete { get => fields.DateComplete[this]; set => fields.DateComplete[this] = value; }

    [DisplayName("Incharge Complete Un"), Column("K7106_InchargeCompleteUn"), Size(8)]
    public string InchargeCompleteUn { get => fields.InchargeCompleteUn[this]; set => fields.InchargeCompleteUn[this] = value; }

    [DisplayName("Date Complete Un"), Column("K7106_DateCompleteUn"), Size(8)]
    public string DateCompleteUn { get => fields.DateCompleteUn[this]; set => fields.DateCompleteUn[this] = value; }

    [DisplayName("Time Complete"), Column("K7106_TimeComplete"), Size(20)]
    public string TimeComplete { get => fields.TimeComplete[this]; set => fields.TimeComplete[this] = value; }

    [DisplayName("Check Bom"), Column("K7106_CheckBOM"), Size(1)]
    public string CheckBom { get => fields.CheckBom[this]; set => fields.CheckBom[this] = value; }

    [DisplayName("Incharge Bom Com"), Column("K7106_InchargeBOMCom"), Size(8)]
    public string InchargeBomCom { get => fields.InchargeBomCom[this]; set => fields.InchargeBomCom[this] = value; }

    [DisplayName("Date Bom Com"), Column("K7106_DateBOMCom"), Size(8)]
    public string DateBomCom { get => fields.DateBomCom[this]; set => fields.DateBomCom[this] = value; }

    [DisplayName("Incharge Bom Un"), Column("K7106_InchargeBOMUn"), Size(8)]
    public string InchargeBomUn { get => fields.InchargeBomUn[this]; set => fields.InchargeBomUn[this] = value; }

    [DisplayName("Date Bom Un"), Column("K7106_DateBOMUn"), Size(8)]
    public string DateBomUn { get => fields.DateBomUn[this]; set => fields.DateBomUn[this] = value; }

    [DisplayName("Time Bom Com"), Column("K7106_TimeBOMCom"), Size(20)]
    public string TimeBomCom { get => fields.TimeBomCom[this]; set => fields.TimeBomCom[this] = value; }

    [DisplayName("Check Cbd"), Column("K7106_CheckCBD"), Size(1)]
    public string CheckCbd { get => fields.CheckCbd[this]; set => fields.CheckCbd[this] = value; }

    [DisplayName("Incharge Cbd Com"), Column("K7106_InchargeCBDCom"), Size(8)]
    public string InchargeCbdCom { get => fields.InchargeCbdCom[this]; set => fields.InchargeCbdCom[this] = value; }

    [DisplayName("Date Cbd Com"), Column("K7106_DateCBDCom"), Size(8)]
    public string DateCbdCom { get => fields.DateCbdCom[this]; set => fields.DateCbdCom[this] = value; }

    [DisplayName("Incharge Cbd Un"), Column("K7106_InchargeCBDUn"), Size(8)]
    public string InchargeCbdUn { get => fields.InchargeCbdUn[this]; set => fields.InchargeCbdUn[this] = value; }

    [DisplayName("Date Cbd Un"), Column("K7106_DateCBDUn"), Size(8)]
    public string DateCbdUn { get => fields.DateCbdUn[this]; set => fields.DateCbdUn[this] = value; }

    [DisplayName("Time Cbd Com"), Column("K7106_TimeCBDCom"), Size(20)]
    public string TimeCbdCom { get => fields.TimeCbdCom[this]; set => fields.TimeCbdCom[this] = value; }

    [DisplayName("Check Con"), Column("K7106_CheckCON"), Size(1)]
    public string CheckCon { get => fields.CheckCon[this]; set => fields.CheckCon[this] = value; }

    [DisplayName("Incharge Con Com"), Column("K7106_InchargeCONCom"), Size(8)]
    public string InchargeConCom { get => fields.InchargeConCom[this]; set => fields.InchargeConCom[this] = value; }

    [DisplayName("Date Con Com"), Column("K7106_DateCONCom"), Size(8)]
    public string DateConCom { get => fields.DateConCom[this]; set => fields.DateConCom[this] = value; }

    [DisplayName("Incharge Con Un"), Column("K7106_InchargeCONUn"), Size(8)]
    public string InchargeConUn { get => fields.InchargeConUn[this]; set => fields.InchargeConUn[this] = value; }

    [DisplayName("Date Con Un"), Column("K7106_DateCONUn"), Size(8)]
    public string DateConUn { get => fields.DateConUn[this]; set => fields.DateConUn[this] = value; }

    [DisplayName("Time Con Com"), Column("K7106_TimeCONCom"), Size(20)]
    public string TimeConCom { get => fields.TimeConCom[this]; set => fields.TimeConCom[this] = value; }

    [DisplayName("Check Fb"), Column("K7106_CheckFB"), Size(1)]
    public string CheckFb { get => fields.CheckFb[this]; set => fields.CheckFb[this] = value; }

    [DisplayName("Check Same Mold"), Column("K7106_CheckSameMold"), Size(1)]
    public string CheckSameMold { get => fields.CheckSameMold[this]; set => fields.CheckSameMold[this] = value; }

    [DisplayName("Remark"), Column("K7106_Remark"), Size(100), NotNull]
    public string Remark { get => fields.Remark[this]; set => fields.Remark[this] = value; }

    [DisplayName("Se Site"), Column("K7106_seSite"), Size(3), NotNull]
    public string SeSite { get => fields.SeSite[this]; set => fields.SeSite[this] = value; }

    [DisplayName("Cd Site"), Column("K7106_cdSite"), Size(3), NotNull]
    public string CdSite { get => fields.CdSite[this]; set => fields.CdSite[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public StringField ShoesCode;
        public StringField ShoesCodeBase;
        public StringField Customercode;
        public StringField BackColor;
        public StringField CustSpecNo;
        public StringField ProductCode;
        public StringField Style;
        public StringField Article;
        public StringField Line;
        public StringField Mcode;
        public StringField ColorCode;
        public StringField McodeName;
        public StringField ColorName;
        public StringField VerAll;
        public StringField VerSam;
        public StringField VerBom;
        public StringField VerCbd;
        public StringField VerRot;
        public StringField VerJob;
        public StringField CustSpecNo1;
        public StringField SeProductType;
        public StringField CdProductType;
        public StringField SeProductSize;
        public StringField CdProductSize;
        public StringField SeSpecState;
        public StringField CdSpecState;
        public StringField Szno;
        public StringField SpeciticSize;
        public StringField SeSeason;
        public StringField CdSeason;
        public StringField SeGender;
        public StringField CdGender;
        public StringField LastCode;
        public StringField LastWidth;
        public DecimalField LastQty;
        public StringField MoldCode;
        public StringField MoldSpec;
        public DecimalField MoldQty;
        public DecimalField QtyAverage;
        public DecimalField QtyAverage1;
        public DecimalField QtyAverage2;
        public DecimalField QtyAverage3;
        public StringField CuttingDieCode;
        public StringField TexonCode;
        public StringField TexonColor;
        public StringField InsoleCode;
        public StringField InsoleColor;
        public StringField OutsoleCode;
        public StringField OutsoleColor;
        public StringField OutsoleColorCode;
        public StringField MidSoleCode;
        public StringField MidsoleColor;
        public StringField LogoCode;
        public StringField LogoColor;
        public StringField LogoColorCode;
        public StringField SizeRange;
        public StringField Note0;
        public StringField Note1;
        public StringField Note2;
        public StringField Note3;
        public StringField Note4;
        public StringField Note5;
        public StringField Note6;
        public StringField Note7;
        public StringField Note8;
        public StringField Note9;
        public StringField Note10;
        public StringField DateExchangePrice;
        public DecimalField ExchangePrice;
        public DecimalField PriceUsd;
        public DecimalField PriceVnd;
        public StringField DateLable1;
        public StringField DateLable2;
        public StringField DateLable3;
        public StringField DateInsert;
        public StringField DateUpdate;
        public StringField InchargeDesigner;
        public StringField InchargeStep1;
        public StringField InchargeStep2;
        public StringField InchargeStep3;
        public StringField InchargeInsert;
        public StringField InchargeUpdate;
        public StringField InchargeCbdI;
        public StringField InchargeCbdU;
        public StringField InchargeBomI;
        public StringField InchargeBomU;
        public StringField InchargeConI;
        public StringField InchargeConU;
        public StringField CheckParent;
        public StringField ShoesParent;
        public StringField CheckUse;
        public StringField TimeInsert;
        public StringField TimeUpdate;
        public StringField CheckComplete;
        public StringField InchargeComplete;
        public StringField DateComplete;
        public StringField InchargeCompleteUn;
        public StringField DateCompleteUn;
        public StringField TimeComplete;
        public StringField CheckBom;
        public StringField InchargeBomCom;
        public StringField DateBomCom;
        public StringField InchargeBomUn;
        public StringField DateBomUn;
        public StringField TimeBomCom;
        public StringField CheckCbd;
        public StringField InchargeCbdCom;
        public StringField DateCbdCom;
        public StringField InchargeCbdUn;
        public StringField DateCbdUn;
        public StringField TimeCbdCom;
        public StringField CheckCon;
        public StringField InchargeConCom;
        public StringField DateConCom;
        public StringField InchargeConUn;
        public StringField DateConUn;
        public StringField TimeConCom;
        public StringField CheckFb;
        public StringField CheckSameMold;
        public StringField Remark;
        public StringField SeSite;
        public StringField CdSite;

    }
}
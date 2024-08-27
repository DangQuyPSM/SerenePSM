using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SerenePSM.Default;

[ConnectionKey("Default"), Module("Default"), TableName("PFK7103")]
[DisplayName("Pfk7103"), InstanceName("Pfk7103")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class Pfk7103Row : Row<Pfk7103Row.RowFields>, IIdRow, INameRow
{
    [DisplayName("Autokey"), Column("K7103_Autokey"), Size(18), Identity, IdProperty]
    public decimal? Autokey { get => fields.Autokey[this]; set => fields.Autokey[this] = value; }

    [DisplayName("Pre Fix"), Column("K7103_PreFix"), Size(5), QuickSearch, NameProperty]
    public string PreFix { get => fields.PreFix[this]; set => fields.PreFix[this] = value; }

    [DisplayName("Type Code"), Column("K7103_TypeCode"), Size(6)]
    public string TypeCode { get => fields.TypeCode[this]; set => fields.TypeCode[this] = value; }

    [DisplayName("Se Type Code"), Column("K7103_seTypeCode"), Size(3)]
    public string SeTypeCode { get => fields.SeTypeCode[this]; set => fields.SeTypeCode[this] = value; }

    [DisplayName("Cd Type Code"), Column("K7103_cdTypeCode"), Size(3)]
    public string CdTypeCode { get => fields.CdTypeCode[this]; set => fields.CdTypeCode[this] = value; }

    [DisplayName("Se Component Type"), Column("K7103_seComponentType"), Size(3)]
    public string SeComponentType { get => fields.SeComponentType[this]; set => fields.SeComponentType[this] = value; }

    [DisplayName("Cd Component Type"), Column("K7103_cdComponentType"), Size(3)]
    public string CdComponentType { get => fields.CdComponentType[this]; set => fields.CdComponentType[this] = value; }

    [DisplayName("Type Name"), Column("K7103_TypeName"), Size(50)]
    public string TypeName { get => fields.TypeName[this]; set => fields.TypeName[this] = value; }

    [DisplayName("Type Name Relation"), Column("K7103_TypeNameRelation"), Size(50)]
    public string TypeNameRelation { get => fields.TypeNameRelation[this]; set => fields.TypeNameRelation[this] = value; }

    [DisplayName("Type Simple Name"), Column("K7103_TypeSimpleName"), Size(20)]
    public string TypeSimpleName { get => fields.TypeSimpleName[this]; set => fields.TypeSimpleName[this] = value; }

    [DisplayName("Customer Code"), Column("K7103_CustomerCode"), Size(6)]
    public string CustomerCode { get => fields.CustomerCode[this]; set => fields.CustomerCode[this] = value; }

    [DisplayName("Value Type1"), Column("K7103_ValueType1"), Size(1)]
    public string ValueType1 { get => fields.ValueType1[this]; set => fields.ValueType1[this] = value; }

    [DisplayName("Qty Batch S"), Column("K7103_QtyBatchS"), Size(3)]
    public decimal? QtyBatchS { get => fields.QtyBatchS[this]; set => fields.QtyBatchS[this] = value; }

    [DisplayName("Qty Day"), Column("K7103_QtyDay"), Size(5)]
    public decimal? QtyDay { get => fields.QtyDay[this]; set => fields.QtyDay[this] = value; }

    [DisplayName("Qty Day S"), Column("K7103_QtyDayS"), Size(5)]
    public decimal? QtyDayS { get => fields.QtyDayS[this]; set => fields.QtyDayS[this] = value; }

    [DisplayName("Qty Man"), Column("K7103_QtyMan"), Size(5)]
    public decimal? QtyMan { get => fields.QtyMan[this]; set => fields.QtyMan[this] = value; }

    [DisplayName("Amt Allowance"), Column("K7103_AmtAllowance"), Size(5)]
    public decimal? AmtAllowance { get => fields.AmtAllowance[this]; set => fields.AmtAllowance[this] = value; }

    [DisplayName("Standard"), Column("K7103_Standard"), Size(20)]
    public string Standard { get => fields.Standard[this]; set => fields.Standard[this] = value; }

    [DisplayName("Standard1"), Column("K7103_Standard1"), Size(20)]
    public string Standard1 { get => fields.Standard1[this]; set => fields.Standard1[this] = value; }

    [DisplayName("Standard2"), Column("K7103_Standard2"), Size(20)]
    public string Standard2 { get => fields.Standard2[this]; set => fields.Standard2[this] = value; }

    [DisplayName("Standard3"), Column("K7103_Standard3"), Size(20)]
    public string Standard3 { get => fields.Standard3[this]; set => fields.Standard3[this] = value; }

    [DisplayName("Standard4"), Column("K7103_Standard4"), Size(20)]
    public string Standard4 { get => fields.Standard4[this]; set => fields.Standard4[this] = value; }

    [DisplayName("Standard5"), Column("K7103_Standard5"), Size(20)]
    public string Standard5 { get => fields.Standard5[this]; set => fields.Standard5[this] = value; }

    [DisplayName("Date Insert"), Column("K7103_DateInsert"), Size(8)]
    public string DateInsert { get => fields.DateInsert[this]; set => fields.DateInsert[this] = value; }

    [DisplayName("Date Update"), Column("K7103_DateUpdate"), Size(8)]
    public string DateUpdate { get => fields.DateUpdate[this]; set => fields.DateUpdate[this] = value; }

    [DisplayName("Incharge Insert"), Column("K7103_InchargeInsert"), Size(8)]
    public string InchargeInsert { get => fields.InchargeInsert[this]; set => fields.InchargeInsert[this] = value; }

    [DisplayName("Incharge Update"), Column("K7103_InchargeUpdate"), Size(8)]
    public string InchargeUpdate { get => fields.InchargeUpdate[this]; set => fields.InchargeUpdate[this] = value; }

    [DisplayName("Check Use"), Column("K7103_CheckUse"), Size(1)]
    public string CheckUse { get => fields.CheckUse[this]; set => fields.CheckUse[this] = value; }

    [DisplayName("Check Complete"), Column("K7103_CheckComplete"), Size(1)]
    public string CheckComplete { get => fields.CheckComplete[this]; set => fields.CheckComplete[this] = value; }

    [DisplayName("Remark"), Column("K7103_Remark"), Size(50)]
    public string Remark { get => fields.Remark[this]; set => fields.Remark[this] = value; }

    [DisplayName("Se Site"), Column("K7103_seSite"), Size(3), NotNull]
    public string SeSite { get => fields.SeSite[this]; set => fields.SeSite[this] = value; }

    [DisplayName("Cd Site"), Column("K7103_cdSite"), Size(3), NotNull]
    public string CdSite { get => fields.CdSite[this]; set => fields.CdSite[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public DecimalField Autokey;
        public StringField PreFix;
        public StringField TypeCode;
        public StringField SeTypeCode;
        public StringField CdTypeCode;
        public StringField SeComponentType;
        public StringField CdComponentType;
        public StringField TypeName;
        public StringField TypeNameRelation;
        public StringField TypeSimpleName;
        public StringField CustomerCode;
        public StringField ValueType1;
        public DecimalField QtyBatchS;
        public DecimalField QtyDay;
        public DecimalField QtyDayS;
        public DecimalField QtyMan;
        public DecimalField AmtAllowance;
        public StringField Standard;
        public StringField Standard1;
        public StringField Standard2;
        public StringField Standard3;
        public StringField Standard4;
        public StringField Standard5;
        public StringField DateInsert;
        public StringField DateUpdate;
        public StringField InchargeInsert;
        public StringField InchargeUpdate;
        public StringField CheckUse;
        public StringField CheckComplete;
        public StringField Remark;
        public StringField SeSite;
        public StringField CdSite;

    }
}
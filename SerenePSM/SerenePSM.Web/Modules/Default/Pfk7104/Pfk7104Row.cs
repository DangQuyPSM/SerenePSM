using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SerenePSM.Default;

[ConnectionKey("Default"), Module("Default"), TableName("PFK7104")]
[DisplayName("Pfk7104"), InstanceName("Pfk7104")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class Pfk7104Row : Row<Pfk7104Row.RowFields>, IIdRow, INameRow
{
    [DisplayName("Size Range"), Column("K7104_SizeRange"), Size(6), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string SizeRange { get => fields.SizeRange[this]; set => fields.SizeRange[this] = value; }

    [DisplayName("Se Size Group"), Column("K7104_seSizeGroup"), Size(3)]
    public string SeSizeGroup { get => fields.SeSizeGroup[this]; set => fields.SeSizeGroup[this] = value; }

    [DisplayName("Cd Size Group"), Column("K7104_cdSizeGroup"), Size(3)]
    public string CdSizeGroup { get => fields.CdSizeGroup[this]; set => fields.CdSizeGroup[this] = value; }

    [DisplayName("Customer Code"), Column("K7104_CustomerCode"), Size(6)]
    public string CustomerCode { get => fields.CustomerCode[this]; set => fields.CustomerCode[this] = value; }

    [DisplayName("Size Range Name"), Column("K7104_SizeRangeName"), Size(50)]
    public string SizeRangeName { get => fields.SizeRangeName[this]; set => fields.SizeRangeName[this] = value; }

    [DisplayName("Size Range Simple Name"), Column("K7104_SizeRangeSimpleName"), Size(50)]
    public string SizeRangeSimpleName { get => fields.SizeRangeSimpleName[this]; set => fields.SizeRangeSimpleName[this] = value; }

    [DisplayName("Se Gender"), Column("K7104_seGender"), Size(3)]
    public string SeGender { get => fields.SeGender[this]; set => fields.SeGender[this] = value; }

    [DisplayName("Cd Gender"), Column("K7104_cdGender"), Size(3)]
    public string CdGender { get => fields.CdGender[this]; set => fields.CdGender[this] = value; }

    [DisplayName("Se Season"), Column("K7104_seSeason"), Size(3)]
    public string SeSeason { get => fields.SeSeason[this]; set => fields.SeSeason[this] = value; }

    [DisplayName("Cd Season"), Column("K7104_cdSeason"), Size(3)]
    public string CdSeason { get => fields.CdSeason[this]; set => fields.CdSeason[this] = value; }

    [DisplayName("Size Average01"), Column("K7104_SizeAverage01"), Size(4)]
    public string SizeAverage01 { get => fields.SizeAverage01[this]; set => fields.SizeAverage01[this] = value; }

    [DisplayName("Size Average02"), Column("K7104_SizeAverage02"), Size(4)]
    public string SizeAverage02 { get => fields.SizeAverage02[this]; set => fields.SizeAverage02[this] = value; }

    [DisplayName("Size Average03"), Column("K7104_SizeAverage03"), Size(4)]
    public string SizeAverage03 { get => fields.SizeAverage03[this]; set => fields.SizeAverage03[this] = value; }

    [DisplayName("Size Average04"), Column("K7104_SizeAverage04"), Size(4)]
    public string SizeAverage04 { get => fields.SizeAverage04[this]; set => fields.SizeAverage04[this] = value; }

    [DisplayName("Size Average05"), Column("K7104_SizeAverage05"), Size(4)]
    public string SizeAverage05 { get => fields.SizeAverage05[this]; set => fields.SizeAverage05[this] = value; }

    [DisplayName("Size01"), Column("K7104_Size01"), Size(4)]
    public string Size01 { get => fields.Size01[this]; set => fields.Size01[this] = value; }

    [DisplayName("Size02"), Column("K7104_Size02"), Size(4)]
    public string Size02 { get => fields.Size02[this]; set => fields.Size02[this] = value; }

    [DisplayName("Size03"), Column("K7104_Size03"), Size(4)]
    public string Size03 { get => fields.Size03[this]; set => fields.Size03[this] = value; }

    [DisplayName("Size04"), Column("K7104_Size04"), Size(4)]
    public string Size04 { get => fields.Size04[this]; set => fields.Size04[this] = value; }

    [DisplayName("Size05"), Column("K7104_Size05"), Size(4)]
    public string Size05 { get => fields.Size05[this]; set => fields.Size05[this] = value; }

    [DisplayName("Size06"), Column("K7104_Size06"), Size(4)]
    public string Size06 { get => fields.Size06[this]; set => fields.Size06[this] = value; }

    [DisplayName("Size07"), Column("K7104_Size07"), Size(4)]
    public string Size07 { get => fields.Size07[this]; set => fields.Size07[this] = value; }

    [DisplayName("Size08"), Column("K7104_Size08"), Size(4)]
    public string Size08 { get => fields.Size08[this]; set => fields.Size08[this] = value; }

    [DisplayName("Size09"), Column("K7104_Size09"), Size(4)]
    public string Size09 { get => fields.Size09[this]; set => fields.Size09[this] = value; }

    [DisplayName("Size10"), Column("K7104_Size10"), Size(4)]
    public string Size10 { get => fields.Size10[this]; set => fields.Size10[this] = value; }

    [DisplayName("Size11"), Column("K7104_Size11"), Size(4)]
    public string Size11 { get => fields.Size11[this]; set => fields.Size11[this] = value; }

    [DisplayName("Size12"), Column("K7104_Size12"), Size(4)]
    public string Size12 { get => fields.Size12[this]; set => fields.Size12[this] = value; }

    [DisplayName("Size13"), Column("K7104_Size13"), Size(4)]
    public string Size13 { get => fields.Size13[this]; set => fields.Size13[this] = value; }

    [DisplayName("Size14"), Column("K7104_Size14"), Size(4)]
    public string Size14 { get => fields.Size14[this]; set => fields.Size14[this] = value; }

    [DisplayName("Size15"), Column("K7104_Size15"), Size(4)]
    public string Size15 { get => fields.Size15[this]; set => fields.Size15[this] = value; }

    [DisplayName("Size16"), Column("K7104_Size16"), Size(4)]
    public string Size16 { get => fields.Size16[this]; set => fields.Size16[this] = value; }

    [DisplayName("Size17"), Column("K7104_Size17"), Size(4)]
    public string Size17 { get => fields.Size17[this]; set => fields.Size17[this] = value; }

    [DisplayName("Size18"), Column("K7104_Size18"), Size(4)]
    public string Size18 { get => fields.Size18[this]; set => fields.Size18[this] = value; }

    [DisplayName("Size19"), Column("K7104_Size19"), Size(4)]
    public string Size19 { get => fields.Size19[this]; set => fields.Size19[this] = value; }

    [DisplayName("Size20"), Column("K7104_Size20"), Size(4)]
    public string Size20 { get => fields.Size20[this]; set => fields.Size20[this] = value; }

    [DisplayName("Size21"), Column("K7104_Size21"), Size(4)]
    public string Size21 { get => fields.Size21[this]; set => fields.Size21[this] = value; }

    [DisplayName("Size22"), Column("K7104_Size22"), Size(4)]
    public string Size22 { get => fields.Size22[this]; set => fields.Size22[this] = value; }

    [DisplayName("Size23"), Column("K7104_Size23"), Size(4)]
    public string Size23 { get => fields.Size23[this]; set => fields.Size23[this] = value; }

    [DisplayName("Size24"), Column("K7104_Size24"), Size(4)]
    public string Size24 { get => fields.Size24[this]; set => fields.Size24[this] = value; }

    [DisplayName("Size25"), Column("K7104_Size25"), Size(4)]
    public string Size25 { get => fields.Size25[this]; set => fields.Size25[this] = value; }

    [DisplayName("Size26"), Column("K7104_Size26"), Size(4)]
    public string Size26 { get => fields.Size26[this]; set => fields.Size26[this] = value; }

    [DisplayName("Size27"), Column("K7104_Size27"), Size(4)]
    public string Size27 { get => fields.Size27[this]; set => fields.Size27[this] = value; }

    [DisplayName("Size28"), Column("K7104_Size28"), Size(4)]
    public string Size28 { get => fields.Size28[this]; set => fields.Size28[this] = value; }

    [DisplayName("Size29"), Column("K7104_Size29"), Size(4)]
    public string Size29 { get => fields.Size29[this]; set => fields.Size29[this] = value; }

    [DisplayName("Size30"), Column("K7104_Size30"), Size(4)]
    public string Size30 { get => fields.Size30[this]; set => fields.Size30[this] = value; }

    [DisplayName("Date Insert"), Column("K7104_DateInsert"), Size(8)]
    public string DateInsert { get => fields.DateInsert[this]; set => fields.DateInsert[this] = value; }

    [DisplayName("Date Update"), Column("K7104_DateUpdate"), Size(8)]
    public string DateUpdate { get => fields.DateUpdate[this]; set => fields.DateUpdate[this] = value; }

    [DisplayName("Incharge Insert"), Column("K7104_InchargeInsert"), Size(8)]
    public string InchargeInsert { get => fields.InchargeInsert[this]; set => fields.InchargeInsert[this] = value; }

    [DisplayName("Incharge Update"), Column("K7104_InchargeUpdate"), Size(8)]
    public string InchargeUpdate { get => fields.InchargeUpdate[this]; set => fields.InchargeUpdate[this] = value; }

    [DisplayName("Check Use"), Column("K7104_CheckUse"), Size(1)]
    public string CheckUse { get => fields.CheckUse[this]; set => fields.CheckUse[this] = value; }

    [DisplayName("Check Complete"), Column("K7104_CheckComplete"), Size(1)]
    public string CheckComplete { get => fields.CheckComplete[this]; set => fields.CheckComplete[this] = value; }

    [DisplayName("Remark"), Column("K7104_Remark"), Size(50)]
    public string Remark { get => fields.Remark[this]; set => fields.Remark[this] = value; }

    [DisplayName("Se Site"), Column("K7104_seSite"), Size(3), NotNull]
    public string SeSite { get => fields.SeSite[this]; set => fields.SeSite[this] = value; }

    [DisplayName("Cd Site"), Column("K7104_cdSite"), Size(3), NotNull]
    public string CdSite { get => fields.CdSite[this]; set => fields.CdSite[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public StringField SizeRange;
        public StringField SeSizeGroup;
        public StringField CdSizeGroup;
        public StringField CustomerCode;
        public StringField SizeRangeName;
        public StringField SizeRangeSimpleName;
        public StringField SeGender;
        public StringField CdGender;
        public StringField SeSeason;
        public StringField CdSeason;
        public StringField SizeAverage01;
        public StringField SizeAverage02;
        public StringField SizeAverage03;
        public StringField SizeAverage04;
        public StringField SizeAverage05;
        public StringField Size01;
        public StringField Size02;
        public StringField Size03;
        public StringField Size04;
        public StringField Size05;
        public StringField Size06;
        public StringField Size07;
        public StringField Size08;
        public StringField Size09;
        public StringField Size10;
        public StringField Size11;
        public StringField Size12;
        public StringField Size13;
        public StringField Size14;
        public StringField Size15;
        public StringField Size16;
        public StringField Size17;
        public StringField Size18;
        public StringField Size19;
        public StringField Size20;
        public StringField Size21;
        public StringField Size22;
        public StringField Size23;
        public StringField Size24;
        public StringField Size25;
        public StringField Size26;
        public StringField Size27;
        public StringField Size28;
        public StringField Size29;
        public StringField Size30;
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
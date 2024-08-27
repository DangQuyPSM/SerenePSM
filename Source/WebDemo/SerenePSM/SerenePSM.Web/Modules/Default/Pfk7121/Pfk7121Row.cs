using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SerenePSM.Default;

[ConnectionKey("Default"), Module("Default"), TableName("PFK7121")]
[DisplayName("Danh mục màu-(Pfk7121)"), InstanceName("Pfk7121")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class Pfk7121Row : Row<Pfk7121Row.RowFields>, IIdRow, INameRow
{
    [DisplayName("Mã màu"), Column("K7121_ColorCode"), Size(6), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string ColorCode { get => fields.ColorCode[this]; set => fields.ColorCode[this] = value; }

    [DisplayName("Tên màu"), Column("K7121_ColorName"), Size(200)]
    public string ColorName { get => fields.ColorName[this]; set => fields.ColorName[this] = value; }

    [DisplayName("Màu gốc cơ bản"), Column("K7121_ColorNameS1"), Size(200)]
    public string ColorNameS1 { get => fields.ColorNameS1[this]; set => fields.ColorNameS1[this] = value; }

    [DisplayName("Danh mục màu"), Column("K7121_cdColorCategory"), Size(3)]
    public string CdColorCategory { get => fields.CdColorCategory[this]; set => fields.CdColorCategory[this] = value; }

    [DisplayName("Vị trí màu"), Column("K7121_ColorPosition"), Size(50)]
    public string ColorPosition { get => fields.ColorPosition[this]; set => fields.ColorPosition[this] = value; }

    [DisplayName("Khách hàng"), Column("K7121_CustomerCode"), Size(6)]
    public string CustomerCode { get => fields.CustomerCode[this]; set => fields.CustomerCode[this] = value; }

    [DisplayName("Sử dụng"), Column("K7121_CheckUse"), Size(1)]

    [BooleanEditor, CheckboxFormatter]
    public bool? CheckUse
    {
        get => fields.CheckUse[this] == "1";
        set => fields.CheckUse[this] = value == true ? "1" : "0";
    }

    [DisplayName("Ghi chú"), Column("K7121_Remark"), Size(100)]
    public string Remark { get => fields.Remark[this]; set => fields.Remark[this] = value; }

    [DisplayName("Color Name S2"), Column("K7121_ColorNameS2"), Size(200)]
    public string ColorNameS2 { get => fields.ColorNameS2[this]; set => fields.ColorNameS2[this] = value; }

    [DisplayName("Color Name Simple"), Column("K7121_ColorNameSimple"), Size(20)]
    public string ColorNameSimple { get => fields.ColorNameSimple[this]; set => fields.ColorNameSimple[this] = value; }

    

    [DisplayName("Se Color Base"), Column("K7121_seColorBase"), Size(3)]
    public string SeColorBase { get => fields.SeColorBase[this]; set => fields.SeColorBase[this] = value; }

    [DisplayName("Cd Color Base"), Column("K7121_cdColorBase"), Size(3)]
    public string CdColorBase { get => fields.CdColorBase[this]; set => fields.CdColorBase[this] = value; }

    [DisplayName("Se Color Category"), Column("K7121_seColorCategory"), Size(3)]
    public string SeColorCategory { get => fields.SeColorCategory[this]; set => fields.SeColorCategory[this] = value; }

    

    

    [DisplayName("Check Base"), Column("K7121_CheckBase"), Size(1)]
    public string CheckBase { get => fields.CheckBase[this]; set => fields.CheckBase[this] = value; }

    

    [DisplayName("Date Insert"), Column("K7121_DateInsert"), Size(8)]
    public string DateInsert { get => fields.DateInsert[this]; set => fields.DateInsert[this] = value; }

    [DisplayName("Date Update"), Column("K7121_DateUpdate"), Size(8)]
    public string DateUpdate { get => fields.DateUpdate[this]; set => fields.DateUpdate[this] = value; }

    [DisplayName("Incharge Insert"), Column("K7121_InchargeInsert"), Size(8)]
    public string InchargeInsert { get => fields.InchargeInsert[this]; set => fields.InchargeInsert[this] = value; }

    [DisplayName("Incharge Update"), Column("K7121_InchargeUpdate"), Size(8)]
    public string InchargeUpdate { get => fields.InchargeUpdate[this]; set => fields.InchargeUpdate[this] = value; }

    

    [DisplayName("Se Site"), Column("K7121_seSite"), Size(3), NotNull]
    public string SeSite { get => fields.SeSite[this]; set => fields.SeSite[this] = value; }

    [DisplayName("Cd Site"), Column("K7121_cdSite"), Size(3), NotNull]
    public string CdSite { get => fields.CdSite[this]; set => fields.CdSite[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public StringField ColorCode;
        public StringField ColorName;
        public StringField ColorNameS1;
        public StringField ColorNameS2;
        public StringField ColorNameSimple;
        public StringField CustomerCode;
        public StringField SeColorBase;
        public StringField CdColorBase;
        public StringField SeColorCategory;
        public StringField CdColorCategory;
        public StringField ColorPosition;
        public StringField CheckBase;
        public StringField CheckUse;
        public StringField DateInsert;
        public StringField DateUpdate;
        public StringField InchargeInsert;
        public StringField InchargeUpdate;
        public StringField Remark;
        public StringField SeSite;
        public StringField CdSite;

    }
}
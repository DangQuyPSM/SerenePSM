using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;


namespace SerenePSM.Default;

[ConnectionKey("Default"), Module("Default"), TableName("PFK7171")]
[DisplayName("Danh mục tổng hợp-(Pfk7171)"), InstanceName("Pfk7171")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]


public sealed class Pfk7171Row : Row<Pfk7171Row.RowFields>, IIdRow, INameRow
{
    [LookupEditor(typeof(Pfk7171FilteredLookup), InplaceAdd = true, DialogType = "Default.Pfk7171")]
    [DisplayName("Basic Code"), Column("K7171_BasicCode"), Size(3), NotNull, QuickSearch, IdProperty]
    public string BasicCode { get => fields.BasicCode[this]; set => fields.BasicCode[this] = value; }

    [DisplayName("Basic Name"), Column("K7171_BasicName"), Size(250), NotNull, NameProperty]
    public string BasicName { get => fields.BasicName[this]; set => fields.BasicName[this] = value; }

    //[DisplayName("Basic Sel"), Column("K7171_BasicSel"), Size(3), PrimaryKey, NotNull, Hidden]
    //public string BasicSel { get => fields.BasicSel[this]; set => fields.BasicSel[this] = value; }

    [DisplayName("Basic Sel"), Column("K7171_BasicSel"), Size(3), PrimaryKey, NotNull]
    public string K7171_BasicSel
    {
        get => fields.K7171_BasicSel[this];
        set => fields.K7171_BasicSel[this] = value;
    }


    [DisplayName("Name Hlp Button"), Column("K7171_NameHLPButton"), Size(50)]
    public string NameHlpButton { get => fields.NameHlpButton[this]; set => fields.NameHlpButton[this] = value; }

    [DisplayName("Display Seq"), Column("K7171_DisplaySeq"), Size(18), NotNull]
    public decimal? DisplaySeq { get => fields.DisplaySeq[this]; set => fields.DisplaySeq[this] = value; }

    [DisplayName("Development Code"), Column("K7171_DevelopmentCode"), Size(50), NotNull]
    public string DevelopmentCode { get => fields.DevelopmentCode[this]; set => fields.DevelopmentCode[this] = value; }

    [DisplayName("Se Basic Master"), Column("K7171_seBasicMaster"), Size(3), NotNull]
    public string SeBasicMaster { get => fields.SeBasicMaster[this]; set => fields.SeBasicMaster[this] = value; }

    [DisplayName("Cd Basic Master"), Column("K7171_cdBasicMaster"), Size(3), NotNull]
    public string CdBasicMaster { get => fields.CdBasicMaster[this]; set => fields.CdBasicMaster[this] = value; }




    [DisplayName("Name Simply"), Column("K7171_NameSimply"), Size(100), NotNull]
    public string NameSimply { get => fields.NameSimply[this]; set => fields.NameSimply[this] = value; }

    [DisplayName("Foreign Name1"), Column("K7171_ForeignName1"), Size(100), NotNull]
    public string ForeignName1 { get => fields.ForeignName1[this]; set => fields.ForeignName1[this] = value; }

    [DisplayName("Foreign Name2"), Column("K7171_ForeignName2"), Size(100), NotNull]
    public string ForeignName2 { get => fields.ForeignName2[this]; set => fields.ForeignName2[this] = value; }

    [DisplayName("Check1"), Column("K7171_Check1"), Size(1), NotNull]
    public string Check1 { get => fields.Check1[this]; set => fields.Check1[this] = value; }

    [DisplayName("Check2"), Column("K7171_Check2"), Size(1), NotNull]
    public string Check2 { get => fields.Check2[this]; set => fields.Check2[this] = value; }

    [DisplayName("Check3"), Column("K7171_Check3"), Size(1), NotNull]
    public string Check3 { get => fields.Check3[this]; set => fields.Check3[this] = value; }

    [DisplayName("Check4"), Column("K7171_Check4"), Size(1), NotNull]
    public string Check4 { get => fields.Check4[this]; set => fields.Check4[this] = value; }

    [DisplayName("Check5"), Column("K7171_Check5"), Size(1), NotNull]
    public string Check5 { get => fields.Check5[this]; set => fields.Check5[this] = value; }

    [DisplayName("Check6"), Column("K7171_Check6"), Size(50), NotNull]
    public string Check6 { get => fields.Check6[this]; set => fields.Check6[this] = value; }

    [DisplayName("Check7"), Column("K7171_Check7"), Size(50), NotNull]
    public string Check7 { get => fields.Check7[this]; set => fields.Check7[this] = value; }

    [DisplayName("Check8"), Column("K7171_Check8"), Size(50), NotNull]
    public string Check8 { get => fields.Check8[this]; set => fields.Check8[this] = value; }

    [DisplayName("Check9"), Column("K7171_Check9"), Size(50), NotNull]
    public string Check9 { get => fields.Check9[this]; set => fields.Check9[this] = value; }

    [DisplayName("Check10"), Column("K7171_Check10"), Size(50), NotNull]
    public string Check10 { get => fields.Check10[this]; set => fields.Check10[this] = value; }

    [DisplayName("Check Name1"), Column("K7171_CheckName1"), Size(500), NotNull]
    public string CheckName1 { get => fields.CheckName1[this]; set => fields.CheckName1[this] = value; }

    [DisplayName("Check Name2"), Column("K7171_CheckName2"), Size(500), NotNull]
    public string CheckName2 { get => fields.CheckName2[this]; set => fields.CheckName2[this] = value; }

    [DisplayName("Check Name3"), Column("K7171_CheckName3"), Size(500), NotNull]
    public string CheckName3 { get => fields.CheckName3[this]; set => fields.CheckName3[this] = value; }

    [DisplayName("Check Name4"), Column("K7171_CheckName4"), Size(500), NotNull]
    public string CheckName4 { get => fields.CheckName4[this]; set => fields.CheckName4[this] = value; }

    [DisplayName("Check Name5"), Column("K7171_CheckName5"), Size(500), NotNull]
    public string CheckName5 { get => fields.CheckName5[this]; set => fields.CheckName5[this] = value; }

    [DisplayName("Check Name6"), Column("K7171_CheckName6"), Size(500), NotNull]
    public string CheckName6 { get => fields.CheckName6[this]; set => fields.CheckName6[this] = value; }

    [DisplayName("Check Name7"), Column("K7171_CheckName7"), Size(500), NotNull]
    public string CheckName7 { get => fields.CheckName7[this]; set => fields.CheckName7[this] = value; }

    [DisplayName("Check Name8"), Column("K7171_CheckName8"), Size(500), NotNull]
    public string CheckName8 { get => fields.CheckName8[this]; set => fields.CheckName8[this] = value; }

    [DisplayName("Check Name9"), Column("K7171_CheckName9"), Size(500), NotNull]
    public string CheckName9 { get => fields.CheckName9[this]; set => fields.CheckName9[this] = value; }

    [DisplayName("Check Name10"), Column("K7171_CheckName10"), Size(500), NotNull]
    public string CheckName10 { get => fields.CheckName10[this]; set => fields.CheckName10[this] = value; }

    [DisplayName("Incharge Insert"), Column("K7171_InchargeInsert"), Size(8)]
    public string InchargeInsert { get => fields.InchargeInsert[this]; set => fields.InchargeInsert[this] = value; }

    [DisplayName("Incharge Update"), Column("K7171_InchargeUpdate"), Size(8)]
    public string InchargeUpdate { get => fields.InchargeUpdate[this]; set => fields.InchargeUpdate[this] = value; }

    [DisplayName("Date Insert"), Column("K7171_DateInsert"), Size(8), NotNull]
    public string DateInsert { get => fields.DateInsert[this]; set => fields.DateInsert[this] = value; }

    [DisplayName("Date Update"), Column("K7171_DateUpdate"), Size(8), NotNull]
    public string DateUpdate { get => fields.DateUpdate[this]; set => fields.DateUpdate[this] = value; }

    [DisplayName("Time Insert"), Column("K7171_TimeInsert"), Size(14), NotNull]
    public string TimeInsert { get => fields.TimeInsert[this]; set => fields.TimeInsert[this] = value; }

    [DisplayName("Time Update"), Column("K7171_TimeUpdate"), Size(14), NotNull]
    public string TimeUpdate { get => fields.TimeUpdate[this]; set => fields.TimeUpdate[this] = value; }

    [DisplayName("Time Last"), Column("K7171_TimeLast"), Size(14), NotNull]
    public string TimeLast { get => fields.TimeLast[this]; set => fields.TimeLast[this] = value; }

    [DisplayName("Check Sync"), Column("K7171_CheckSync"), Size(1)]
    public string CheckSync { get => fields.CheckSync[this]; set => fields.CheckSync[this] = value; }

    [DisplayName("Check Use"), Column("K7171_CheckUse"), Size(1), NotNull]
    public string CheckUse { get => fields.CheckUse[this]; set => fields.CheckUse[this] = value; }

    [DisplayName("Table Acc"), Column("K7171_TableACC"), Size(20)]
    public string TableAcc { get => fields.TableAcc[this]; set => fields.TableAcc[this] = value; }

    [DisplayName("Type Dm"), Column("K7171_TypeDM"), Size(1)]
    public string TypeDm { get => fields.TypeDm[this]; set => fields.TypeDm[this] = value; }

    [DisplayName("Key Dm"), Column("K7171_KeyDM"), Size(50)]
    public string KeyDm { get => fields.KeyDm[this]; set => fields.KeyDm[this] = value; }

    [DisplayName("Value Dm"), Column("K7171_ValueDM"), Size(50)]
    public string ValueDm { get => fields.ValueDm[this]; set => fields.ValueDm[this] = value; }

    [DisplayName("Remark"), Column("K7171_Remark"), Size(300), NotNull]
    public string Remark { get => fields.Remark[this]; set => fields.Remark[this] = value; }

    [DisplayName("Se Site"), Column("K7171_seSite"), Size(3), NotNull]
    public string SeSite { get => fields.SeSite[this]; set => fields.SeSite[this] = value; }

    [DisplayName("Cd Site"), Column("K7171_cdSite"), Size(3), NotNull]
    public string CdSite { get => fields.CdSite[this]; set => fields.CdSite[this] = value; }

    public class RowFields : RowFieldsBase
    {
        
        public int UniqueId { get; set; }
        
        public StringField BasicCode;
        public StringField K7171_BasicSel;
        public StringField NameHlpButton;
        public DecimalField DisplaySeq;
        public StringField DevelopmentCode;
        public StringField SeBasicMaster;
        public StringField CdBasicMaster;
        public StringField BasicName;
        public StringField NameSimply;
        public StringField ForeignName1;
        public StringField ForeignName2;
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
        public StringField InchargeInsert;
        public StringField InchargeUpdate;
        public StringField DateInsert;
        public StringField DateUpdate;
        public StringField TimeInsert;
        public StringField TimeUpdate;
        public StringField TimeLast;
        public StringField CheckSync;
        public StringField CheckUse;
        public StringField TableAcc;
        public StringField TypeDm;
        public StringField KeyDm;
        public StringField ValueDm;
        public StringField Remark;
        public StringField SeSite;
        public StringField CdSite;

    }
}
[LookupScript("Default.Pfk7171FilteredLookup")]
public sealed class Pfk7171FilteredLookup : RowLookupScript<Pfk7171Row>
{
    public Pfk7171FilteredLookup(ISqlConnections sqlConnections)
        : base(sqlConnections)
    {
        IdField = Pfk7171Row.Fields.BasicCode.PropertyName;
        TextField = Pfk7171Row.Fields.BasicName.PropertyName;
    }

    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);
        var fld = Pfk7171Row.Fields;

        query.Distinct(true)
             .Select(fld.BasicCode)  // Ensure this matches the field name
             .Select(fld.BasicName)
             .Where(fld.K7171_BasicSel == "000"); // Use correct field name
    }



    protected override void ApplyOrder(SqlQuery query)
    {
        base.ApplyOrder(query);
        var fld = Pfk7171Row.Fields;

        // Apply ordering
        query.OrderBy(fld.BasicCode);
    }


    protected override List<Pfk7171Row> GetItems()
    {
        var items = base.GetItems() as IEnumerable<Pfk7171Row>;

        if (items != null)
        {
            var distinctItems = items
                .GroupBy(x => new { x.BasicCode, x.BasicName })
                .Select(g => g.First())
                .ToList();

            return distinctItems;
        }

        return new List<Pfk7171Row>();
    }
}





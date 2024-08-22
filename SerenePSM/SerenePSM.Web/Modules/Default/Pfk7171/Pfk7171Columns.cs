using Serenity.ComponentModel;
using System.ComponentModel;

namespace SerenePSM.Default.Columns;

[ColumnsScript("Default.Pfk7171")]
[BasedOnRow(typeof(Pfk7171Row), CheckNames = true)]
public class Pfk7171Columns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]

    [Width(100), QuickFilter]

    
    public string BasicCode { get; set; }

    public string K7171_BasicSel { get; set; }

    public string BasicName { get; set; }

    
    public string NameHlpButton { get; set; }
    public decimal DisplaySeq { get; set; }
    public string DevelopmentCode { get; set; }
    public string SeBasicMaster { get; set; }
    public string CdBasicMaster { get; set; }


    public string NameSimply { get; set; }
    public string ForeignName1 { get; set; }
    public string ForeignName2 { get; set; }
    public string Check1 { get; set; }
    public string Check2 { get; set; }
    public string Check3 { get; set; }
    public string Check4 { get; set; }
    public string Check5 { get; set; }
    public string Check6 { get; set; }
    public string Check7 { get; set; }
    public string Check8 { get; set; }
    public string Check9 { get; set; }
    public string Check10 { get; set; }
    public string CheckName1 { get; set; }
    public string CheckName2 { get; set; }
    public string CheckName3 { get; set; }
    public string CheckName4 { get; set; }
    public string CheckName5 { get; set; }
    public string CheckName6 { get; set; }
    public string CheckName7 { get; set; }
    public string CheckName8 { get; set; }
    public string CheckName9 { get; set; }
    public string CheckName10 { get; set; }
    public string InchargeInsert { get; set; }
    public string InchargeUpdate { get; set; }
    public string DateInsert { get; set; }
    public string DateUpdate { get; set; }
    public string TimeInsert { get; set; }
    public string TimeUpdate { get; set; }
    public string TimeLast { get; set; }
    public string CheckSync { get; set; }
    public string CheckUse { get; set; }
    public string TableAcc { get; set; }
    public string TypeDm { get; set; }
    public string KeyDm { get; set; }
    public string ValueDm { get; set; }
    public string Remark { get; set; }
    public string SeSite { get; set; }
    public string CdSite { get; set; }
}
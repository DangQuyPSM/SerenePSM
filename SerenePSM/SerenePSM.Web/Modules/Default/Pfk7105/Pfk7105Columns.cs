using Serenity.ComponentModel;
using System.ComponentModel;

namespace SerenePSM.Default.Columns;

[ColumnsScript("Default.Pfk7105")]
[BasedOnRow(typeof(Pfk7105Row), CheckNames = true)]
public class Pfk7105Columns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string SizeRangeTool { get; set; }
    public string SeSizeGroup { get; set; }
    public string CdSizeGroup { get; set; }
    public string CustomerCode { get; set; }
    public string SizeRangeToolName { get; set; }
    public string SizeRangeToolSimpleName { get; set; }
    public string SeGender { get; set; }
    public string CdGender { get; set; }
    public string SeSeason { get; set; }
    public string CdSeason { get; set; }
    public string SizeAverage01 { get; set; }
    public string SizeAverage02 { get; set; }
    public string SizeAverage03 { get; set; }
    public string SizeAverage04 { get; set; }
    public string SizeAverage05 { get; set; }
    public string Size01 { get; set; }
    public string Size02 { get; set; }
    public string Size03 { get; set; }
    public string Size04 { get; set; }
    public string Size05 { get; set; }
    public string Size06 { get; set; }
    public string Size07 { get; set; }
    public string Size08 { get; set; }
    public string Size09 { get; set; }
    public string Size10 { get; set; }
    public string Size11 { get; set; }
    public string Size12 { get; set; }
    public string Size13 { get; set; }
    public string Size14 { get; set; }
    public string Size15 { get; set; }
    public string Size16 { get; set; }
    public string Size17 { get; set; }
    public string Size18 { get; set; }
    public string Size19 { get; set; }
    public string Size20 { get; set; }
    public string Size21 { get; set; }
    public string Size22 { get; set; }
    public string Size23 { get; set; }
    public string Size24 { get; set; }
    public string Size25 { get; set; }
    public string Size26 { get; set; }
    public string Size27 { get; set; }
    public string Size28 { get; set; }
    public string Size29 { get; set; }
    public string Size30 { get; set; }
    public string DateInsert { get; set; }
    public string DateUpdate { get; set; }
    public string InchargeInsert { get; set; }
    public string InchargeUpdate { get; set; }
    public string CheckUse { get; set; }
    public string CheckComplete { get; set; }
    public string Remark { get; set; }
    public string SeSite { get; set; }
    public string CdSite { get; set; }
}
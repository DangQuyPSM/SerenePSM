using Serenity.ComponentModel;

namespace SerenePSM.Default.Forms;

[FormScript("Default.Pfk7103")]
[BasedOnRow(typeof(Pfk7103Row), CheckNames = true)]
public class Pfk7103Form
{
    public string PreFix { get; set; }
    public string TypeCode { get; set; }
    public string SeTypeCode { get; set; }
    public string CdTypeCode { get; set; }
    public string SeComponentType { get; set; }
    public string CdComponentType { get; set; }
    public string TypeName { get; set; }
    public string TypeNameRelation { get; set; }
    public string TypeSimpleName { get; set; }
    public string CustomerCode { get; set; }
    public string ValueType1 { get; set; }
    public decimal QtyBatchS { get; set; }
    public decimal QtyDay { get; set; }
    public decimal QtyDayS { get; set; }
    public decimal QtyMan { get; set; }
    public decimal AmtAllowance { get; set; }
    public string Standard { get; set; }
    public string Standard1 { get; set; }
    public string Standard2 { get; set; }
    public string Standard3 { get; set; }
    public string Standard4 { get; set; }
    public string Standard5 { get; set; }
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
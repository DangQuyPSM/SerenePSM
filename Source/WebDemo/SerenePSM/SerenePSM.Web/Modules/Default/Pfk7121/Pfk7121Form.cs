using Serenity.ComponentModel;

namespace SerenePSM.Default.Forms;

[FormScript("Default.Pfk7121")]
[BasedOnRow(typeof(Pfk7121Row), CheckNames = true)]
public class Pfk7121Form
{
    public string ColorName { get; set; }
    public string ColorNameS1 { get; set; }
    public string ColorNameS2 { get; set; }
    public string ColorNameSimple { get; set; }
    public string CustomerCode { get; set; }
    public string SeColorBase { get; set; }
    public string CdColorBase { get; set; }
    public string SeColorCategory { get; set; }
    public string CdColorCategory { get; set; }
    public string ColorPosition { get; set; }
    public string CheckBase { get; set; }
    public string CheckUse { get; set; }
    public string DateInsert { get; set; }
    public string DateUpdate { get; set; }
    public string InchargeInsert { get; set; }
    public string InchargeUpdate { get; set; }
    public string Remark { get; set; }
    public string SeSite { get; set; }
    public string CdSite { get; set; }
}
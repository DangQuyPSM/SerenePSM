using Serenity.ComponentModel;

namespace SerenePSM.Default.Forms;

[FormScript("Default.Pfk7411")]
[BasedOnRow(typeof(Pfk7411Row), CheckNames = true)]
public class Pfk7411Form
{
    public string DevelopmenetCode { get; set; }
    public string IdCard { get; set; }
    public string IdhrCode { get; set; }
    public string UserId { get; set; }
    public string PassWord { get; set; }
    public string Name { get; set; }
    public string ForeignName { get; set; }
    public string SeSite { get; set; }
    public string CdSite { get; set; }
    public string SeMainProcess { get; set; }
    public string CdMainProcess { get; set; }
    public string SeSubProcess { get; set; }
    public string CdSubProcess { get; set; }
    public string SeNationality { get; set; }
    public string CdNationality { get; set; }
    public string SeDepartment { get; set; }
    public string CdDepartment { get; set; }
    public string SeOnePosition { get; set; }
    public string CdOnePosition { get; set; }
    public string SePosition { get; set; }
    public string CdPosition { get; set; }
    public string SeInCharge { get; set; }
    public string CdInCharge { get; set; }
    public string SeFactory { get; set; }
    public string CdFactory { get; set; }
    public string SeLineProd { get; set; }
    public string CdLineProd { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Gender { get; set; }
    public string SendEmail { get; set; }
    public string SendSms { get; set; }
    public string SendFax { get; set; }
    public string Locked { get; set; }
    public string OpenCdt { get; set; }
    public string OpenPrvDays { get; set; }
    public string OpenRate { get; set; }
    public string OpenSchedule { get; set; }
    public string OpenAlert { get; set; }
    public string OpenMessage { get; set; }
    public decimal ScreenLock { get; set; }
    public string Idcd { get; set; }
    public string Dgcd { get; set; }
    public string Gnid { get; set; }
    public string DateInsert { get; set; }
    public string DateUpdate { get; set; }
    public string InchargeInsert { get; set; }
    public string InchargeUpdate { get; set; }
    public string DateActive { get; set; }
    public string DateDeactive { get; set; }
    public string CheckActive { get; set; }
    public string FirstChangePass { get; set; }
    public string LastPass { get; set; }
    public string LastPass1 { get; set; }
    public string LastPass2 { get; set; }
    public decimal FailLoginCnt { get; set; }
    public string CheckNever { get; set; }
    public string LastLogin { get; set; }
    public string LastTime { get; set; }
    public string CheckOption1 { get; set; }
    public string CheckOption2 { get; set; }
    public string CheckOption3 { get; set; }
    public string CheckOption4 { get; set; }
    public string CheckOption5 { get; set; }
    public string CheckUse { get; set; }
    public string DepName { get; set; }
    public string EmpTypeName { get; set; }
    public string PosName { get; set; }
    public string LineName { get; set; }
    public string TeamName { get; set; }
    public string PartName { get; set; }
    public string CheckDev { get; set; }
}
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SerenePSM.Default;

[ConnectionKey("Default"), Module("Default"), TableName("PFK7411")]
[DisplayName("Danh mục nhân sự-(Pfk7411)"), InstanceName("Pfk7411")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class Pfk7411Row : Row<Pfk7411Row.RowFields>, IIdRow, INameRow
{
    [DisplayName("Danh mục nhân sự"), Column("K7411_IDNO"), Size(8), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string Idno { get => fields.Idno[this]; set => fields.Idno[this] = value; }

    [DisplayName("Tên đầy đủ"), Column("K7411_Name"), Size(100), NotNull]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Số thẻ"), Column("K7411_IDCard"), Size(100)]
    public string IdCard { get => fields.IdCard[this]; set => fields.IdCard[this] = value; }

    [DisplayName("Mã HR"), Column("K7411_IDHRCode"), Size(100)]
    public string IdhrCode { get => fields.IdhrCode[this]; set => fields.IdhrCode[this] = value; }

    [DisplayName("Quốc gia"), Column("K7411_seNationality"), Size(3), NotNull]
    public string SeNationality { get => fields.SeNationality[this]; set => fields.SeNationality[this] = value; }

    [DisplayName("Phòng ban"), Column("K7411_seDepartment"), Size(3), NotNull]
    public string SeDepartment { get => fields.SeDepartment[this]; set => fields.SeDepartment[this] = value; }

    [DisplayName("Vị trí"), Column("K7411_sePosition"), Size(3), NotNull]
    public string SePosition { get => fields.SePosition[this]; set => fields.SePosition[this] = value; }

    [DisplayName("Developmenet Code"), Column("K7411_DevelopmenetCode"), Size(20), NotNull, Hidden]
    public string DevelopmenetCode { get => fields.DevelopmenetCode[this]; set => fields.DevelopmenetCode[this] = value; }

    

    

    [DisplayName("User Id"), Column("K7411_UserID"), Size(100), NotNull, Hidden]
    public string UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Pass Word"), Column("K7411_PassWord"), Size(100), NotNull, Hidden]
    public string PassWord { get => fields.PassWord[this]; set => fields.PassWord[this] = value; }

    

    [DisplayName("Foreign Name"), Column("K7411_ForeignName"), Size(30), NotNull, Hidden]
    public string ForeignName { get => fields.ForeignName[this]; set => fields.ForeignName[this] = value; }

    [DisplayName("Se Site"), Column("K7411_seSite"), Size(3), NotNull, Hidden]
    public string SeSite { get => fields.SeSite[this]; set => fields.SeSite[this] = value; }

    [DisplayName("Cd Site"), Column("K7411_cdSite"), Size(3), NotNull, Hidden]
    public string CdSite { get => fields.CdSite[this]; set => fields.CdSite[this] = value; }

    [DisplayName("Se Main Process"), Column("K7411_seMainProcess"), Size(3), Hidden]
    public string SeMainProcess { get => fields.SeMainProcess[this]; set => fields.SeMainProcess[this] = value; }

    [DisplayName("Cd Main Process"), Column("K7411_cdMainProcess"), Size(3), Hidden]
    public string CdMainProcess { get => fields.CdMainProcess[this]; set => fields.CdMainProcess[this] = value; }

    [DisplayName("Se Sub Process"), Column("K7411_seSubProcess"), Size(3), Hidden]
    public string SeSubProcess { get => fields.SeSubProcess[this]; set => fields.SeSubProcess[this] = value; }

    [DisplayName("Cd Sub Process"), Column("K7411_cdSubProcess"), Size(3), Hidden]
    public string CdSubProcess { get => fields.CdSubProcess[this]; set => fields.CdSubProcess[this] = value; }

    

    [DisplayName("Cd Nationality"), Column("K7411_cdNationality"), Size(3), NotNull, Hidden]
    public string CdNationality { get => fields.CdNationality[this]; set => fields.CdNationality[this] = value; }

    

    [DisplayName("Cd Department"), Column("K7411_cdDepartment"), Size(3), NotNull, Hidden]
    public string CdDepartment { get => fields.CdDepartment[this]; set => fields.CdDepartment[this] = value; }

    [DisplayName("Se One Position"), Column("K7411_seOnePosition"), Size(3), NotNull, Hidden]
    public string SeOnePosition { get => fields.SeOnePosition[this]; set => fields.SeOnePosition[this] = value; }

    [DisplayName("Cd One Position"), Column("K7411_cdOnePosition"), Size(3), NotNull, Hidden]
    public string CdOnePosition { get => fields.CdOnePosition[this]; set => fields.CdOnePosition[this] = value; }

    

    [DisplayName("Cd Position"), Column("K7411_cdPosition"), Size(3), NotNull, Hidden]
    public string CdPosition { get => fields.CdPosition[this]; set => fields.CdPosition[this] = value; }

    [DisplayName("Se In Charge"), Column("K7411_seInCharge"), Size(3), NotNull, Hidden]
    public string SeInCharge { get => fields.SeInCharge[this]; set => fields.SeInCharge[this] = value; }

    [DisplayName("Cd In Charge"), Column("K7411_cdInCharge"), Size(3), NotNull, Hidden]
    public string CdInCharge { get => fields.CdInCharge[this]; set => fields.CdInCharge[this] = value; }

    [DisplayName("Se Factory"), Column("K7411_seFactory"), Size(3)]
    public string SeFactory { get => fields.SeFactory[this]; set => fields.SeFactory[this] = value; }

    [DisplayName("Cd Factory"), Column("K7411_cdFactory"), Size(3)]
    public string CdFactory { get => fields.CdFactory[this]; set => fields.CdFactory[this] = value; }

    [DisplayName("Se Line Prod"), Column("K7411_seLineProd"), Size(3)]
    public string SeLineProd { get => fields.SeLineProd[this]; set => fields.SeLineProd[this] = value; }

    [DisplayName("Cd Line Prod"), Column("K7411_cdLineProd"), Size(3)]
    public string CdLineProd { get => fields.CdLineProd[this]; set => fields.CdLineProd[this] = value; }

    [DisplayName("Email"), Column("K7411_Email"), Size(100), NotNull, Hidden]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Mobile"), Column("K7411_Mobile"), Size(30)]
    public string Mobile { get => fields.Mobile[this]; set => fields.Mobile[this] = value; }

    [DisplayName("Gender"), Column("K7411_Gender"), Size(1)]
    public string Gender { get => fields.Gender[this]; set => fields.Gender[this] = value; }

    [DisplayName("Send Email"), Column("K7411_SendEmail"), Size(1)]
    public string SendEmail { get => fields.SendEmail[this]; set => fields.SendEmail[this] = value; }

    [DisplayName("Send Sms"), Column("K7411_SendSMS"), Size(1)]
    public string SendSms { get => fields.SendSms[this]; set => fields.SendSms[this] = value; }

    [DisplayName("Send Fax"), Column("K7411_SendFax"), Size(1)]
    public string SendFax { get => fields.SendFax[this]; set => fields.SendFax[this] = value; }

    [DisplayName("Locked"), Column("K7411_Locked"), Size(1)]
    public string Locked { get => fields.Locked[this]; set => fields.Locked[this] = value; }

    [DisplayName("Open Cdt"), Column("K7411_OpenCdt"), Size(1)]
    public string OpenCdt { get => fields.OpenCdt[this]; set => fields.OpenCdt[this] = value; }

    [DisplayName("Open Prv Days"), Column("K7411_OpenPrvDays"), Size(1)]
    public string OpenPrvDays { get => fields.OpenPrvDays[this]; set => fields.OpenPrvDays[this] = value; }

    [DisplayName("Open Rate"), Column("K7411_OpenRate"), Size(1)]
    public string OpenRate { get => fields.OpenRate[this]; set => fields.OpenRate[this] = value; }

    [DisplayName("Open Schedule"), Column("K7411_OpenSchedule"), Size(1)]
    public string OpenSchedule { get => fields.OpenSchedule[this]; set => fields.OpenSchedule[this] = value; }

    [DisplayName("Open Alert"), Column("K7411_OpenAlert"), Size(1)]
    public string OpenAlert { get => fields.OpenAlert[this]; set => fields.OpenAlert[this] = value; }

    [DisplayName("Open Message"), Column("K7411_OpenMessage"), Size(1)]
    public string OpenMessage { get => fields.OpenMessage[this]; set => fields.OpenMessage[this] = value; }

    [DisplayName("Screen Lock"), Column("K7411_ScreenLock"), Size(18)]
    public decimal? ScreenLock { get => fields.ScreenLock[this]; set => fields.ScreenLock[this] = value; }

    [DisplayName("Idcd"), Column("K7411_IDCD"), Size(30)]
    public string Idcd { get => fields.Idcd[this]; set => fields.Idcd[this] = value; }

    [DisplayName("Dgcd"), Column("K7411_DGCD"), Size(30)]
    public string Dgcd { get => fields.Dgcd[this]; set => fields.Dgcd[this] = value; }

    [DisplayName("Gnid"), Column("K7411_GNID"), Size(30)]
    public string Gnid { get => fields.Gnid[this]; set => fields.Gnid[this] = value; }

    [DisplayName("Date Insert"), Column("K7411_DateInsert"), Size(8), NotNull, Hidden]
    public string DateInsert { get => fields.DateInsert[this]; set => fields.DateInsert[this] = value; }

    [DisplayName("Date Update"), Column("K7411_DateUpdate"), Size(8), NotNull, Hidden]
    public string DateUpdate { get => fields.DateUpdate[this]; set => fields.DateUpdate[this] = value; }

    [DisplayName("Incharge Insert"), Column("K7411_InchargeInsert"), Size(8), NotNull, Hidden]
    public string InchargeInsert { get => fields.InchargeInsert[this]; set => fields.InchargeInsert[this] = value; }

    [DisplayName("Incharge Update"), Column("K7411_InchargeUpdate"), Size(8), NotNull, Hidden]
    public string InchargeUpdate { get => fields.InchargeUpdate[this]; set => fields.InchargeUpdate[this] = value; }

    [DisplayName("Date Active"), Column("K7411_DateActive"), Size(8), NotNull, Hidden]
    public string DateActive { get => fields.DateActive[this]; set => fields.DateActive[this] = value; }

    [DisplayName("Date Deactive"), Column("K7411_DateDeactive"), Size(8), NotNull, Hidden]
    public string DateDeactive { get => fields.DateDeactive[this]; set => fields.DateDeactive[this] = value; }

    [DisplayName("Check Active"), Column("K7411_CheckActive"), Size(1), NotNull, Hidden]
    public string CheckActive { get => fields.CheckActive[this]; set => fields.CheckActive[this] = value; }

    [DisplayName("First Change Pass"), Column("K7411_FirstChangePass"), Size(1), NotNull, Hidden]
    public string FirstChangePass { get => fields.FirstChangePass[this]; set => fields.FirstChangePass[this] = value; }

    [DisplayName("Last Pass"), Column("K7411_LastPass"), Size(100), NotNull, Hidden]
    public string LastPass { get => fields.LastPass[this]; set => fields.LastPass[this] = value; }

    [DisplayName("Last Pass1"), Column("K7411_LastPass1"), Size(100), NotNull, Hidden]
    public string LastPass1 { get => fields.LastPass1[this]; set => fields.LastPass1[this] = value; }

    [DisplayName("Last Pass2"), Column("K7411_LastPass2"), Size(100), NotNull, Hidden]
    public string LastPass2 { get => fields.LastPass2[this]; set => fields.LastPass2[this] = value; }

    [DisplayName("Fail Login Cnt"), Column("K7411_FailLoginCnt"), Size(18), NotNull, Hidden]
    public decimal? FailLoginCnt { get => fields.FailLoginCnt[this]; set => fields.FailLoginCnt[this] = value; }

    [DisplayName("Check Never"), Column("K7411_CheckNever"), Size(1), NotNull, Hidden]
    public string CheckNever { get => fields.CheckNever[this]; set => fields.CheckNever[this] = value; }

    [DisplayName("Last Login"), Column("K7411_LastLogin"), Size(8), NotNull, Hidden]
    public string LastLogin { get => fields.LastLogin[this]; set => fields.LastLogin[this] = value; }

    [DisplayName("Last Time"), Column("K7411_LastTime"), Size(14), NotNull, Hidden]
    public string LastTime { get => fields.LastTime[this]; set => fields.LastTime[this] = value; }

    [DisplayName("Check Option1"), Column("K7411_CheckOption1"), Size(1)]
    public string CheckOption1 { get => fields.CheckOption1[this]; set => fields.CheckOption1[this] = value; }

    [DisplayName("Check Option2"), Column("K7411_CheckOption2"), Size(1)]
    public string CheckOption2 { get => fields.CheckOption2[this]; set => fields.CheckOption2[this] = value; }

    [DisplayName("Check Option3"), Column("K7411_CheckOption3"), Size(1)]
    public string CheckOption3 { get => fields.CheckOption3[this]; set => fields.CheckOption3[this] = value; }

    [DisplayName("Check Option4"), Column("K7411_CheckOption4"), Size(1)]
    public string CheckOption4 { get => fields.CheckOption4[this]; set => fields.CheckOption4[this] = value; }

    [DisplayName("Check Option5"), Column("K7411_CheckOption5"), Size(1)]
    public string CheckOption5 { get => fields.CheckOption5[this]; set => fields.CheckOption5[this] = value; }

    [DisplayName("Check Use"), Column("K7411_CheckUse"), Size(1), NotNull, Hidden]
    public string CheckUse { get => fields.CheckUse[this]; set => fields.CheckUse[this] = value; }

    [DisplayName("Dep Name"), Column("K7411_DepName"), Size(100), Hidden]
    public string DepName { get => fields.DepName[this]; set => fields.DepName[this] = value; }

    [DisplayName("Emp Type Name"), Column("K7411_EmpTypeName"), Size(100), Hidden]
    public string EmpTypeName { get => fields.EmpTypeName[this]; set => fields.EmpTypeName[this] = value; }

    [DisplayName("Pos Name"), Column("K7411_PosName"), Size(100), Hidden]
    public string PosName { get => fields.PosName[this]; set => fields.PosName[this] = value; }

    [DisplayName("Line Name"), Column("K7411_LineName"), Size(100), Hidden]
    public string LineName { get => fields.LineName[this]; set => fields.LineName[this] = value; }

    [DisplayName("Team Name"), Column("K7411_TeamName"), Size(100), Hidden]
    public string TeamName { get => fields.TeamName[this]; set => fields.TeamName[this] = value; }

    [DisplayName("Part Name"), Column("K7411_PartName"), Size(100), Hidden]
    public string PartName { get => fields.PartName[this]; set => fields.PartName[this] = value; }

    [DisplayName("Check Dev"), Column("K7411_CheckDev"), Size(1), Hidden]
    public string CheckDev { get => fields.CheckDev[this]; set => fields.CheckDev[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public StringField Idno;
        public StringField DevelopmenetCode;
        public StringField IdCard;
        public StringField IdhrCode;
        public StringField UserId;
        public StringField PassWord;
        public StringField Name;
        public StringField ForeignName;
        public StringField SeSite;
        public StringField CdSite;
        public StringField SeMainProcess;
        public StringField CdMainProcess;
        public StringField SeSubProcess;
        public StringField CdSubProcess;
        public StringField SeNationality;
        public StringField CdNationality;
        public StringField SeDepartment;
        public StringField CdDepartment;
        public StringField SeOnePosition;
        public StringField CdOnePosition;
        public StringField SePosition;
        public StringField CdPosition;
        public StringField SeInCharge;
        public StringField CdInCharge;
        public StringField SeFactory;
        public StringField CdFactory;
        public StringField SeLineProd;
        public StringField CdLineProd;
        public StringField Email;
        public StringField Mobile;
        public StringField Gender;
        public StringField SendEmail;
        public StringField SendSms;
        public StringField SendFax;
        public StringField Locked;
        public StringField OpenCdt;
        public StringField OpenPrvDays;
        public StringField OpenRate;
        public StringField OpenSchedule;
        public StringField OpenAlert;
        public StringField OpenMessage;
        public DecimalField ScreenLock;
        public StringField Idcd;
        public StringField Dgcd;
        public StringField Gnid;
        public StringField DateInsert;
        public StringField DateUpdate;
        public StringField InchargeInsert;
        public StringField InchargeUpdate;
        public StringField DateActive;
        public StringField DateDeactive;
        public StringField CheckActive;
        public StringField FirstChangePass;
        public StringField LastPass;
        public StringField LastPass1;
        public StringField LastPass2;
        public DecimalField FailLoginCnt;
        public StringField CheckNever;
        public StringField LastLogin;
        public StringField LastTime;
        public StringField CheckOption1;
        public StringField CheckOption2;
        public StringField CheckOption3;
        public StringField CheckOption4;
        public StringField CheckOption5;
        public StringField CheckUse;
        public StringField DepName;
        public StringField EmpTypeName;
        public StringField PosName;
        public StringField LineName;
        public StringField TeamName;
        public StringField PartName;
        public StringField CheckDev;

    }
}
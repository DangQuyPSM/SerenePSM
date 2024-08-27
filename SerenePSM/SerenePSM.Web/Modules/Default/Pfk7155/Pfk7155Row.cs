using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SerenePSM.Default;

[ConnectionKey("Default"), Module("Default"), TableName("PFK7155")]
[DisplayName("Pfk7155"), InstanceName("Pfk7155")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class Pfk7155Row : Row<Pfk7155Row.RowFields>, IIdRow, INameRow
{
    [DisplayName("Machine Code"), Column("K7155_MachineCode"), Size(6), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string MachineCode { get => fields.MachineCode[this]; set => fields.MachineCode[this] = value; }

    [DisplayName("Development Code"), Column("K7155_DevelopmentCode"), Size(6), NotNull]
    public string DevelopmentCode { get => fields.DevelopmentCode[this]; set => fields.DevelopmentCode[this] = value; }

    [DisplayName("Acc Code"), Column("K7155_AccCode"), Size(50), NotNull]
    public string AccCode { get => fields.AccCode[this]; set => fields.AccCode[this] = value; }

    [DisplayName("Tag No"), Column("K7155_TagNo"), Size(50), NotNull]
    public string TagNo { get => fields.TagNo[this]; set => fields.TagNo[this] = value; }

    [DisplayName("Model"), Column("K7155_Model"), Size(50), NotNull]
    public string Model { get => fields.Model[this]; set => fields.Model[this] = value; }

    [DisplayName("Se Machine Type"), Column("K7155_seMachineType"), Size(3), NotNull]
    public string SeMachineType { get => fields.SeMachineType[this]; set => fields.SeMachineType[this] = value; }

    [DisplayName("Cd Machine Type"), Column("K7155_cdMachineType"), Size(3), NotNull]
    public string CdMachineType { get => fields.CdMachineType[this]; set => fields.CdMachineType[this] = value; }

    [DisplayName("Machine Name"), Column("K7155_MachineName"), Size(100), NotNull]
    public string MachineName { get => fields.MachineName[this]; set => fields.MachineName[this] = value; }

    [DisplayName("Machine Name Simply"), Column("K7155_MachineNameSimply"), Size(50), NotNull]
    public string MachineNameSimply { get => fields.MachineNameSimply[this]; set => fields.MachineNameSimply[this] = value; }

    [DisplayName("Se Factory"), Column("K7155_seFactory"), Size(3), NotNull]
    public string SeFactory { get => fields.SeFactory[this]; set => fields.SeFactory[this] = value; }

    [DisplayName("Cd Factory"), Column("K7155_cdFactory"), Size(3), NotNull]
    public string CdFactory { get => fields.CdFactory[this]; set => fields.CdFactory[this] = value; }

    [DisplayName("Se Sub Process"), Column("K7155_seSubProcess"), Size(3), NotNull]
    public string SeSubProcess { get => fields.SeSubProcess[this]; set => fields.SeSubProcess[this] = value; }

    [DisplayName("Cd Sub Process"), Column("K7155_cdSubProcess"), Size(3), NotNull]
    public string CdSubProcess { get => fields.CdSubProcess[this]; set => fields.CdSubProcess[this] = value; }

    [DisplayName("Machine Rpm"), Column("K7155_MachineRPM"), Size(18), NotNull]
    public decimal? MachineRpm { get => fields.MachineRpm[this]; set => fields.MachineRpm[this] = value; }

    [DisplayName("Machine Capacity"), Column("K7155_MachineCapacity"), Size(18), NotNull]
    public decimal? MachineCapacity { get => fields.MachineCapacity[this]; set => fields.MachineCapacity[this] = value; }

    [DisplayName("Rotation Day Production"), Column("K7155_RotationDayProduction"), Size(18), NotNull]
    public decimal? RotationDayProduction { get => fields.RotationDayProduction[this]; set => fields.RotationDayProduction[this] = value; }

    [DisplayName("Rotation Once Production"), Column("K7155_RotationOnceProduction"), Size(18), NotNull]
    public decimal? RotationOnceProduction { get => fields.RotationOnceProduction[this]; set => fields.RotationOnceProduction[this] = value; }

    [DisplayName("Rotation Once Time Production"), Column("K7155_RotationOnceTimeProduction"), Size(18), NotNull]
    public decimal? RotationOnceTimeProduction { get => fields.RotationOnceTimeProduction[this]; set => fields.RotationOnceTimeProduction[this] = value; }

    [DisplayName("Check Apply Liquid"), Column("K7155_CheckApplyLiquid"), Size(1), NotNull]
    public string CheckApplyLiquid { get => fields.CheckApplyLiquid[this]; set => fields.CheckApplyLiquid[this] = value; }

    [DisplayName("Rate Liquid"), Column("K7155_RateLiquid"), Size(18), Scale(2), NotNull]
    public decimal? RateLiquid { get => fields.RateLiquid[this]; set => fields.RateLiquid[this] = value; }

    [DisplayName("Wdcpmdtc"), Column("K7155_WDCPMDTC"), Size(100), NotNull]
    public string Wdcpmdtc { get => fields.Wdcpmdtc[this]; set => fields.Wdcpmdtc[this] = value; }

    [DisplayName("Rate Soda1"), Column("K7155_RateSoda1"), Size(18), NotNull]
    public decimal? RateSoda1 { get => fields.RateSoda1[this]; set => fields.RateSoda1[this] = value; }

    [DisplayName("Rate Soda2"), Column("K7155_RateSoda2"), Size(18), NotNull]
    public decimal? RateSoda2 { get => fields.RateSoda2[this]; set => fields.RateSoda2[this] = value; }

    [DisplayName("Rate Soda3"), Column("K7155_RateSoda3"), Size(18), NotNull]
    public decimal? RateSoda3 { get => fields.RateSoda3[this]; set => fields.RateSoda3[this] = value; }

    [DisplayName("Rate Glauber Salt1"), Column("K7155_RateGlauberSalt1"), Size(18), NotNull]
    public decimal? RateGlauberSalt1 { get => fields.RateGlauberSalt1[this]; set => fields.RateGlauberSalt1[this] = value; }

    [DisplayName("Rate Glauber Salt2"), Column("K7155_RateGlauberSalt2"), Size(18), NotNull]
    public decimal? RateGlauberSalt2 { get => fields.RateGlauberSalt2[this]; set => fields.RateGlauberSalt2[this] = value; }

    [DisplayName("Rate Glauber Salt3"), Column("K7155_RateGlauberSalt3"), Size(18), NotNull]
    public decimal? RateGlauberSalt3 { get => fields.RateGlauberSalt3[this]; set => fields.RateGlauberSalt3[this] = value; }

    [DisplayName("Group Machine"), Column("K7155_GroupMachine"), Size(18), NotNull]
    public decimal? GroupMachine { get => fields.GroupMachine[this]; set => fields.GroupMachine[this] = value; }

    [DisplayName("Horizontal Position"), Column("K7155_HorizontalPosition"), Size(18), NotNull]
    public decimal? HorizontalPosition { get => fields.HorizontalPosition[this]; set => fields.HorizontalPosition[this] = value; }

    [DisplayName("Vertical Position"), Column("K7155_VerticalPosition"), Size(18), NotNull]
    public decimal? VerticalPosition { get => fields.VerticalPosition[this]; set => fields.VerticalPosition[this] = value; }

    [DisplayName("Chec K1"), Column("K7155_ChecK1"), Size(1), NotNull]
    public string ChecK1 { get => fields.ChecK1[this]; set => fields.ChecK1[this] = value; }

    [DisplayName("Check2"), Column("K7155_Check2"), Size(1), NotNull]
    public string Check2 { get => fields.Check2[this]; set => fields.Check2[this] = value; }

    [DisplayName("Check Final Process"), Column("K7155_CheckFinalProcess"), Size(1), NotNull]
    public string CheckFinalProcess { get => fields.CheckFinalProcess[this]; set => fields.CheckFinalProcess[this] = value; }

    [DisplayName("Check Process"), Column("K7155_CheckProcess"), Size(1), NotNull]
    public string CheckProcess { get => fields.CheckProcess[this]; set => fields.CheckProcess[this] = value; }

    [DisplayName("Check Use"), Column("K7155_checkUse"), Size(1), NotNull]
    public string CheckUse { get => fields.CheckUse[this]; set => fields.CheckUse[this] = value; }

    [DisplayName("Display Seq"), Column("K7155_DisplaySeq"), Size(18), NotNull]
    public decimal? DisplaySeq { get => fields.DisplaySeq[this]; set => fields.DisplaySeq[this] = value; }

    [DisplayName("Remark"), Column("K7155_Remark"), Size(200), NotNull]
    public string Remark { get => fields.Remark[this]; set => fields.Remark[this] = value; }

    [DisplayName("Se Site"), Column("K7155_seSite"), Size(3), NotNull]
    public string SeSite { get => fields.SeSite[this]; set => fields.SeSite[this] = value; }

    [DisplayName("Cd Site"), Column("K7155_cdSite"), Size(3), NotNull]
    public string CdSite { get => fields.CdSite[this]; set => fields.CdSite[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public StringField MachineCode;
        public StringField DevelopmentCode;
        public StringField AccCode;
        public StringField TagNo;
        public StringField Model;
        public StringField SeMachineType;
        public StringField CdMachineType;
        public StringField MachineName;
        public StringField MachineNameSimply;
        public StringField SeFactory;
        public StringField CdFactory;
        public StringField SeSubProcess;
        public StringField CdSubProcess;
        public DecimalField MachineRpm;
        public DecimalField MachineCapacity;
        public DecimalField RotationDayProduction;
        public DecimalField RotationOnceProduction;
        public DecimalField RotationOnceTimeProduction;
        public StringField CheckApplyLiquid;
        public DecimalField RateLiquid;
        public StringField Wdcpmdtc;
        public DecimalField RateSoda1;
        public DecimalField RateSoda2;
        public DecimalField RateSoda3;
        public DecimalField RateGlauberSalt1;
        public DecimalField RateGlauberSalt2;
        public DecimalField RateGlauberSalt3;
        public DecimalField GroupMachine;
        public DecimalField HorizontalPosition;
        public DecimalField VerticalPosition;
        public StringField ChecK1;
        public StringField Check2;
        public StringField CheckFinalProcess;
        public StringField CheckProcess;
        public StringField CheckUse;
        public DecimalField DisplaySeq;
        public StringField Remark;
        public StringField SeSite;
        public StringField CdSite;

    }
}
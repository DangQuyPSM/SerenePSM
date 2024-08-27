using Serenity.ComponentModel;
using System.ComponentModel;

namespace SerenePSM.Default.Columns;

[ColumnsScript("Default.Pfk7155")]
[BasedOnRow(typeof(Pfk7155Row), CheckNames = true)]
public class Pfk7155Columns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string MachineCode { get; set; }
    public string DevelopmentCode { get; set; }
    public string AccCode { get; set; }
    public string TagNo { get; set; }
    public string Model { get; set; }
    public string SeMachineType { get; set; }
    public string CdMachineType { get; set; }
    public string MachineName { get; set; }
    public string MachineNameSimply { get; set; }
    public string SeFactory { get; set; }
    public string CdFactory { get; set; }
    public string SeSubProcess { get; set; }
    public string CdSubProcess { get; set; }
    public decimal MachineRpm { get; set; }
    public decimal MachineCapacity { get; set; }
    public decimal RotationDayProduction { get; set; }
    public decimal RotationOnceProduction { get; set; }
    public decimal RotationOnceTimeProduction { get; set; }
    public string CheckApplyLiquid { get; set; }
    public decimal RateLiquid { get; set; }
    public string Wdcpmdtc { get; set; }
    public decimal RateSoda1 { get; set; }
    public decimal RateSoda2 { get; set; }
    public decimal RateSoda3 { get; set; }
    public decimal RateGlauberSalt1 { get; set; }
    public decimal RateGlauberSalt2 { get; set; }
    public decimal RateGlauberSalt3 { get; set; }
    public decimal GroupMachine { get; set; }
    public decimal HorizontalPosition { get; set; }
    public decimal VerticalPosition { get; set; }
    public string ChecK1 { get; set; }
    public string Check2 { get; set; }
    public string CheckFinalProcess { get; set; }
    public string CheckProcess { get; set; }
    public string CheckUse { get; set; }
    public decimal DisplaySeq { get; set; }
    public string Remark { get; set; }
    public string SeSite { get; set; }
    public string CdSite { get; set; }
}
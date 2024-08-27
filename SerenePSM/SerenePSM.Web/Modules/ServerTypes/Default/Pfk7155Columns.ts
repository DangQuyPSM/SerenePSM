import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { Pfk7155Row } from "./Pfk7155Row";

export interface Pfk7155Columns {
    MachineCode: Column<Pfk7155Row>;
    DevelopmentCode: Column<Pfk7155Row>;
    AccCode: Column<Pfk7155Row>;
    TagNo: Column<Pfk7155Row>;
    Model: Column<Pfk7155Row>;
    SeMachineType: Column<Pfk7155Row>;
    CdMachineType: Column<Pfk7155Row>;
    MachineName: Column<Pfk7155Row>;
    MachineNameSimply: Column<Pfk7155Row>;
    SeFactory: Column<Pfk7155Row>;
    CdFactory: Column<Pfk7155Row>;
    SeSubProcess: Column<Pfk7155Row>;
    CdSubProcess: Column<Pfk7155Row>;
    MachineRpm: Column<Pfk7155Row>;
    MachineCapacity: Column<Pfk7155Row>;
    RotationDayProduction: Column<Pfk7155Row>;
    RotationOnceProduction: Column<Pfk7155Row>;
    RotationOnceTimeProduction: Column<Pfk7155Row>;
    CheckApplyLiquid: Column<Pfk7155Row>;
    RateLiquid: Column<Pfk7155Row>;
    Wdcpmdtc: Column<Pfk7155Row>;
    RateSoda1: Column<Pfk7155Row>;
    RateSoda2: Column<Pfk7155Row>;
    RateSoda3: Column<Pfk7155Row>;
    RateGlauberSalt1: Column<Pfk7155Row>;
    RateGlauberSalt2: Column<Pfk7155Row>;
    RateGlauberSalt3: Column<Pfk7155Row>;
    GroupMachine: Column<Pfk7155Row>;
    HorizontalPosition: Column<Pfk7155Row>;
    VerticalPosition: Column<Pfk7155Row>;
    ChecK1: Column<Pfk7155Row>;
    Check2: Column<Pfk7155Row>;
    CheckFinalProcess: Column<Pfk7155Row>;
    CheckProcess: Column<Pfk7155Row>;
    CheckUse: Column<Pfk7155Row>;
    DisplaySeq: Column<Pfk7155Row>;
    Remark: Column<Pfk7155Row>;
    SeSite: Column<Pfk7155Row>;
    CdSite: Column<Pfk7155Row>;
}

export class Pfk7155Columns extends ColumnsBase<Pfk7155Row> {
    static readonly columnsKey = 'Default.Pfk7155';
    static readonly Fields = fieldsProxy<Pfk7155Columns>();
}
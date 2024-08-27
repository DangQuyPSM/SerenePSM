import { fieldsProxy } from "@serenity-is/corelib";

export interface Pfk7155Row {
    MachineCode?: string;
    DevelopmentCode?: string;
    AccCode?: string;
    TagNo?: string;
    Model?: string;
    SeMachineType?: string;
    CdMachineType?: string;
    MachineName?: string;
    MachineNameSimply?: string;
    SeFactory?: string;
    CdFactory?: string;
    SeSubProcess?: string;
    CdSubProcess?: string;
    MachineRpm?: number;
    MachineCapacity?: number;
    RotationDayProduction?: number;
    RotationOnceProduction?: number;
    RotationOnceTimeProduction?: number;
    CheckApplyLiquid?: string;
    RateLiquid?: number;
    Wdcpmdtc?: string;
    RateSoda1?: number;
    RateSoda2?: number;
    RateSoda3?: number;
    RateGlauberSalt1?: number;
    RateGlauberSalt2?: number;
    RateGlauberSalt3?: number;
    GroupMachine?: number;
    HorizontalPosition?: number;
    VerticalPosition?: number;
    ChecK1?: string;
    Check2?: string;
    CheckFinalProcess?: string;
    CheckProcess?: string;
    CheckUse?: string;
    DisplaySeq?: number;
    Remark?: string;
    SeSite?: string;
    CdSite?: string;
}

export abstract class Pfk7155Row {
    static readonly idProperty = 'MachineCode';
    static readonly nameProperty = 'MachineCode';
    static readonly localTextPrefix = 'Default.Pfk7155';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<Pfk7155Row>();
}
import { StringEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface Pfk7155Form {
    DevelopmentCode: StringEditor;
    AccCode: StringEditor;
    TagNo: StringEditor;
    Model: StringEditor;
    SeMachineType: StringEditor;
    CdMachineType: StringEditor;
    MachineName: StringEditor;
    MachineNameSimply: StringEditor;
    SeFactory: StringEditor;
    CdFactory: StringEditor;
    SeSubProcess: StringEditor;
    CdSubProcess: StringEditor;
    MachineRpm: DecimalEditor;
    MachineCapacity: DecimalEditor;
    RotationDayProduction: DecimalEditor;
    RotationOnceProduction: DecimalEditor;
    RotationOnceTimeProduction: DecimalEditor;
    CheckApplyLiquid: StringEditor;
    RateLiquid: DecimalEditor;
    Wdcpmdtc: StringEditor;
    RateSoda1: DecimalEditor;
    RateSoda2: DecimalEditor;
    RateSoda3: DecimalEditor;
    RateGlauberSalt1: DecimalEditor;
    RateGlauberSalt2: DecimalEditor;
    RateGlauberSalt3: DecimalEditor;
    GroupMachine: DecimalEditor;
    HorizontalPosition: DecimalEditor;
    VerticalPosition: DecimalEditor;
    ChecK1: StringEditor;
    Check2: StringEditor;
    CheckFinalProcess: StringEditor;
    CheckProcess: StringEditor;
    CheckUse: StringEditor;
    DisplaySeq: DecimalEditor;
    Remark: StringEditor;
    SeSite: StringEditor;
    CdSite: StringEditor;
}

export class Pfk7155Form extends PrefixedContext {
    static readonly formKey = 'Default.Pfk7155';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!Pfk7155Form.init)  {
            Pfk7155Form.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;

            initFormType(Pfk7155Form, [
                'DevelopmentCode', w0,
                'AccCode', w0,
                'TagNo', w0,
                'Model', w0,
                'SeMachineType', w0,
                'CdMachineType', w0,
                'MachineName', w0,
                'MachineNameSimply', w0,
                'SeFactory', w0,
                'CdFactory', w0,
                'SeSubProcess', w0,
                'CdSubProcess', w0,
                'MachineRpm', w1,
                'MachineCapacity', w1,
                'RotationDayProduction', w1,
                'RotationOnceProduction', w1,
                'RotationOnceTimeProduction', w1,
                'CheckApplyLiquid', w0,
                'RateLiquid', w1,
                'Wdcpmdtc', w0,
                'RateSoda1', w1,
                'RateSoda2', w1,
                'RateSoda3', w1,
                'RateGlauberSalt1', w1,
                'RateGlauberSalt2', w1,
                'RateGlauberSalt3', w1,
                'GroupMachine', w1,
                'HorizontalPosition', w1,
                'VerticalPosition', w1,
                'ChecK1', w0,
                'Check2', w0,
                'CheckFinalProcess', w0,
                'CheckProcess', w0,
                'CheckUse', w0,
                'DisplaySeq', w1,
                'Remark', w0,
                'SeSite', w0,
                'CdSite', w0
            ]);
        }
    }
}
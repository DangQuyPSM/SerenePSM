import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface Pfk7105Form {
    SeSizeGroup: StringEditor;
    CdSizeGroup: StringEditor;
    CustomerCode: StringEditor;
    SizeRangeToolName: StringEditor;
    SizeRangeToolSimpleName: StringEditor;
    SeGender: StringEditor;
    CdGender: StringEditor;
    SeSeason: StringEditor;
    CdSeason: StringEditor;
    SizeAverage01: StringEditor;
    SizeAverage02: StringEditor;
    SizeAverage03: StringEditor;
    SizeAverage04: StringEditor;
    SizeAverage05: StringEditor;
    Size01: StringEditor;
    Size02: StringEditor;
    Size03: StringEditor;
    Size04: StringEditor;
    Size05: StringEditor;
    Size06: StringEditor;
    Size07: StringEditor;
    Size08: StringEditor;
    Size09: StringEditor;
    Size10: StringEditor;
    Size11: StringEditor;
    Size12: StringEditor;
    Size13: StringEditor;
    Size14: StringEditor;
    Size15: StringEditor;
    Size16: StringEditor;
    Size17: StringEditor;
    Size18: StringEditor;
    Size19: StringEditor;
    Size20: StringEditor;
    Size21: StringEditor;
    Size22: StringEditor;
    Size23: StringEditor;
    Size24: StringEditor;
    Size25: StringEditor;
    Size26: StringEditor;
    Size27: StringEditor;
    Size28: StringEditor;
    Size29: StringEditor;
    Size30: StringEditor;
    DateInsert: StringEditor;
    DateUpdate: StringEditor;
    InchargeInsert: StringEditor;
    InchargeUpdate: StringEditor;
    CheckUse: StringEditor;
    CheckComplete: StringEditor;
    Remark: StringEditor;
    SeSite: StringEditor;
    CdSite: StringEditor;
}

export class Pfk7105Form extends PrefixedContext {
    static readonly formKey = 'Default.Pfk7105';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!Pfk7105Form.init)  {
            Pfk7105Form.init = true;

            var w0 = StringEditor;

            initFormType(Pfk7105Form, [
                'SeSizeGroup', w0,
                'CdSizeGroup', w0,
                'CustomerCode', w0,
                'SizeRangeToolName', w0,
                'SizeRangeToolSimpleName', w0,
                'SeGender', w0,
                'CdGender', w0,
                'SeSeason', w0,
                'CdSeason', w0,
                'SizeAverage01', w0,
                'SizeAverage02', w0,
                'SizeAverage03', w0,
                'SizeAverage04', w0,
                'SizeAverage05', w0,
                'Size01', w0,
                'Size02', w0,
                'Size03', w0,
                'Size04', w0,
                'Size05', w0,
                'Size06', w0,
                'Size07', w0,
                'Size08', w0,
                'Size09', w0,
                'Size10', w0,
                'Size11', w0,
                'Size12', w0,
                'Size13', w0,
                'Size14', w0,
                'Size15', w0,
                'Size16', w0,
                'Size17', w0,
                'Size18', w0,
                'Size19', w0,
                'Size20', w0,
                'Size21', w0,
                'Size22', w0,
                'Size23', w0,
                'Size24', w0,
                'Size25', w0,
                'Size26', w0,
                'Size27', w0,
                'Size28', w0,
                'Size29', w0,
                'Size30', w0,
                'DateInsert', w0,
                'DateUpdate', w0,
                'InchargeInsert', w0,
                'InchargeUpdate', w0,
                'CheckUse', w0,
                'CheckComplete', w0,
                'Remark', w0,
                'SeSite', w0,
                'CdSite', w0
            ]);
        }
    }
}
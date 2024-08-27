import { StringEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface Pfk7171Form {
    BasicCode: StringEditor;
    NameHlpButton: StringEditor;
    DisplaySeq: DecimalEditor;
    DevelopmentCode: StringEditor;
    SeBasicMaster: StringEditor;
    CdBasicMaster: StringEditor;
    BasicName: StringEditor;
    NameSimply: StringEditor;
    ForeignName1: StringEditor;
    ForeignName2: StringEditor;
    Check1: StringEditor;
    Check2: StringEditor;
    Check3: StringEditor;
    Check4: StringEditor;
    Check5: StringEditor;
    Check6: StringEditor;
    Check7: StringEditor;
    Check8: StringEditor;
    Check9: StringEditor;
    Check10: StringEditor;
    CheckName1: StringEditor;
    CheckName2: StringEditor;
    CheckName3: StringEditor;
    CheckName4: StringEditor;
    CheckName5: StringEditor;
    CheckName6: StringEditor;
    CheckName7: StringEditor;
    CheckName8: StringEditor;
    CheckName9: StringEditor;
    CheckName10: StringEditor;
    InchargeInsert: StringEditor;
    InchargeUpdate: StringEditor;
    DateInsert: StringEditor;
    DateUpdate: StringEditor;
    TimeInsert: StringEditor;
    TimeUpdate: StringEditor;
    TimeLast: StringEditor;
    CheckSync: StringEditor;
    CheckUse: StringEditor;
    TableAcc: StringEditor;
    TypeDm: StringEditor;
    KeyDm: StringEditor;
    ValueDm: StringEditor;
    Remark: StringEditor;
    SeSite: StringEditor;
    CdSite: StringEditor;
}

export class Pfk7171Form extends PrefixedContext {
    static readonly formKey = 'Default.Pfk7171';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!Pfk7171Form.init)  {
            Pfk7171Form.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;

            initFormType(Pfk7171Form, [
                'BasicCode', w0,
                'NameHlpButton', w0,
                'DisplaySeq', w1,
                'DevelopmentCode', w0,
                'SeBasicMaster', w0,
                'CdBasicMaster', w0,
                'BasicName', w0,
                'NameSimply', w0,
                'ForeignName1', w0,
                'ForeignName2', w0,
                'Check1', w0,
                'Check2', w0,
                'Check3', w0,
                'Check4', w0,
                'Check5', w0,
                'Check6', w0,
                'Check7', w0,
                'Check8', w0,
                'Check9', w0,
                'Check10', w0,
                'CheckName1', w0,
                'CheckName2', w0,
                'CheckName3', w0,
                'CheckName4', w0,
                'CheckName5', w0,
                'CheckName6', w0,
                'CheckName7', w0,
                'CheckName8', w0,
                'CheckName9', w0,
                'CheckName10', w0,
                'InchargeInsert', w0,
                'InchargeUpdate', w0,
                'DateInsert', w0,
                'DateUpdate', w0,
                'TimeInsert', w0,
                'TimeUpdate', w0,
                'TimeLast', w0,
                'CheckSync', w0,
                'CheckUse', w0,
                'TableAcc', w0,
                'TypeDm', w0,
                'KeyDm', w0,
                'ValueDm', w0,
                'Remark', w0,
                'SeSite', w0,
                'CdSite', w0
            ]);
        }
    }
}
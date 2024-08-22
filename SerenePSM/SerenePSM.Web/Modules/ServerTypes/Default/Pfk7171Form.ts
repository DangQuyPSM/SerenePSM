import { Pfk7171Dialog } from "@/Default/Pfk7171/Pfk7171Dialog";
import { LookupEditor, StringEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface Pfk7171Form {
    BasicCode: LookupEditor;
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

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = DecimalEditor;

            initFormType(Pfk7171Form, [
                'BasicCode', w0,
                'NameHlpButton', w1,
                'DisplaySeq', w2,
                'DevelopmentCode', w1,
                'SeBasicMaster', w1,
                'CdBasicMaster', w1,
                'BasicName', w1,
                'NameSimply', w1,
                'ForeignName1', w1,
                'ForeignName2', w1,
                'Check1', w1,
                'Check2', w1,
                'Check3', w1,
                'Check4', w1,
                'Check5', w1,
                'Check6', w1,
                'Check7', w1,
                'Check8', w1,
                'Check9', w1,
                'Check10', w1,
                'CheckName1', w1,
                'CheckName2', w1,
                'CheckName3', w1,
                'CheckName4', w1,
                'CheckName5', w1,
                'CheckName6', w1,
                'CheckName7', w1,
                'CheckName8', w1,
                'CheckName9', w1,
                'CheckName10', w1,
                'InchargeInsert', w1,
                'InchargeUpdate', w1,
                'DateInsert', w1,
                'DateUpdate', w1,
                'TimeInsert', w1,
                'TimeUpdate', w1,
                'TimeLast', w1,
                'CheckSync', w1,
                'CheckUse', w1,
                'TableAcc', w1,
                'TypeDm', w1,
                'KeyDm', w1,
                'ValueDm', w1,
                'Remark', w1,
                'SeSite', w1,
                'CdSite', w1
            ]);
        }
    }
}

[Pfk7171Dialog]; // referenced types
import { StringEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface Pfk7121Form {
    ColorName: StringEditor;
    ColorNameS1: StringEditor;
    ColorNameS2: StringEditor;
    ColorNameSimple: StringEditor;
    CustomerCode: StringEditor;
    SeColorBase: StringEditor;
    CdColorBase: StringEditor;
    SeColorCategory: StringEditor;
    CdColorCategory: StringEditor;
    ColorPosition: StringEditor;
    CheckBase: StringEditor;
    CheckUse: BooleanEditor;
    DateInsert: StringEditor;
    DateUpdate: StringEditor;
    InchargeInsert: StringEditor;
    InchargeUpdate: StringEditor;
    Remark: StringEditor;
    SeSite: StringEditor;
    CdSite: StringEditor;
}

export class Pfk7121Form extends PrefixedContext {
    static readonly formKey = 'Default.Pfk7121';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!Pfk7121Form.init)  {
            Pfk7121Form.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;

            initFormType(Pfk7121Form, [
                'ColorName', w0,
                'ColorNameS1', w0,
                'ColorNameS2', w0,
                'ColorNameSimple', w0,
                'CustomerCode', w0,
                'SeColorBase', w0,
                'CdColorBase', w0,
                'SeColorCategory', w0,
                'CdColorCategory', w0,
                'ColorPosition', w0,
                'CheckBase', w0,
                'CheckUse', w1,
                'DateInsert', w0,
                'DateUpdate', w0,
                'InchargeInsert', w0,
                'InchargeUpdate', w0,
                'Remark', w0,
                'SeSite', w0,
                'CdSite', w0
            ]);
        }
    }
}
import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { StringEditor, DecimalEditor } from "serenity.corelib";

export interface Pfk7103Form {
    PreFix: StringEditor;
    TypeCode: StringEditor;
    SeTypeCode: StringEditor;
    CdTypeCode: StringEditor;
    SeComponentType: StringEditor;
    CdComponentType: StringEditor;
    TypeName: StringEditor;
    TypeNameRelation: StringEditor;
    TypeSimpleName: StringEditor;
    CustomerCode: StringEditor;
    ValueType1: StringEditor;
    QtyBatchS: DecimalEditor;
    QtyDay: DecimalEditor;
    QtyDayS: DecimalEditor;
    QtyMan: DecimalEditor;
    AmtAllowance: DecimalEditor;
    Standard: StringEditor;
    Standard1: StringEditor;
    Standard2: StringEditor;
    Standard3: StringEditor;
    Standard4: StringEditor;
    Standard5: StringEditor;
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

export class Pfk7103Form extends PrefixedContext {
    static readonly formKey = 'Default.Pfk7103';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!Pfk7103Form.init)  {
            Pfk7103Form.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;

            initFormType(Pfk7103Form, [
                'PreFix', w0,
                'TypeCode', w0,
                'SeTypeCode', w0,
                'CdTypeCode', w0,
                'SeComponentType', w0,
                'CdComponentType', w0,
                'TypeName', w0,
                'TypeNameRelation', w0,
                'TypeSimpleName', w0,
                'CustomerCode', w0,
                'ValueType1', w0,
                'QtyBatchS', w1,
                'QtyDay', w1,
                'QtyDayS', w1,
                'QtyMan', w1,
                'AmtAllowance', w1,
                'Standard', w0,
                'Standard1', w0,
                'Standard2', w0,
                'Standard3', w0,
                'Standard4', w0,
                'Standard5', w0,
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
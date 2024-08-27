import { fieldsProxy } from "@serenity-is/corelib";

export interface Pfk7103Row {
    Autokey?: number;
    PreFix?: string;
    TypeCode?: string;
    SeTypeCode?: string;
    CdTypeCode?: string;
    SeComponentType?: string;
    CdComponentType?: string;
    TypeName?: string;
    TypeNameRelation?: string;
    TypeSimpleName?: string;
    CustomerCode?: string;
    ValueType1?: string;
    QtyBatchS?: number;
    QtyDay?: number;
    QtyDayS?: number;
    QtyMan?: number;
    AmtAllowance?: number;
    Standard?: string;
    Standard1?: string;
    Standard2?: string;
    Standard3?: string;
    Standard4?: string;
    Standard5?: string;
    DateInsert?: string;
    DateUpdate?: string;
    InchargeInsert?: string;
    InchargeUpdate?: string;
    CheckUse?: string;
    CheckComplete?: string;
    Remark?: string;
    SeSite?: string;
    CdSite?: string;
}

export abstract class Pfk7103Row {
    static readonly idProperty = 'Autokey';
    static readonly nameProperty = 'PreFix';
    static readonly localTextPrefix = 'Default.Pfk7103';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<Pfk7103Row>();
}
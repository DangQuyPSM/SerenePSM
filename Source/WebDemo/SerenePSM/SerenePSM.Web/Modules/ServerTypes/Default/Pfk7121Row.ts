import { fieldsProxy } from "@serenity-is/corelib";

export interface Pfk7121Row {
    ColorCode?: string;
    ColorName?: string;
    ColorNameS1?: string;
    ColorNameS2?: string;
    ColorNameSimple?: string;
    CustomerCode?: string;
    SeColorBase?: string;
    CdColorBase?: string;
    SeColorCategory?: string;
    CdColorCategory?: string;
    ColorPosition?: string;
    CheckBase?: string;
    CheckUse?: boolean;
    DateInsert?: string;
    DateUpdate?: string;
    InchargeInsert?: string;
    InchargeUpdate?: string;
    Remark?: string;
    SeSite?: string;
    CdSite?: string;
}

export abstract class Pfk7121Row {
    static readonly idProperty = 'ColorCode';
    static readonly nameProperty = 'ColorCode';
    static readonly localTextPrefix = 'Default.Pfk7121';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<Pfk7121Row>();
}
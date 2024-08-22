import { fieldsProxy } from "@serenity-is/corelib";

export interface Pfk7171Row {
    BasicCode?: string;
    K7171_BasicSel?: string;
    NameHlpButton?: string;
    DisplaySeq?: number;
    DevelopmentCode?: string;
    SeBasicMaster?: string;
    CdBasicMaster?: string;
    BasicName?: string;
    NameSimply?: string;
    ForeignName1?: string;
    ForeignName2?: string;
    Check1?: string;
    Check2?: string;
    Check3?: string;
    Check4?: string;
    Check5?: string;
    Check6?: string;
    Check7?: string;
    Check8?: string;
    Check9?: string;
    Check10?: string;
    CheckName1?: string;
    CheckName2?: string;
    CheckName3?: string;
    CheckName4?: string;
    CheckName5?: string;
    CheckName6?: string;
    CheckName7?: string;
    CheckName8?: string;
    CheckName9?: string;
    CheckName10?: string;
    InchargeInsert?: string;
    InchargeUpdate?: string;
    DateInsert?: string;
    DateUpdate?: string;
    TimeInsert?: string;
    TimeUpdate?: string;
    TimeLast?: string;
    CheckSync?: string;
    CheckUse?: string;
    TableAcc?: string;
    TypeDm?: string;
    KeyDm?: string;
    ValueDm?: string;
    Remark?: string;
    SeSite?: string;
    CdSite?: string;
}

export abstract class Pfk7171Row {
    static readonly idProperty = 'BasicCode';
    static readonly nameProperty = 'BasicName';
    static readonly localTextPrefix = 'Default.Pfk7171';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<Pfk7171Row>();
}
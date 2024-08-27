import { fieldsProxy } from "@serenity-is/corelib";

export interface Pfk7104Row {
    SizeRange?: string;
    SeSizeGroup?: string;
    CdSizeGroup?: string;
    CustomerCode?: string;
    SizeRangeName?: string;
    SizeRangeSimpleName?: string;
    SeGender?: string;
    CdGender?: string;
    SeSeason?: string;
    CdSeason?: string;
    SizeAverage01?: string;
    SizeAverage02?: string;
    SizeAverage03?: string;
    SizeAverage04?: string;
    SizeAverage05?: string;
    Size01?: string;
    Size02?: string;
    Size03?: string;
    Size04?: string;
    Size05?: string;
    Size06?: string;
    Size07?: string;
    Size08?: string;
    Size09?: string;
    Size10?: string;
    Size11?: string;
    Size12?: string;
    Size13?: string;
    Size14?: string;
    Size15?: string;
    Size16?: string;
    Size17?: string;
    Size18?: string;
    Size19?: string;
    Size20?: string;
    Size21?: string;
    Size22?: string;
    Size23?: string;
    Size24?: string;
    Size25?: string;
    Size26?: string;
    Size27?: string;
    Size28?: string;
    Size29?: string;
    Size30?: string;
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

export abstract class Pfk7104Row {
    static readonly idProperty = 'SizeRange';
    static readonly nameProperty = 'SizeRange';
    static readonly localTextPrefix = 'Default.Pfk7104';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<Pfk7104Row>();
}
import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { Pfk7104Row } from "./Pfk7104Row";

export interface Pfk7104Columns {
    SizeRange: Column<Pfk7104Row>;
    SeSizeGroup: Column<Pfk7104Row>;
    CdSizeGroup: Column<Pfk7104Row>;
    CustomerCode: Column<Pfk7104Row>;
    SizeRangeName: Column<Pfk7104Row>;
    SizeRangeSimpleName: Column<Pfk7104Row>;
    SeGender: Column<Pfk7104Row>;
    CdGender: Column<Pfk7104Row>;
    SeSeason: Column<Pfk7104Row>;
    CdSeason: Column<Pfk7104Row>;
    SizeAverage01: Column<Pfk7104Row>;
    SizeAverage02: Column<Pfk7104Row>;
    SizeAverage03: Column<Pfk7104Row>;
    SizeAverage04: Column<Pfk7104Row>;
    SizeAverage05: Column<Pfk7104Row>;
    Size01: Column<Pfk7104Row>;
    Size02: Column<Pfk7104Row>;
    Size03: Column<Pfk7104Row>;
    Size04: Column<Pfk7104Row>;
    Size05: Column<Pfk7104Row>;
    Size06: Column<Pfk7104Row>;
    Size07: Column<Pfk7104Row>;
    Size08: Column<Pfk7104Row>;
    Size09: Column<Pfk7104Row>;
    Size10: Column<Pfk7104Row>;
    Size11: Column<Pfk7104Row>;
    Size12: Column<Pfk7104Row>;
    Size13: Column<Pfk7104Row>;
    Size14: Column<Pfk7104Row>;
    Size15: Column<Pfk7104Row>;
    Size16: Column<Pfk7104Row>;
    Size17: Column<Pfk7104Row>;
    Size18: Column<Pfk7104Row>;
    Size19: Column<Pfk7104Row>;
    Size20: Column<Pfk7104Row>;
    Size21: Column<Pfk7104Row>;
    Size22: Column<Pfk7104Row>;
    Size23: Column<Pfk7104Row>;
    Size24: Column<Pfk7104Row>;
    Size25: Column<Pfk7104Row>;
    Size26: Column<Pfk7104Row>;
    Size27: Column<Pfk7104Row>;
    Size28: Column<Pfk7104Row>;
    Size29: Column<Pfk7104Row>;
    Size30: Column<Pfk7104Row>;
    DateInsert: Column<Pfk7104Row>;
    DateUpdate: Column<Pfk7104Row>;
    InchargeInsert: Column<Pfk7104Row>;
    InchargeUpdate: Column<Pfk7104Row>;
    CheckUse: Column<Pfk7104Row>;
    CheckComplete: Column<Pfk7104Row>;
    Remark: Column<Pfk7104Row>;
    SeSite: Column<Pfk7104Row>;
    CdSite: Column<Pfk7104Row>;
}

export class Pfk7104Columns extends ColumnsBase<Pfk7104Row> {
    static readonly columnsKey = 'Default.Pfk7104';
    static readonly Fields = fieldsProxy<Pfk7104Columns>();
}
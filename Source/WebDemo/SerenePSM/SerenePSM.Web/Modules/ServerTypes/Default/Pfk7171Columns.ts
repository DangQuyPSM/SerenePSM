import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { Pfk7171Row } from "./Pfk7171Row";

export interface Pfk7171Columns {
    BasicSel: Column<Pfk7171Row>;
    BasicCode: Column<Pfk7171Row>;
    BasicName: Column<Pfk7171Row>;
    NameHlpButton: Column<Pfk7171Row>;
    DisplaySeq: Column<Pfk7171Row>;
    DevelopmentCode: Column<Pfk7171Row>;
    SeBasicMaster: Column<Pfk7171Row>;
    CdBasicMaster: Column<Pfk7171Row>;
    NameSimply: Column<Pfk7171Row>;
    ForeignName1: Column<Pfk7171Row>;
    ForeignName2: Column<Pfk7171Row>;
    Check1: Column<Pfk7171Row>;
    Check2: Column<Pfk7171Row>;
    Check3: Column<Pfk7171Row>;
    Check4: Column<Pfk7171Row>;
    Check5: Column<Pfk7171Row>;
    Check6: Column<Pfk7171Row>;
    Check7: Column<Pfk7171Row>;
    Check8: Column<Pfk7171Row>;
    Check9: Column<Pfk7171Row>;
    Check10: Column<Pfk7171Row>;
    CheckName1: Column<Pfk7171Row>;
    CheckName2: Column<Pfk7171Row>;
    CheckName3: Column<Pfk7171Row>;
    CheckName4: Column<Pfk7171Row>;
    CheckName5: Column<Pfk7171Row>;
    CheckName6: Column<Pfk7171Row>;
    CheckName7: Column<Pfk7171Row>;
    CheckName8: Column<Pfk7171Row>;
    CheckName9: Column<Pfk7171Row>;
    CheckName10: Column<Pfk7171Row>;
    InchargeInsert: Column<Pfk7171Row>;
    InchargeUpdate: Column<Pfk7171Row>;
    DateInsert: Column<Pfk7171Row>;
    DateUpdate: Column<Pfk7171Row>;
    TimeInsert: Column<Pfk7171Row>;
    TimeUpdate: Column<Pfk7171Row>;
    TimeLast: Column<Pfk7171Row>;
    CheckSync: Column<Pfk7171Row>;
    CheckUse: Column<Pfk7171Row>;
    TableAcc: Column<Pfk7171Row>;
    TypeDm: Column<Pfk7171Row>;
    KeyDm: Column<Pfk7171Row>;
    ValueDm: Column<Pfk7171Row>;
    Remark: Column<Pfk7171Row>;
    SeSite: Column<Pfk7171Row>;
    CdSite: Column<Pfk7171Row>;
}

export class Pfk7171Columns extends ColumnsBase<Pfk7171Row> {
    static readonly columnsKey = 'Default.Pfk7171';
    static readonly Fields = fieldsProxy<Pfk7171Columns>();
}
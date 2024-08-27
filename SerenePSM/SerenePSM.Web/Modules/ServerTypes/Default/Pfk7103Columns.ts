import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { Pfk7103Row } from "./Pfk7103Row";

export interface Pfk7103Columns {
    Autokey: Column<Pfk7103Row>;
    PreFix: Column<Pfk7103Row>;
    TypeCode: Column<Pfk7103Row>;
    SeTypeCode: Column<Pfk7103Row>;
    CdTypeCode: Column<Pfk7103Row>;
    SeComponentType: Column<Pfk7103Row>;
    CdComponentType: Column<Pfk7103Row>;
    TypeName: Column<Pfk7103Row>;
    TypeNameRelation: Column<Pfk7103Row>;
    TypeSimpleName: Column<Pfk7103Row>;
    CustomerCode: Column<Pfk7103Row>;
    ValueType1: Column<Pfk7103Row>;
    QtyBatchS: Column<Pfk7103Row>;
    QtyDay: Column<Pfk7103Row>;
    QtyDayS: Column<Pfk7103Row>;
    QtyMan: Column<Pfk7103Row>;
    AmtAllowance: Column<Pfk7103Row>;
    Standard: Column<Pfk7103Row>;
    Standard1: Column<Pfk7103Row>;
    Standard2: Column<Pfk7103Row>;
    Standard3: Column<Pfk7103Row>;
    Standard4: Column<Pfk7103Row>;
    Standard5: Column<Pfk7103Row>;
    DateInsert: Column<Pfk7103Row>;
    DateUpdate: Column<Pfk7103Row>;
    InchargeInsert: Column<Pfk7103Row>;
    InchargeUpdate: Column<Pfk7103Row>;
    CheckUse: Column<Pfk7103Row>;
    CheckComplete: Column<Pfk7103Row>;
    Remark: Column<Pfk7103Row>;
    SeSite: Column<Pfk7103Row>;
    CdSite: Column<Pfk7103Row>;
}

export class Pfk7103Columns extends ColumnsBase<Pfk7103Row> {
    static readonly columnsKey = 'Default.Pfk7103';
    static readonly Fields = fieldsProxy<Pfk7103Columns>();
}
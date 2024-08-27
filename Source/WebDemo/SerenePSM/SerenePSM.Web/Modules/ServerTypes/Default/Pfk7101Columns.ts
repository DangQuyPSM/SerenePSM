import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { Pfk7101Row } from "./Pfk7101Row";

export interface Pfk7101Columns {
    DevelopmentCode: Column<Pfk7101Row>;
    CustomerNameSimply: Column<Pfk7101Row>;
    CustomerName: Column<Pfk7101Row>;
    Representative: Column<Pfk7101Row>;
    FaxNo: Column<Pfk7101Row>;
    AddressNo: Column<Pfk7101Row>;
    TelephoneCompany: Column<Pfk7101Row>;
    Email: Column<Pfk7101Row>;
}

export class Pfk7101Columns extends ColumnsBase<Pfk7101Row> {
    static readonly columnsKey = 'Default.Pfk7101';
    static readonly Fields = fieldsProxy<Pfk7101Columns>();
}
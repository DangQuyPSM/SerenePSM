import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { Pfk7411Row } from "./Pfk7411Row";

export interface Pfk7411Columns {
    Idno: Column<Pfk7411Row>;
    Name: Column<Pfk7411Row>;
    IdCard: Column<Pfk7411Row>;
    IdhrCode: Column<Pfk7411Row>;
    SeNationality: Column<Pfk7411Row>;
    SeDepartment: Column<Pfk7411Row>;
    SePosition: Column<Pfk7411Row>;
}

export class Pfk7411Columns extends ColumnsBase<Pfk7411Row> {
    static readonly columnsKey = 'Default.Pfk7411';
    static readonly Fields = fieldsProxy<Pfk7411Columns>();
}
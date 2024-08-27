import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { Pfk7231Row } from "./Pfk7231Row";

export interface Pfk7231Columns {
    MaterialCode: Column<Pfk7231Row>;
    MaterialPName: Column<Pfk7231Row>;
    MaterialSimple: Column<Pfk7231Row>;
    Hscode: Column<Pfk7231Row>;
    MaterialName: Column<Pfk7231Row>;
    ImportCode: Column<Pfk7231Row>;
    Width: Column<Pfk7231Row>;
    SeUnitPrice: Column<Pfk7231Row>;
    SeUnitPacking: Column<Pfk7231Row>;
    DateInsert: Column<Pfk7231Row>;
    QtyBasic: Column<Pfk7231Row>;
    MaxInventory: Column<Pfk7231Row>;
    MinInventory: Column<Pfk7231Row>;
    CheckUse: Column<Pfk7231Row>;
}

export class Pfk7231Columns extends ColumnsBase<Pfk7231Row> {
    static readonly columnsKey = 'Default.Pfk7231';
    static readonly Fields = fieldsProxy<Pfk7231Columns>();
}
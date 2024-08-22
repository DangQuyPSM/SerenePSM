import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { Pfk7121Row } from "./Pfk7121Row";

export interface Pfk7121Columns {
    ColorCode: Column<Pfk7121Row>;
    ColorName: Column<Pfk7121Row>;
    ColorNameS1: Column<Pfk7121Row>;
    CdColorCategory: Column<Pfk7121Row>;
    ColorPosition: Column<Pfk7121Row>;
    CustomerCode: Column<Pfk7121Row>;
    CheckUse: Column<Pfk7121Row>;
    Remark: Column<Pfk7121Row>;
}

export class Pfk7121Columns extends ColumnsBase<Pfk7121Row> {
    static readonly columnsKey = 'Default.Pfk7121';
    static readonly Fields = fieldsProxy<Pfk7121Columns>();
}
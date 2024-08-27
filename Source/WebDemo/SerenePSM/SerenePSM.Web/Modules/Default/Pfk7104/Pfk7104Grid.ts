import { Pfk7104Columns, Pfk7104Row, Pfk7104Service } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { Pfk7104Dialog } from './Pfk7104Dialog';

@Decorators.registerClass('SerenePSM.Default.Pfk7104Grid')
export class Pfk7104Grid extends EntityGrid<Pfk7104Row> {
    protected getColumnsKey() { return Pfk7104Columns.columnsKey; }
    protected getDialogType() { return Pfk7104Dialog; }
    protected getRowDefinition() { return Pfk7104Row; }
    protected getService() { return Pfk7104Service.baseUrl; }
}
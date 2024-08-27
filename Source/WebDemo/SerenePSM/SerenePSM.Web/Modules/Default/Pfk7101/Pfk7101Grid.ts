import { Pfk7101Columns, Pfk7101Row, Pfk7101Service } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { Pfk7101Dialog } from './Pfk7101Dialog';

@Decorators.registerClass('SerenePSM.Default.Pfk7101Grid')
export class Pfk7101Grid extends EntityGrid<Pfk7101Row> {
    protected getColumnsKey() { return Pfk7101Columns.columnsKey; }
    protected getDialogType() { return Pfk7101Dialog; }
    protected getRowDefinition() { return Pfk7101Row; }
    protected getService() { return Pfk7101Service.baseUrl; }
}
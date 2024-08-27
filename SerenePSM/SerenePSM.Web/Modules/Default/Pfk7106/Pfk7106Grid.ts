import { Pfk7106Columns, Pfk7106Row, Pfk7106Service } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { Pfk7106Dialog } from './Pfk7106Dialog';

@Decorators.registerClass('SerenePSM.Default.Pfk7106Grid')
export class Pfk7106Grid extends EntityGrid<Pfk7106Row> {
    protected getColumnsKey() { return Pfk7106Columns.columnsKey; }
    protected getDialogType() { return Pfk7106Dialog; }
    protected getRowDefinition() { return Pfk7106Row; }
    protected getService() { return Pfk7106Service.baseUrl; }
}
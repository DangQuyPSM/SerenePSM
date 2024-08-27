import { Pfk7105Columns, Pfk7105Row, Pfk7105Service } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { Pfk7105Dialog } from './Pfk7105Dialog';

@Decorators.registerClass('SerenePSM.Default.Pfk7105Grid')
export class Pfk7105Grid extends EntityGrid<Pfk7105Row> {
    protected getColumnsKey() { return Pfk7105Columns.columnsKey; }
    protected getDialogType() { return Pfk7105Dialog; }
    protected getRowDefinition() { return Pfk7105Row; }
    protected getService() { return Pfk7105Service.baseUrl; }
}
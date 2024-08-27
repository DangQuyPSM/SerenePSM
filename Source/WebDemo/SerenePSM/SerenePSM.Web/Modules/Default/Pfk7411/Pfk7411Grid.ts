import { Pfk7411Columns, Pfk7411Row, Pfk7411Service } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { Pfk7411Dialog } from './Pfk7411Dialog';

@Decorators.registerClass('SerenePSM.Default.Pfk7411Grid')
export class Pfk7411Grid extends EntityGrid<Pfk7411Row> {
    protected getColumnsKey() { return Pfk7411Columns.columnsKey; }
    protected getDialogType() { return Pfk7411Dialog; }
    protected getRowDefinition() { return Pfk7411Row; }
    protected getService() { return Pfk7411Service.baseUrl; }
}
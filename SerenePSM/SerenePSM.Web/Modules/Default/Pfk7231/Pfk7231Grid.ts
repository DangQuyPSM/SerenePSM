import { Pfk7231Columns, Pfk7231Row, Pfk7231Service } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { Pfk7231Dialog } from './Pfk7231Dialog';

@Decorators.registerClass('SerenePSM.Default.Pfk7231Grid')
export class Pfk7231Grid extends EntityGrid<Pfk7231Row> {
    protected getColumnsKey() { return Pfk7231Columns.columnsKey; }
    protected getDialogType() { return Pfk7231Dialog; }
    protected getRowDefinition() { return Pfk7231Row; }
    protected getService() { return Pfk7231Service.baseUrl; }
}
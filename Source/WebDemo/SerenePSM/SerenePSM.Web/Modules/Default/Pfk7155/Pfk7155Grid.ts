import { Pfk7155Columns, Pfk7155Row, Pfk7155Service } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { Pfk7155Dialog } from './Pfk7155Dialog';

@Decorators.registerClass('SerenePSM.Default.Pfk7155Grid')
export class Pfk7155Grid extends EntityGrid<Pfk7155Row> {
    protected getColumnsKey() { return Pfk7155Columns.columnsKey; }
    protected getDialogType() { return Pfk7155Dialog; }
    protected getRowDefinition() { return Pfk7155Row; }
    protected getService() { return Pfk7155Service.baseUrl; }
}
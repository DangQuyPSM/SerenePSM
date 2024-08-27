import { Pfk7171Columns, Pfk7171Row, Pfk7171Service } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { Pfk7171Dialog } from './Pfk7171Dialog';

@Decorators.registerClass('SerenePSM.Default.Pfk7171Grid')
export class Pfk7171Grid extends EntityGrid<Pfk7171Row> {
    protected getColumnsKey() { return Pfk7171Columns.columnsKey; }
    protected getDialogType() { return Pfk7171Dialog; }
    protected getRowDefinition() { return Pfk7171Row; }
    protected getService() { return Pfk7171Service.baseUrl; }
}
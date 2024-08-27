import { Pfk7103Columns, Pfk7103Row, Pfk7103Service } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { Pfk7103Dialog } from './Pfk7103Dialog';

@Decorators.registerClass('SerenePSM.Default.Pfk7103Grid')
export class Pfk7103Grid extends EntityGrid<Pfk7103Row> {
    protected getColumnsKey() { return Pfk7103Columns.columnsKey; }
    protected getDialogType() { return Pfk7103Dialog; }
    protected getRowDefinition() { return Pfk7103Row; }
    protected getService() { return Pfk7103Service.baseUrl; }
}
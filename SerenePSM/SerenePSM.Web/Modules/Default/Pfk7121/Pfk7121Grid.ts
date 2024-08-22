import { Pfk7121Columns, Pfk7121Row, Pfk7121Service } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { Pfk7121Dialog } from './Pfk7121Dialog';

@Decorators.registerClass('SerenePSM.Default.Pfk7121Grid')
export class Pfk7121Grid extends EntityGrid<Pfk7121Row> {
    protected getColumnsKey() { return Pfk7121Columns.columnsKey; }
    protected getDialogType() { return Pfk7121Dialog; }
    protected getRowDefinition() { return Pfk7121Row; }
    protected getService() { return Pfk7121Service.baseUrl; }
}
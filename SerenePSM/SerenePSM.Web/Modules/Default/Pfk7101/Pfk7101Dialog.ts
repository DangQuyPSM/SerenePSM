import { Pfk7101Form, Pfk7101Row, Pfk7101Service } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('SerenePSM.Default.Pfk7101Dialog')
export class Pfk7101Dialog extends EntityDialog<Pfk7101Row, any> {
    protected getFormKey() { return Pfk7101Form.formKey; }
    protected getRowDefinition() { return Pfk7101Row; }
    protected getService() { return Pfk7101Service.baseUrl; }

    protected form = new Pfk7101Form(this.idPrefix);
}
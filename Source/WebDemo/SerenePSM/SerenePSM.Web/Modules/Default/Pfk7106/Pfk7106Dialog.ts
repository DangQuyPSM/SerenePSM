import { Pfk7106Form, Pfk7106Row, Pfk7106Service } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('SerenePSM.Default.Pfk7106Dialog')
export class Pfk7106Dialog extends EntityDialog<Pfk7106Row, any> {
    protected getFormKey() { return Pfk7106Form.formKey; }
    protected getRowDefinition() { return Pfk7106Row; }
    protected getService() { return Pfk7106Service.baseUrl; }

    protected form = new Pfk7106Form(this.idPrefix);
}
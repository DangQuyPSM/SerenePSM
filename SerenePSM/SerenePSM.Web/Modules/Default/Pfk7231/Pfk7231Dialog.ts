import { Pfk7231Form, Pfk7231Row, Pfk7231Service } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('SerenePSM.Default.Pfk7231Dialog')
export class Pfk7231Dialog extends EntityDialog<Pfk7231Row, any> {
    protected getFormKey() { return Pfk7231Form.formKey; }
    protected getRowDefinition() { return Pfk7231Row; }
    protected getService() { return Pfk7231Service.baseUrl; }

    protected form = new Pfk7231Form(this.idPrefix);
}
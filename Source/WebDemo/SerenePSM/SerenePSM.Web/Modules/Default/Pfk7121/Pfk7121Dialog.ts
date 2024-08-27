import { Pfk7121Form, Pfk7121Row, Pfk7121Service } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('SerenePSM.Default.Pfk7121Dialog')
export class Pfk7121Dialog extends EntityDialog<Pfk7121Row, any> {
    protected getFormKey() { return Pfk7121Form.formKey; }
    protected getRowDefinition() { return Pfk7121Row; }
    protected getService() { return Pfk7121Service.baseUrl; }

    protected form = new Pfk7121Form(this.idPrefix);
}
import { Pfk7411Form, Pfk7411Row, Pfk7411Service } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('SerenePSM.Default.Pfk7411Dialog')
export class Pfk7411Dialog extends EntityDialog<Pfk7411Row, any> {
    protected getFormKey() { return Pfk7411Form.formKey; }
    protected getRowDefinition() { return Pfk7411Row; }
    protected getService() { return Pfk7411Service.baseUrl; }

    protected form = new Pfk7411Form(this.idPrefix);
}
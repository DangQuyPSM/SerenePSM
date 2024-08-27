import { Pfk7104Form, Pfk7104Row, Pfk7104Service } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('SerenePSM.Default.Pfk7104Dialog')
export class Pfk7104Dialog extends EntityDialog<Pfk7104Row, any> {
    protected getFormKey() { return Pfk7104Form.formKey; }
    protected getRowDefinition() { return Pfk7104Row; }
    protected getService() { return Pfk7104Service.baseUrl; }

    protected form = new Pfk7104Form(this.idPrefix);
}
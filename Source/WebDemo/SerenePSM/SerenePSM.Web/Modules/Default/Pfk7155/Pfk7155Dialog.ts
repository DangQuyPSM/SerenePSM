import { Pfk7155Form, Pfk7155Row, Pfk7155Service } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('SerenePSM.Default.Pfk7155Dialog')
export class Pfk7155Dialog extends EntityDialog<Pfk7155Row, any> {
    protected getFormKey() { return Pfk7155Form.formKey; }
    protected getRowDefinition() { return Pfk7155Row; }
    protected getService() { return Pfk7155Service.baseUrl; }

    protected form = new Pfk7155Form(this.idPrefix);
}
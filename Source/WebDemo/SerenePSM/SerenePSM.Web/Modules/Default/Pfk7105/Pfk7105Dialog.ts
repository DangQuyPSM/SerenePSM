import { Pfk7105Form, Pfk7105Row, Pfk7105Service } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('SerenePSM.Default.Pfk7105Dialog')
export class Pfk7105Dialog extends EntityDialog<Pfk7105Row, any> {
    protected getFormKey() { return Pfk7105Form.formKey; }
    protected getRowDefinition() { return Pfk7105Row; }
    protected getService() { return Pfk7105Service.baseUrl; }

    protected form = new Pfk7105Form(this.idPrefix);
}
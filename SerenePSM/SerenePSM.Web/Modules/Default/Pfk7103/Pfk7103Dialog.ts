import { Pfk7103Form, Pfk7103Row, Pfk7103Service } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('SerenePSM.Default.Pfk7103Dialog')
export class Pfk7103Dialog extends EntityDialog<Pfk7103Row, any> {
    protected getFormKey() { return Pfk7103Form.formKey; }
    protected getRowDefinition() { return Pfk7103Row; }
    protected getService() { return Pfk7103Service.baseUrl; }

    protected form = new Pfk7103Form(this.idPrefix);
}
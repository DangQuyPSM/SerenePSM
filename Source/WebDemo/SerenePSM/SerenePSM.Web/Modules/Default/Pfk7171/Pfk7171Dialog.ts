import { Pfk7171Form, Pfk7171Row, Pfk7171Service } from '@/ServerTypes/Default';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('SerenePSM.Default.Pfk7171Dialog')
export class Pfk7171Dialog extends EntityDialog<Pfk7171Row, any> {
    protected getFormKey() { return Pfk7171Form.formKey; }
    protected getRowDefinition() { return Pfk7171Row; }
    protected getService() { return Pfk7171Service.baseUrl; }

    protected form = new Pfk7171Form(this.idPrefix);
}
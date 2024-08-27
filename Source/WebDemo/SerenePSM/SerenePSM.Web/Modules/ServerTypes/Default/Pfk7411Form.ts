import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { StringEditor, DecimalEditor } from "serenity.corelib";

export interface Pfk7411Form {
    DevelopmenetCode: StringEditor;
    IdCard: StringEditor;
    IdhrCode: StringEditor;
    UserId: StringEditor;
    PassWord: StringEditor;
    Name: StringEditor;
    ForeignName: StringEditor;
    SeSite: StringEditor;
    CdSite: StringEditor;
    SeMainProcess: StringEditor;
    CdMainProcess: StringEditor;
    SeSubProcess: StringEditor;
    CdSubProcess: StringEditor;
    SeNationality: StringEditor;
    CdNationality: StringEditor;
    SeDepartment: StringEditor;
    CdDepartment: StringEditor;
    SeOnePosition: StringEditor;
    CdOnePosition: StringEditor;
    SePosition: StringEditor;
    CdPosition: StringEditor;
    SeInCharge: StringEditor;
    CdInCharge: StringEditor;
    SeFactory: StringEditor;
    CdFactory: StringEditor;
    SeLineProd: StringEditor;
    CdLineProd: StringEditor;
    Email: StringEditor;
    Mobile: StringEditor;
    Gender: StringEditor;
    SendEmail: StringEditor;
    SendSms: StringEditor;
    SendFax: StringEditor;
    Locked: StringEditor;
    OpenCdt: StringEditor;
    OpenPrvDays: StringEditor;
    OpenRate: StringEditor;
    OpenSchedule: StringEditor;
    OpenAlert: StringEditor;
    OpenMessage: StringEditor;
    ScreenLock: DecimalEditor;
    Idcd: StringEditor;
    Dgcd: StringEditor;
    Gnid: StringEditor;
    DateInsert: StringEditor;
    DateUpdate: StringEditor;
    InchargeInsert: StringEditor;
    InchargeUpdate: StringEditor;
    DateActive: StringEditor;
    DateDeactive: StringEditor;
    CheckActive: StringEditor;
    FirstChangePass: StringEditor;
    LastPass: StringEditor;
    LastPass1: StringEditor;
    LastPass2: StringEditor;
    FailLoginCnt: DecimalEditor;
    CheckNever: StringEditor;
    LastLogin: StringEditor;
    LastTime: StringEditor;
    CheckOption1: StringEditor;
    CheckOption2: StringEditor;
    CheckOption3: StringEditor;
    CheckOption4: StringEditor;
    CheckOption5: StringEditor;
    CheckUse: StringEditor;
    DepName: StringEditor;
    EmpTypeName: StringEditor;
    PosName: StringEditor;
    LineName: StringEditor;
    TeamName: StringEditor;
    PartName: StringEditor;
    CheckDev: StringEditor;
}

export class Pfk7411Form extends PrefixedContext {
    static readonly formKey = 'Default.Pfk7411';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!Pfk7411Form.init)  {
            Pfk7411Form.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;

            initFormType(Pfk7411Form, [
                'DevelopmenetCode', w0,
                'IdCard', w0,
                'IdhrCode', w0,
                'UserId', w0,
                'PassWord', w0,
                'Name', w0,
                'ForeignName', w0,
                'SeSite', w0,
                'CdSite', w0,
                'SeMainProcess', w0,
                'CdMainProcess', w0,
                'SeSubProcess', w0,
                'CdSubProcess', w0,
                'SeNationality', w0,
                'CdNationality', w0,
                'SeDepartment', w0,
                'CdDepartment', w0,
                'SeOnePosition', w0,
                'CdOnePosition', w0,
                'SePosition', w0,
                'CdPosition', w0,
                'SeInCharge', w0,
                'CdInCharge', w0,
                'SeFactory', w0,
                'CdFactory', w0,
                'SeLineProd', w0,
                'CdLineProd', w0,
                'Email', w0,
                'Mobile', w0,
                'Gender', w0,
                'SendEmail', w0,
                'SendSms', w0,
                'SendFax', w0,
                'Locked', w0,
                'OpenCdt', w0,
                'OpenPrvDays', w0,
                'OpenRate', w0,
                'OpenSchedule', w0,
                'OpenAlert', w0,
                'OpenMessage', w0,
                'ScreenLock', w1,
                'Idcd', w0,
                'Dgcd', w0,
                'Gnid', w0,
                'DateInsert', w0,
                'DateUpdate', w0,
                'InchargeInsert', w0,
                'InchargeUpdate', w0,
                'DateActive', w0,
                'DateDeactive', w0,
                'CheckActive', w0,
                'FirstChangePass', w0,
                'LastPass', w0,
                'LastPass1', w0,
                'LastPass2', w0,
                'FailLoginCnt', w1,
                'CheckNever', w0,
                'LastLogin', w0,
                'LastTime', w0,
                'CheckOption1', w0,
                'CheckOption2', w0,
                'CheckOption3', w0,
                'CheckOption4', w0,
                'CheckOption5', w0,
                'CheckUse', w0,
                'DepName', w0,
                'EmpTypeName', w0,
                'PosName', w0,
                'LineName', w0,
                'TeamName', w0,
                'PartName', w0,
                'CheckDev', w0
            ]);
        }
    }
}
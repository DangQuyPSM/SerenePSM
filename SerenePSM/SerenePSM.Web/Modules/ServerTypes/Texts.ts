import { proxyTexts } from "@serenity-is/corelib";

namespace SerenePSM.Texts {

    export declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RoleName: string;
                export const RolePermissionId: string;
            }

            namespace Translation {
                export const CustomText: string;
                export const EntityPlural: string;
                export const Key: string;
                export const OverrideConfirmation: string;
                export const SaveChangesButton: string;
                export const SourceLanguage: string;
                export const SourceText: string;
                export const TargetLanguage: string;
                export const TargetText: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const RoleName: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace Default {

            namespace Genre {
                export const GenreId: string;
                export const Name: string;
            }

            namespace Movie {
                export const Description: string;
                export const Kind: string;
                export const MovieId: string;
                export const ReleaseDate: string;
                export const Runtime: string;
                export const Storyline: string;
                export const Title: string;
                export const Year: string;
            }

            namespace Pfk7101 {
                export const ACodePayable: string;
                export const ACodeReceivable: string;
                export const AccountNumber: string;
                export const Address1: string;
                export const Address2: string;
                export const AddressNo: string;
                export const BankAddress: string;
                export const BankName: string;
                export const BeneficiaryName: string;
                export const Buyer: string;
                export const Buyer1: string;
                export const CdCancelDate: string;
                export const CdCustomerDivision: string;
                export const CdCustomerLocation: string;
                export const CdDeliveryTerm: string;
                export const CdFactory: string;
                export const CdPassWord: string;
                export const CdPaymentCondition: string;
                export const CdPaymentDay: string;
                export const CdPaymentTerm: string;
                export const CdPaymentTime: string;
                export const CdPoGroup: string;
                export const CdSite: string;
                export const CdSoGroup: string;
                export const CdSupplierGroup: string;
                export const CdTaxGroup: string;
                export const CdTeam: string;
                export const CheckActive: string;
                export const CheckCustomer: string;
                export const CheckCustomerStatus: string;
                export const CheckEmployee: string;
                export const CheckInside: string;
                export const CheckKindCustomer: string;
                export const CheckOption1: string;
                export const CheckOption10: string;
                export const CheckOption2: string;
                export const CheckOption3: string;
                export const CheckOption4: string;
                export const CheckOption5: string;
                export const CheckOption6: string;
                export const CheckOption7: string;
                export const CheckOption8: string;
                export const CheckOption9: string;
                export const CheckOthers: string;
                export const CheckOutside: string;
                export const CheckSupplier: string;
                export const CheckSync: string;
                export const CheckTax: string;
                export const CheckUse: string;
                export const CompanyId: string;
                export const CompanyItem: string;
                export const CompanyType: string;
                export const Consignee: string;
                export const Consignee1: string;
                export const Country: string;
                export const CustomerCode: string;
                export const CustomerName: string;
                export const CustomerName1: string;
                export const CustomerNameSimply: string;
                export const CustomerNameSimply1: string;
                export const DateActive: string;
                export const DateApproved: string;
                export const DateCancel: string;
                export const DateComplete: string;
                export const DateDeactive: string;
                export const DateDepart: string;
                export const DateDepart1: string;
                export const DateInsert: string;
                export const DateLc: string;
                export const DateLc1: string;
                export const DatePending1: string;
                export const DatePending2: string;
                export const DateUpdate: string;
                export const Destination: string;
                export const DevelopmentCode: string;
                export const Email: string;
                export const FaceId: string;
                export const FaxNo: string;
                export const FinalShop: string;
                export const FlightNo: string;
                export const FlightNo1: string;
                export const ForeignName1: string;
                export const ForeignName2: string;
                export const InCharge: string;
                export const InChargeSale: string;
                export const InchargeInsert: string;
                export const InchargeUpdate: string;
                export const InvoiceAccount: string;
                export const LcNo: string;
                export const LcNo1: string;
                export const Notifyparty: string;
                export const Notifyparty1: string;
                export const NotifypartyAnd: string;
                export const NotifypartyAnd1: string;
                export const ParaNo1: string;
                export const ParaNo2: string;
                export const ParaNo3: string;
                export const QrCode: string;
                export const QrCodeName: string;
                export const QrCodeTel: string;
                export const Remark: string;
                export const Remarks: string;
                export const Remarks1: string;
                export const Representative: string;
                export const SeCancelDate: string;
                export const SeCustomerDivision: string;
                export const SeCustomerLocation: string;
                export const SeDeliveryTerm: string;
                export const SePassWord: string;
                export const SePaymentCondition: string;
                export const SePaymentDay: string;
                export const SePaymentTerm: string;
                export const SePaymentTime: string;
                export const SePoGroup: string;
                export const SeSite: string;
                export const SeSoGroup: string;
                export const SeSupplierGroup: string;
                export const SeTaxGroup: string;
                export const SeTeam: string;
                export const ShipFrom: string;
                export const ShipFrom1: string;
                export const ShipMark: string;
                export const ShipMark1: string;
                export const ShipTo: string;
                export const ShipTo1: string;
                export const Shipper: string;
                export const Shipper1: string;
                export const ShipperTo: string;
                export const ShipperTo1: string;
                export const SwiftCode: string;
                export const TaxExempt: string;
                export const TelephoneCompany: string;
                export const TelephoneHand: string;
                export const TermPri: string;
                export const TermPri1: string;
                export const TimeInsert: string;
                export const TimeLast: string;
                export const TimeUpdate: string;
                export const VisAllName: string;
                export const VisAllName1: string;
            }

            namespace Pfk7121 {
                export const CdColorBase: string;
                export const CdColorCategory: string;
                export const CdSite: string;
                export const CheckBase: string;
                export const CheckUse: string;
                export const ColorCode: string;
                export const ColorName: string;
                export const ColorNameS1: string;
                export const ColorNameS2: string;
                export const ColorNameSimple: string;
                export const ColorPosition: string;
                export const CustomerCode: string;
                export const DateInsert: string;
                export const DateUpdate: string;
                export const InchargeInsert: string;
                export const InchargeUpdate: string;
                export const Remark: string;
                export const SeColorBase: string;
                export const SeColorCategory: string;
                export const SeSite: string;
            }

            namespace Pfk7171 {
                export const BasicCode: string;
                export const BasicName: string;
                export const CdBasicMaster: string;
                export const CdSite: string;
                export const Check1: string;
                export const Check10: string;
                export const Check2: string;
                export const Check3: string;
                export const Check4: string;
                export const Check5: string;
                export const Check6: string;
                export const Check7: string;
                export const Check8: string;
                export const Check9: string;
                export const CheckName1: string;
                export const CheckName10: string;
                export const CheckName2: string;
                export const CheckName3: string;
                export const CheckName4: string;
                export const CheckName5: string;
                export const CheckName6: string;
                export const CheckName7: string;
                export const CheckName8: string;
                export const CheckName9: string;
                export const CheckSync: string;
                export const CheckUse: string;
                export const DateInsert: string;
                export const DateUpdate: string;
                export const DevelopmentCode: string;
                export const DisplaySeq: string;
                export const ForeignName1: string;
                export const ForeignName2: string;
                export const InchargeInsert: string;
                export const InchargeUpdate: string;
                export const K7171_BasicSel: string;
                export const KeyDm: string;
                export const NameHlpButton: string;
                export const NameSimply: string;
                export const Remark: string;
                export const SeBasicMaster: string;
                export const SeSite: string;
                export const TableAcc: string;
                export const TimeInsert: string;
                export const TimeLast: string;
                export const TimeUpdate: string;
                export const TypeDm: string;
                export const ValueDm: string;
            }

            namespace Pfk7231 {
                export const ACodeCogs: string;
                export const ACodeDiscount: string;
                export const ACodeIntSales: string;
                export const ACodeMaterial: string;
                export const ACodeReturn: string;
                export const ACodeSales: string;
                export const ACodeTax1: string;
                export const ACodeTax2: string;
                export const ACodeTax3: string;
                export const ACodeWip: string;
                export const AccountCode: string;
                export const AccountName: string;
                export const ApplyType: string;
                export const BomType: string;
                export const CdAccCogs: string;
                export const CdAccDiscount: string;
                export const CdAccIntSales: string;
                export const CdAccMaterial: string;
                export const CdAccReturn: string;
                export const CdAccSales: string;
                export const CdAccWip: string;
                export const CdDepartment: string;
                export const CdDetailGroupMaterial: string;
                export const CdImportGroup: string;
                export const CdLargeGroupMaterial: string;
                export const CdSemiGroupMaterial: string;
                export const CdSite: string;
                export const CdSpecGroup1: string;
                export const CdSpecGroup2: string;
                export const CdSpecGroup3: string;
                export const CdSpecGroup4: string;
                export const CdSpecGroup5: string;
                export const CdSpecial: string;
                export const CdTax: string;
                export const CdTax1: string;
                export const CdTax2: string;
                export const CdTax3: string;
                export const CdTaxExport: string;
                export const CdTaxImport: string;
                export const CdTaxSpecial: string;
                export const CdTaxVat: string;
                export const CdUnitMaterial: string;
                export const CdUnitPacking: string;
                export const CdUnitPrice: string;
                export const Check1: string;
                export const Check10: string;
                export const Check2: string;
                export const Check3: string;
                export const Check4: string;
                export const Check5: string;
                export const Check6: string;
                export const Check7: string;
                export const Check8: string;
                export const Check9: string;
                export const CheckActive: string;
                export const CheckDevRnD: string;
                export const CheckInventory: string;
                export const CheckKindMaterial: string;
                export const CheckLotNo: string;
                export const CheckMarketType: string;
                export const CheckName1: string;
                export const CheckName10: string;
                export const CheckName2: string;
                export const CheckName3: string;
                export const CheckName4: string;
                export const CheckName5: string;
                export const CheckName6: string;
                export const CheckName7: string;
                export const CheckName8: string;
                export const CheckName9: string;
                export const CheckPosition: string;
                export const CheckPrice: string;
                export const CheckPrint: string;
                export const CheckSp: string;
                export const CheckSync: string;
                export const CheckUse: string;
                export const DateActive: string;
                export const DateApproved: string;
                export const DateCancel: string;
                export const DateComplete: string;
                export const DateDeactive: string;
                export const DateEstimate: string;
                export const DateExchangePrice: string;
                export const DateInBound: string;
                export const DateInsert: string;
                export const DateOptimum: string;
                export const DateOutBound: string;
                export const DatePending1: string;
                export const DatePending2: string;
                export const DateStart: string;
                export const DateUpdate: string;
                export const DayEstimate: string;
                export const DayOptimum: string;
                export const DevelopmentCode: string;
                export const DevelopmentName: string;
                export const ExchangePrice: string;
                export const Height: string;
                export const Hscode: string;
                export const Hscode1: string;
                export const ImportCode: string;
                export const ImportCode1: string;
                export const ImportName: string;
                export const ImportName1: string;
                export const InchargeApproved: string;
                export const InchargeCancel: string;
                export const InchargeComplete: string;
                export const InchargeInsert: string;
                export const InchargePending1: string;
                export const InchargePending2: string;
                export const InchargeUpdate: string;
                export const LogisticCodeSg: string;
                export const MaterialCode: string;
                export const MaterialColor: string;
                export const MaterialForeign1: string;
                export const MaterialForeign2: string;
                export const MaterialFullName: string;
                export const MaterialName: string;
                export const MaterialOldName: string;
                export const MaterialPName: string;
                export const MaterialSimple: string;
                export const MaxInventory: string;
                export const MinInventory: string;
                export const OtherCode1: string;
                export const OtherCode2: string;
                export const PerTax1: string;
                export const PerTax2: string;
                export const PerTax3: string;
                export const PerTaxImport: string;
                export const PerTaxVat: string;
                export const PriceMaterial: string;
                export const PriceUsd: string;
                export const PriceVnd: string;
                export const QtyBasic: string;
                export const QtyMoq: string;
                export const QtyOptimum: string;
                export const ReOrderQty: string;
                export const Remark: string;
                export const SalesCode: string;
                export const SeAccCogs: string;
                export const SeAccDiscount: string;
                export const SeAccIntSales: string;
                export const SeAccMaterial: string;
                export const SeAccReturn: string;
                export const SeAccSales: string;
                export const SeAccWip: string;
                export const SeDepartment: string;
                export const SeDetailGroupMaterial: string;
                export const SeImportGroup: string;
                export const SeLargeGroupMaterial: string;
                export const SeSemiGroupMaterial: string;
                export const SeSite: string;
                export const SeSpecGroup1: string;
                export const SeSpecGroup2: string;
                export const SeSpecGroup3: string;
                export const SeSpecGroup4: string;
                export const SeSpecGroup5: string;
                export const SeSpecial: string;
                export const SeTax: string;
                export const SeTax1: string;
                export const SeTax2: string;
                export const SeTax3: string;
                export const SeTaxExport: string;
                export const SeTaxImport: string;
                export const SeTaxSpecial: string;
                export const SeTaxVat: string;
                export const SeUnitMaterial: string;
                export const SeUnitPacking: string;
                export const SeUnitPrice: string;
                export const SizeName: string;
                export const SizeRangeTool: string;
                export const StatusMaterial: string;
                export const SupplyCode: string;
                export const SupplyName: string;
                export const Width: string;
            }

            namespace Pfk7411 {
                export const CdDepartment: string;
                export const CdFactory: string;
                export const CdInCharge: string;
                export const CdLineProd: string;
                export const CdMainProcess: string;
                export const CdNationality: string;
                export const CdOnePosition: string;
                export const CdPosition: string;
                export const CdSite: string;
                export const CdSubProcess: string;
                export const CheckActive: string;
                export const CheckDev: string;
                export const CheckNever: string;
                export const CheckOption1: string;
                export const CheckOption2: string;
                export const CheckOption3: string;
                export const CheckOption4: string;
                export const CheckOption5: string;
                export const CheckUse: string;
                export const DateActive: string;
                export const DateDeactive: string;
                export const DateInsert: string;
                export const DateUpdate: string;
                export const DepName: string;
                export const DevelopmenetCode: string;
                export const Dgcd: string;
                export const Email: string;
                export const EmpTypeName: string;
                export const FailLoginCnt: string;
                export const FirstChangePass: string;
                export const ForeignName: string;
                export const Gender: string;
                export const Gnid: string;
                export const IdCard: string;
                export const Idcd: string;
                export const IdhrCode: string;
                export const Idno: string;
                export const InchargeInsert: string;
                export const InchargeUpdate: string;
                export const LastLogin: string;
                export const LastPass: string;
                export const LastPass1: string;
                export const LastPass2: string;
                export const LastTime: string;
                export const LineName: string;
                export const Locked: string;
                export const Mobile: string;
                export const Name: string;
                export const OpenAlert: string;
                export const OpenCdt: string;
                export const OpenMessage: string;
                export const OpenPrvDays: string;
                export const OpenRate: string;
                export const OpenSchedule: string;
                export const PartName: string;
                export const PassWord: string;
                export const PosName: string;
                export const ScreenLock: string;
                export const SeDepartment: string;
                export const SeFactory: string;
                export const SeInCharge: string;
                export const SeLineProd: string;
                export const SeMainProcess: string;
                export const SeNationality: string;
                export const SeOnePosition: string;
                export const SePosition: string;
                export const SeSite: string;
                export const SeSubProcess: string;
                export const SendEmail: string;
                export const SendFax: string;
                export const SendSms: string;
                export const TeamName: string;
                export const UserId: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace Login {
                export const ForgotPassword: string;
                export const LoginToYourAccount: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace SendActivation {
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
        export const SiteTitle: string;
    }

    export declare namespace Navigation {
        export const Dashboard: string;
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace Layout {
            export const Language: string;
            export const Theme: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const SavePrimaryKeyError: string;
    }

    SerenePSM['Texts'] = proxyTexts(Texts, '', {
        Db: {
            Administration: {
                Language: {},
                Role: {},
                RolePermission: {},
                Translation: {},
                User: {},
                UserPermission: {},
                UserRole: {}
            },
            Default: {
                Genre: {},
                Movie: {},
                Pfk7101: {},
                Pfk7121: {},
                Pfk7171: {},
                Pfk7231: {},
                Pfk7411: {}
            }
        },
        Forms: {
            Membership: {
                Login: {},
                SendActivation: {},
                SignUp: {}
            }
        },
        Navigation: {},
        Site: {
            AccessDenied: {},
            Layout: {},
            RolePermissionDialog: {},
            UserDialog: {},
            UserPermissionDialog: {},
            ValidationError: {}
        },
        Validation: {}
    }) as any;
}

export const Texts = SerenePSM.Texts;
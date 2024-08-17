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
                Pfk7101: {}
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
using AetherPal.Control.Presentation.Localization;
using System;

namespace AetherPal.Control.Presentation.Localization.English
{
    public class Control_Presentation_TechConsole_UserManagement : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }
        public string AWC_UserManagement_SearchUser_ResetPassword_Heading { get { return "Reset Password"; } }
        public string AWC_UserManagement_SearchUser_ResetPassword_NewPassword { get { return "New Password"; } }
        public string AWC_UserManagement_SearchUser_ResetPassword_OldPassword { get { return "Old Password"; } }
        public string AWC_UserManagement_UserDetails_Email { get { return "Email:"; } }
        public string AWC_UserManagement_UserDetails_IncorrectOldPassword { get { return "Incorrect Old Password"; } }
        public string AWC_UserManagement_UserDetails_NewCannotOldPassword { get { return "New password cannot be same as old password"; } }
        public string AWC_UserManagement_UserDetails_Password { get { return "Password:"; } }
        public string AWC_UserManagement_UserDetails_PasswordAlphabetAndSpecialChar { get { return "Password must include characters with alphabet and special characters."; } }
        public string AWC_UserManagement_UserDetails_PasswordAlphanumeric { get { return "Password must include characters with alphabet and numbers."; } }
        public string AWC_UserManagement_UserDetails_PasswordAlphanumericAndSpecialChar { get { return "Password must include characters from at least two (2) of these groupings:  alpha, numeric and special characters."; } }
        public string AWC_UserManagement_UserDetails_PasswordCannotUsername { get { return "Password cannot be same as username"; } }
        public string AWC_UserManagement_UserDetails_PasswordLength { get { return "Password length should be minimum {0} character(s)."; } }
        public string AWC_UserManagement_UserDetails_PasswordNumberAndSpecialChar { get { return "Password must include characters with number and special characters."; } }
        public string AWC_UserManagement_UserDetails_PasswordOnlyAlphabets { get { return "Password must contain only alphabets."; } }
        public string AWC_UserManagement_UserDetails_PasswordOnlyNumbers { get { return "Password must contain only numbers."; } }
        public string AWC_UserManagement_UserDetails_PasswordOnlySpecialChar { get { return "Password must contain only special characters."; } }
        public string AWC_UserManagement_UserDetails_ProgressPasswordReset { get { return "Resetting password..."; } }
        public string AWC_UserManagement_UserDetails_ConfirmPassword { get { return "Confirm Password"; } }
    }
}

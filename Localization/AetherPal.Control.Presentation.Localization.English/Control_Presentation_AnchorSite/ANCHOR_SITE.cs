using AetherPal.Control.Presentation.Localization;
using System;

namespace AetherPal.Control.Presentation.Localization.English
{
    public class ANCHOR_SITE : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4003; } }
        public string Accept { get { return "Accept"; } }
        public string ClickHere { get { return "click here"; } }
        public string ClientDownload { get { return "Client Download"; } }
        public string ClientDownload_Unable { get { return "Client Download - Unable to verify identity."; } }
        public string Decline { get { return "Decline"; } }
        public string Error { get { return "Error"; } }
        public string PackageFailed { get { return "Package download failed."; } }
        public string PleaseCorrect { get { return "Please correct the error and try again."; } }
        public string PleaseEnter { get { return "Please enter the ID:"; } }
        public string PleaseTry { get { return "Please try again."; } }
        public string Privacy_Policy { get { return "for AT&T Privacy Policy"; } }
        public string SorryError { get { return "Sorry, an error occurred while processing your request."; } }
        public string TandC { get { return "Terms and Conditions"; } }
        public string TandC_Description { get { return "To continue the installation process, click on the <b>ACCEPT</b> button, which confirms your acceptance to the Terms and Conditions specified below."; } }
        public string Thankyou { get { return "Thank you for downloading"; } }
        public string TheInstaller { get { return "The installer should start your new package download automatically."; } }
        public string Trouble { get { return "If you are having trouble with the download,"; } }
        public string UnableClient { get { return "Unable to get the client package."; } }
        public string UnableEnrollment { get { return "Unable to validate user identity. Invalid Enrollment Id."; } }
        public string UnableIdentity { get { return "Unable to validate user identity. Invalid session."; } }
        public string UnableIdentityTenant { get { return "Unable to validate identity. Invalid Tenant."; } }
        public string UnableSession { get { return "Unable to validate the user. Invalid session."; } }
        public string UnableTenant { get { return "Unable to validate the user. Invalid Tenant."; } }
        public string VerifyEnrollment { get { return "Verify Enrollment Id."; } }
    }
}

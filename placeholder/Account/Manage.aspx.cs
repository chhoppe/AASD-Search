using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNet.Membership.OpenAuth;

namespace placeholder.Account
{
    public partial class Manage : System.Web.UI.Page
    {
        protected string SuccessMessage
        {
            get;
            private set;
        }

        protected bool CanRemoveExternalLogins
        {
            get;
            private set;
        }

        protected void Page_Load ( )
        {
            if (!IsPostBack)
            {
                // Zu rendernde Abschnitte ermitteln
                var hasLocalPassword = OpenAuth.HasLocalPassword(User.Identity.Name);
                setPassword.Visible = !hasLocalPassword;
                changePassword.Visible = hasLocalPassword;

                CanRemoveExternalLogins = hasLocalPassword;

                // Rendererfolgsmeldung
                var message = Request.QueryString["m"];
                if (message != null)
                {
                    // Abfragezeichenfolge aus der Aktion entfernen
                    Form.Action = ResolveUrl("~/Account/Manage");

                    SuccessMessage =
                        message == "ChangePwdSuccess" ? "Ihr Kennwort wurde geändert."
                        : message == "SetPwdSuccess" ? "Ihr Kennwort wurde festgelegt."
                        : message == "RemoveLoginSuccess" ? "Die externe Anmeldung wurde entfernt."
                        : String.Empty;
                    successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
                }
            }

        }

        protected void setPassword_Click (object sender, EventArgs e)
        {
            if (IsValid)
            {
                var result = OpenAuth.AddLocalPassword(User.Identity.Name, password.Text);
                if (result.IsSuccessful)
                {
                    Response.Redirect("~/Account/Manage?m=SetPwdSuccess");
                }
                else
                {

                    ModelState.AddModelError("NewPassword", result.ErrorMessage);

                }
            }
        }


        public IEnumerable<OpenAuthAccountData> GetExternalLogins ( )
        {
            var accounts = OpenAuth.GetAccountsForUser(User.Identity.Name);
            CanRemoveExternalLogins = CanRemoveExternalLogins || accounts.Count() > 1;
            return accounts;
        }

        public void RemoveExternalLogin (string providerName, string providerUserId)
        {
            var m = OpenAuth.DeleteAccount(User.Identity.Name, providerName, providerUserId)
                ? "?m=RemoveLoginSuccess"
                : String.Empty;
            Response.Redirect("~/Account/Manage" + m);
        }


        protected static string ConvertToDisplayDateTime (DateTime? utcDateTime)
        {
            // Sie können diese Methode ändern, um das UTC-Datums-/Uhrzeitformat in den gewünschten Anzeige
            //offset und das -format zu konvertieren. Hier erfolgt die Konvertierung in die Zeitzone und Formatierung des Servers
            // als kurzes Datum und lange Uhrzeit-Zeichenfolge. Dabei wird die aktuelle Threadkultur verwendet.
            return utcDateTime.HasValue ? utcDateTime.Value.ToLocalTime().ToString("G") : "[nie]";
        }
    }
}
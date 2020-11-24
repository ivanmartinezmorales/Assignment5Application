using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Web.Security;
using SuperTopSecretEncryption;

namespace Assignment5Application
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            Boolean loginSuccessful = false;
            XmlTextReader xmlTextReader = new XmlTextReader(HttpContext.Current.Server.MapPath("App_Data/Staff.xml"));
            SuperTopSecreteEncryption crypt = new SuperTopSecreteEncryption();

            string userProvidedUsername = Login1.UserName;
            string userProvidedPassword = Login1.Password;

            string retrievedPassword;
            string retrievedUsername;

            if (xmlTextReader == null)
            {
                loginSuccessful = false;
                Login1.FailureText = "AN error has occured, contact your administrator";
                return;
            }


            // now iterate throught the user name and password combinations
            while (xmlTextReader.Read())
            {
                if (loginSuccessful)
                {
                    break;
                }
                if (xmlTextReader.Name == "Username")
                {
                    // this is a user name. Capture it
                    retrievedUsername = xmlTextReader.Value.ToString();
                    // Now retrieve the password
                    while (xmlTextReader.Read())
                    {
                        if (loginSuccessful)
                        {
                            break;
                        }

                        if (xmlTextReader.Name == "Password")
                        {
                            xmlTextReader.Read();
                            // now capture this password
                            retrievedPassword = xmlTextReader.Value.ToString();
                            // encrypt the password and see if they match
                            if (xmlTextReader.Value.ToString() == Login1.Password) {
                                // if they do match, then we're good. Otherwise
                                loginSuccessful = true;

                                // now we want to authenticate the user
                                Response.Cookies.Add(new HttpCookie("staff-cookie", FormsAuthentication.Encrypt(
                                    new FormsAuthenticationTicket(
                                        1,
                                        userProvidedUsername,
                                        DateTime.Now,
                                        DateTime.Now.AddMinutes(60),
                                        Login1.RememberMeSet,
                                        "a staff"
                                        ))));

                                xmlTextReader.Close();
                                break;
                            }
                        }
                    }
                }
            }

            e.Authenticated = loginSuccessful;

            if (loginSuccessful)
            {
                FormsAuthentication.RedirectFromLoginPage(userProvidedUsername, Login1.RememberMeSet);
                Response.Redirect("Protected/Staff.aspx");
            }
        }
    }
}
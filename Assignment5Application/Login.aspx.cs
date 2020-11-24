using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Xml;
using SuperTopSecretEncryption;

namespace Assignment5Application
{
    public partial class Login : System.Web.UI.Page
    {
        private static string appDataPath = "App_Data/Member.xml";
        private XmlTextReader xmlTextReader;
        private SuperTopSecreteEncryption crypt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool loginSuccessful = false;
            // If the form has been submitted, then lets start validating the input
            try
            {
                xmlTextReader = new XmlTextReader(HttpContext.Current.Server.MapPath(appDataPath));

                if (xmlTextReader == null)
                {
                    loginSuccessful = false;
                    Login1.FailureText = "An error has occured, please contact your administrator";
                    return;
                }

                string retrievedUsername;
                string retrievedPassword;
                string encryptedPassword;

                string userProvidedLogin = Login1.UserName;
                string userProvidedPassword = Login1.Password;

                crypt = new SuperTopSecreteEncryption();

                encryptedPassword = crypt.Encrypt(userProvidedPassword);

                Login1.FailureText = encryptedPassword; 

                while (xmlTextReader.Read())
                {
                    if (loginSuccessful)
                    {
                        break; 
                    }

                    if (xmlTextReader.Name == "Username")
                    {
                        xmlTextReader.Read();
                        retrievedUsername = xmlTextReader.Value.ToString();

                        if (retrievedUsername == userProvidedLogin)
                        {
                            while (xmlTextReader.Read())
                            {
                                if (xmlTextReader.Name == "Password")
                                {
                                    xmlTextReader.Read();

                                    retrievedPassword = xmlTextReader.Value.ToString();
                                    encryptedPassword = crypt.Encrypt(userProvidedPassword);

                                    if (retrievedPassword == encryptedPassword)
                                    {
                                        // authentication successful
                                        loginSuccessful = true;
                                        HttpCookie cookie;
                                        cookie = new HttpCookie("non-privileged-user-cookie", FormsAuthentication.Encrypt(
                                            new FormsAuthenticationTicket(
                                                1,
                                                Login1.UserName,
                                                DateTime.Now,
                                                DateTime.Now.AddHours(1),
                                                Login1.RememberMeSet,
                                                "a user"
                                            )));
                                        Response.Cookies.Add(cookie);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Login1.FailureText = "an exception has occured!";
                return;
            }


            if (loginSuccessful)
            {
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);

                // Redirect the user to the right page
                Response.Redirect("Protected/Member.aspx");
            } else
            {
                e.Authenticated = false;
                
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Security;
using System.Drawing;
using System.IO;
using System.Xml.XPath;
using System.Net;
using SuperTopSecretEncryption;

namespace Assignment5Application
{
    public partial class Register : System.Web.UI.Page
    {
        private ImageService.ServiceClient client;
        private string randomString;
        protected void Page_Load(object sender, EventArgs e) {

            client = new ImageService.ServiceClient();
            randomString = client.GetVerifierString("5");
            Image1.ImageUrl = "http://neptune.fulton.ad.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetImage/" + randomString;

            ErrorLabel.Text = randomString;

            // convert a stream into an image


        }

        protected void CreateAccountButton_Click(object sender, EventArgs e)
        {
            // unpack everything

            string username = UsernameTextbox.Text;
            string password = PasswordTextbox.Text;
            string confirmedPassword = PasswordConfirmationTextbox.Text;

            // first confirm that these passwords are the same
            if (password != confirmedPassword)
            {
                ErrorLabel.Text = "Passwords do not match!";
                return;
            }

            if (password.Length == 0 || username.Length == 0 || confirmedPassword.Length == 0)
            {
                ErrorLabel.Text = "All fields must be filled in!";
                ErrorLabel.ForeColor = Color.Red;
                return;
            }

            string passwordEncrypted = new SuperTopSecreteEncryption().Encrypt(password);

            writeInNewMember(username, passwordEncrypted);

            Response.Redirect("Member.aspx");
        }

        private void writeInNewMember(string username, string password)
        {
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.NewLineOnAttributes = true;

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(HttpContext.Current.Server.MapPath("App_Data/Member.xml"));

            // find the node
            XPathNavigator xPathNavigator = xmlDocument.CreateNavigator();
            xPathNavigator.MoveToChild("Members", "");
            XmlWriter xmlWriter = xPathNavigator.AppendChild();
            xmlWriter.WriteStartElement("Member");
            xmlWriter.WriteElementString("Username", username);
            xmlWriter.WriteElementString("Password", password);
            xmlWriter.WriteEndElement();

            xmlWriter.Close();
            xmlDocument.Save(HttpContext.Current.Server.MapPath("App_Data/Member.xml"));
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using SuperTopSecretEncryption;
using System.Drawing;

namespace Assignment5Application
{
    public partial class Member : System.Web.UI.Page
    {
        private chrisService.Service1Client client;
        private ivanService.Assignment6ServiceClient client2;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                // Check if the user is logged in 
                HttpCookie retrievedCookie = Request.Cookies.Get("non-privileged-user-cookie");
                // check if the cookie exists
                if (retrievedCookie == null)
                {
                    Response.Redirect("Login.aspx");
                }

                var userInfo = FormsAuthentication.Decrypt(retrievedCookie.Value);

                if (userInfo == null)
                {
                    // if the user info returned null, then shoot render the response page
                    Response.Redirect("Login.aspx");
                }

                // now that we're out of the woods of smoketesting


            } catch (Exception)
            {
                   Response.Redirect("Login.aspx");
            }

        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            client = new chrisService.Service1Client();
            // get the data
            var stockName = StockName.Text;

            string[] response;
            try
            {
                response = client.getStockData(stockName);
                StockResponse.Text = string.Join("\n\n", response);
                client.Close();
            }
            catch (Exception stockException)
            {

                // StockResponse.Text = stockException.Message;
                StockResponse.Text = "Oops, that's not a ticker. Try again";
                client.Close();
            }

        }
        protected void SubmitButton_Click2(object sender, EventArgs e)
        {
            client = new chrisService.Service1Client();
            // get the data
            var word = aWordTextBox.Text;

            string response;
            try
            {
                response = client.getDefinition(word);
                wordDef.Text = word + ": " + string.Join("\n\n", response);
                client.Close();
            }
            catch (Exception stockException)
            {
                wordDef.Text = "Be sure to enter a word";
                //wordDef.Text = stockException.Message;
                client.Close();
            }

        }
        protected void SubmitButton_Click3(object sender, EventArgs e)
        {
            client2 = new ivanService.Assignment6ServiceClient();
            

            int response;
            try
            {
                var amount = Int32.Parse(amountTextBox.Text);
                var conversion = (sender as Button).ID;
                response = client2.currentConversionService(amount, conversion);
                conversionLabel.Text = amount + " USD is "+ response + " " + conversion;
                client2.Close();
            }
            catch (Exception stockException)
            {

                conversionLabel.Text = "Please Enter a Number";
                client2.Close();
            }

        }
        protected void SubmitButton_Click4(object sender, EventArgs e)
        {
            client2 = new ivanService.Assignment6ServiceClient();

            String[] Topics = { TopicTextBox.Text };
            string[] response;
            try
            {
                
                response = client2.NewsFocus(Topics);
                theNewsLabel.Text = string.Join("\n\n", response);
                client2.Close();
            }
            catch (Exception stockException)
            {

                theNewsLabel.Text = "Be Sure to enter a topic!";
                client2.Close();
            }

        }

        protected void handleEncrypt(object sender, EventArgs e)
        {
            // okay so encrypt the text and make it appear on the screen
            if (EncryptionTextbox.Text == "")
            {
                EncryptionResultsText.Text = "Cannot be empty!";
                EncryptionResultsText.ForeColor = Color.Red;
            }

            SuperTopSecreteEncryption crypt = new SuperTopSecreteEncryption();


            try
            {

               EncryptionResultsText.Text =  crypt.Encrypt(EncryptionTextbox.Text);
            } catch (Exception)
            {
                EncryptionResultsText.Text = "Encryption failed!";
                EncryptionResultsText.ForeColor = Color.Red;
            }

        }


        protected void handleDecrypt(object sender, EventArgs e)
        {
            // okay so encrypt the text and make it appear on the screen
            if (EncryptionTextbox.Text == "")
            {
                EncryptionResultsText.Text = "Cannot be empty!";
                EncryptionResultsText.ForeColor = Color.Red;
            }

            SuperTopSecreteEncryption crypt = new SuperTopSecreteEncryption();


            try
            {

               EncryptionResultsText.Text =  crypt.Decrypt(EncryptionTextbox.Text);
            } catch (Exception)
            {
                EncryptionResultsText.Text = "Decryption failed!";
                EncryptionResultsText.ForeColor = Color.Red;
            }

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5Application.Protected
{
    public partial class Members : System.Web.UI.Page
    {
        private chrisService.Service1Client client;
        private ivanService.Assignment6ServiceClient client2;
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}
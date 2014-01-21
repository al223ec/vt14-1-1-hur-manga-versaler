using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){}

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Enabled)
            {
                OutputLabel.Text = String.Format("Texten innehåller {0} versaler", InputTextBox.Text.GetNumberOfCapitals());
                InputTextBox.Enabled = false;
                InputTextBox.BackColor = System.Drawing.Color.Gray;
                SubmitButton.Text = "Rensa";
            }
            else
            {
                SubmitButton.Text = "Bestäm antal versaler";
                InputTextBox.Text = "";
                InputTextBox.BackColor = System.Drawing.Color.White;
                InputTextBox.Enabled = true; 
            }
        }

        protected void ValidateButton_Click(object sender, EventArgs e)
        {
            int number = int.Parse(ValidateTextBox.Text); 
        }
    }
}
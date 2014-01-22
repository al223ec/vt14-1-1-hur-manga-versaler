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
            if (InputTextBox.Text != "") //Kan inte använda .Enabled pga ViewStateMode = disabled, kontrollerar ifall användaren skickar text ist
            {
                OutputLabel.Text = String.Format("{0} <br> Innehåller {1} versaler",InputTextBox.Text, InputTextBox.Text.GetNumberOfCapitals());
                InputTextBox.Text = ""; 
                InputTextBox.Enabled = false;
                SubmitButton.Text = "Rensa";
            }
            else
            {
                SubmitButton.Text = "Bestäm antal versaler";
                InputTextBox.Enabled = true; 
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solution3
{
    public partial class _Default : Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client tempconvert = new ServiceReference1.Service1Client();
            int celinp;
            if (int.TryParse(TextBox1.Text, out celinp )) //We check if the string in textbox is an int
            {
                F.Text = tempconvert.c2f(celinp).ToString(); // F is name of farheniet label to hold text
            
            }
            else   //if the text is not int we send alert to change text to an int parsable
            {
                string myStringVariable = "please Enter valid number as input";

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            ServiceReference1.Service1Client tempconvert = new ServiceReference1.Service1Client();
            int farinp;
            if (int.TryParse(TextBox2.Text, out farinp)) //We check if the string in textbox is an int
            {
                C.Text = tempconvert.f2c(farinp).ToString(); // C is name of Celcius label to hold text

                //we run client f2c to get the int in celicus then we put it in label C

            }
            else
            {
                string myStringVariable = "please Enter valid number as input";

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);

                //if the string is not a number we send a page alert
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            //call sorting service and sort text

            ServiceReference2.Service1Client sorter = new ServiceReference2.Service1Client();

            sortednums.Text = sorter.sort(TextBox3.Text);






        }
    }
}
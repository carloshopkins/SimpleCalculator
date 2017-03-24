using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public static void initValues()
        {
            
        }

        protected void plusButton_Click(object sender, EventArgs e)
        {
            //Find a way to do this in a method
            int a = int.Parse(firstField.Text);
            int b = int.Parse(secondField.Text);

            resultLabel.Text = (a + b).ToString();
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {
            //Find a way to do this in a method
            int a = int.Parse(firstField.Text);
            int b = int.Parse(secondField.Text);

            resultLabel.Text = (a - b).ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            //Find a way to do this in a method
            int a = int.Parse(firstField.Text);
            int b = int.Parse(secondField.Text);

            resultLabel.Text = (a * b).ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            //Find a way to do this in a method
            //Could add a remainder
            int a = int.Parse(firstField.Text);
            int b = int.Parse(secondField.Text);

            resultLabel.Text = (a / b).ToString();
        }
    }
}
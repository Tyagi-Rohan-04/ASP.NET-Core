using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using System.Xml.Linq;

namespace Registration_Form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) )
            {
                lblMessage.Text = "Enter the missing values.";
                return;
            }

            /*string filePath = Server.MapPath("~/App_Data/Users.xml");
            if (!File.Exists(filePath))
            {
                new XDocument(new XElement("Users")).Save(filePath);
            } */

            lblRegisterName1.Text = "First name is: " + firstName;
            lblRegisterName2.Text = "Last name is: " + lastName;
        }
    }
}
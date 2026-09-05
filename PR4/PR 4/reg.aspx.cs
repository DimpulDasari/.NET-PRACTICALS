using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PR_4
{
    public partial class reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string name = txtName.Text;
                string grno = txtGrno.Text;
                string email = txtEmail.Text;
                string age = txtAge.Text;
                string gender = "";
                if (rbMale.Checked)
                {
                    gender = "Male";
                }
                else if (rbFemale.Checked)
                {
                    gender = "Female";
                }
                string branch = DropDownList1.SelectedValue;
                string events = "";
                if (CheckBox1.Checked)
                {
                    events += "Poster Presentation ";
                }
                if (CheckBox2.Checked)
                {
                    events += "Paper Presentation ";
                }
                string eventDate = Calendar1.SelectedDate.ToShortDateString();
                lblMessage.Text =
                "Registration Successful!<br/>" +
                "Name: " + name + "<br/>" +
                "GR No: " + grno + "<br/>" +
                "Email: " + email + "<br/>" +
                "Age: " + age + "<br/>" +
                "Gender: " + gender + "<br/>" +
                "Branch: " + branch + "<br/>" +
                "Events: " + events + "<br/>" +
                "Event Date: " + eventDate;
            }
        }
    }
}

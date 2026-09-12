using System;
using System.Web.UI;

namespace PR5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

    protected void Cal1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Cal1.SelectedDate;

            TextBox1.Text = selectedDate.ToString("dd/MM/yyyy");

            lblSelectedDate.Text = "Selected Date:";
        }


        protected void btn1_Click(object sender, EventArgs e)
        {
            if (Cal1.SelectedDate == DateTime.MinValue)
            {
                lblSelectedDate.Text = "Please select a date first.";
                return;
            }


            string selectedDate =
                Cal1.SelectedDate.ToString("dd/MM/yyyy");


            Response.Redirect(
                "Leave.aspx?date=" +
                Server.UrlEncode(selectedDate)
            );
        }
    }


}

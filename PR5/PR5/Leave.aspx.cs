using System;
using System.Web;
using System.Web.UI;

namespace PR5
{
    public partial class Leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                string selectedDate = Request.QueryString["date"];

            if (!string.IsNullOrEmpty(selectedDate))
                {
                    txt2.Text = selectedDate;
                }

                if (Request.Cookies["EmployeeInfo"] != null)
                {
                    txt1.Text =
                        Request.Cookies["EmployeeInfo"]["EmployeeName"];
                }


                // Read Leave Details from Session
                if (Session["EmployeeName"] != null)
                {
                    lblEmployee.Text =
                        Session["EmployeeName"].ToString();

                    lblDate.Text =
                        Session["LeaveDate"].ToString();

                    lblLeaveType.Text =
                        Session["LeaveType"].ToString();

                    lblReason.Text =
                        Session["Reason"].ToString();

                    lblLoad.Text =
                        Session["LoadAdjustedWith"].ToString();

                    lblMessage.Text =
                        "Previous leave application found in Session.";

                    pnlResult.Visible = true;
                }
            }
        }
        protected void btn2_Click(object sender, EventArgs e)
        {
            string employeeName = txt1.Text;
            string leaveDate = txt2.Text;
            string leaveType = d1.SelectedValue;
            string reason = TextArea1.Text;
            string loadAdjustedWith = txt3.Text;

            Session["EmployeeName"] = employeeName;
            Session["LeaveDate"] = leaveDate;
            Session["LeaveType"] = leaveType;
            Session["Reason"] = reason;
            Session["LoadAdjustedWith"] = loadAdjustedWith;

            HttpCookie employeeCookie =
                new HttpCookie("EmployeeInfo");

            employeeCookie["EmployeeName"] =
                employeeName;

            employeeCookie.Expires =
                DateTime.Now.AddDays(7);

            Response.Cookies.Add(employeeCookie);

            lblMessage.Text =
                "Leave application submitted successfully.";

            lblEmployee.Text =
                employeeName;

            lblDate.Text =
                leaveDate;

            lblLeaveType.Text =
                leaveType;

            lblReason.Text =
                reason;

            lblLoad.Text =
                loadAdjustedWith;


            pnlResult.Visible = true;
        }
        protected void btnLogout_Click(
            object sender,
            EventArgs e)
        {
           
            Session.Clear();
            Session.Abandon();

            if (Request.Cookies["EmployeeInfo"] != null)
            {
                HttpCookie employeeCookie =
                    new HttpCookie("EmployeeInfo");

                employeeCookie.Expires =
                    DateTime.Now.AddDays(-1);

                Response.Cookies.Add(employeeCookie);
            }

            if (Request.Cookies["ASP.NET_SessionId"] != null)
            {
                HttpCookie sessionCookie =
                    new HttpCookie("ASP.NET_SessionId");

                sessionCookie.Expires =
                    DateTime.Now.AddDays(-1);

                Response.Cookies.Add(sessionCookie);
            }

            Response.Redirect("Default.aspx");
        }
    }

}

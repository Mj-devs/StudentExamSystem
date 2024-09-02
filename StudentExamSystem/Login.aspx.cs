using StudentExamSystem.Model.Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentExamSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;


            using (var context = new studentsContext())
            {
                // Check if the lecturer exists in the database
                var lecturer = context.Lecturer
                    .FirstOrDefault(l => l.Email == email && l.Password == password);

                if (lecturer != null)
                {
                    // Successful login, redirect to dashboard
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    // Invalid login attempt
                    lblerror.Text = "Invalid username or password.";
                    lblerror.Visible = true;
                }
            }
        }

        protected void cvEmailFormat_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string email = args.Value.Trim();

            // Check if the email is in email format
            args.IsValid = email.Contains("@") && email.Contains(".");
        }

    }
}
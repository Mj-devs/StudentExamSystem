using Microsoft.EntityFrameworkCore;
using StudentExamSystem.Model.Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentExamSystem
{
    public partial class ViewResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string studentId = Request.QueryString["StudentID"];

                if (!string.IsNullOrEmpty(studentId))
                {
                    using (var context = new studentsContext())
                    {
                        // Retrieve the student and their report data based on the student ID
                        var data = from i in context.Info where i.Id.ToString() == studentId 
                                   join r in context.Report on i.ReportId
                                   equals r.ReportId select new { student= i, report= r};
                        var returned = data.FirstOrDefault();
                        if (returned.student != null && returned.report != null)
                        {
                            
                            lblStudentName.Text = $"Name: {returned.student.Firstname} {returned.student.Lastname}";

                            lblGrade.Text = $"Grade: {returned.report.Grade}";

                            lblComments.Text = $"Comments: {returned.report.Comments}";

                            pnlResult.Visible = true;
                        }
                        else
                        {
                            lblMessage.Text = "No result found for this student.";
                        }
                    }
                }
                else
                {
                    lblMessage.Text = "Invalid student ID.";
                }
            }
        }

    }
}
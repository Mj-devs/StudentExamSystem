using StudentExamSystem.Model.Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentExamSystem
{
    public partial class UploadResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                // Retrieve the StudentID from the query string
                string studentId = Request.QueryString["id"];

                if (!string.IsNullOrEmpty(studentId))
                {
                    // Use the studentId to load student details or prepare for result upload
                    lblStudentId.Text = $"Uploading result for Student ID: {studentId}";
                }
                else
                {
                    // Handle the case where no student ID is provided
                    lblStudentId.Text = "No Student ID provided.";
                }
            }
        }


        protected void btnupload_Click1(object sender, EventArgs e)
        {
            int studentId;
            if (int.TryParse(Request.QueryString["id"], out studentId))
            {
                using (var context = new studentsContext())
                {
                    // Create a new report
                    var report = new Report{ Grade = txtgrade.Text, Comments = txtcomments.Text };
                    context.Report.Add(report);
                    context.SaveChanges();

                    // Link report to student
                    var student = context.Student.Find(studentId);
                    if (student != null)
                    {
                        student.ReportId = report.ReportId;
                        report.StudentId = student.Id;
                        context.SaveChanges();

                        lblMessage.Text = "Report uploaded and linked successfully.";
                    }
                    else
                    {
                        lblMessage.Text = "Student not found.";
                    }
                }
            }
            else
            {
                lblMessage.Text = "Invalid Student ID.";
            }

            txtcomments.Text = string.Empty;
            txtgrade.Text = string.Empty;
        }
    }
}
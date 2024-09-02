using StudentExamSystem.Model.Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentExamSystem
{
    public partial class StudentView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            populateGridView(); 
        }
        public void populateGridView()
        {
            //Method to retrive data from database
            var _context = new studentsContext();
            var populate = _context.Student.ToList();
            gvstudents.DataSource = populate;
            gvstudents.DataBind();
        }
        protected void gvstudents_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewResult")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                // Assuming the primary key or unique identifier (e.g., StudentID or MatricNo) is in the first column
                string studentId = gvstudents.DataKeys[rowIndex].Value.ToString();

                // Redirect to the result viewing page
                Response.Redirect($"ViewResult.aspx?StudentID={studentId}");
            }
        }

    }
}
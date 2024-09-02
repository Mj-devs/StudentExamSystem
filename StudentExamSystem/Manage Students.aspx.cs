using Microsoft.EntityFrameworkCore;
using StudentExamSystem.Model.Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace StudentExamSystem
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid(); // Load initial data
            }
        }
        public void populateGridView()
        {
            //Method to retrive data from database
            var _context = new studentsContext();
            var populate = _context.Student.ToList();
            gvstudents.DataSource = populate;
            gvstudents.DataBind();
        }


        protected void btnsearch_Click(object sender, EventArgs e)
        {
            // Get search term from TextBox
            string searchTerm = txtsearch.Text;

            // Fetch filtered data and bind to GridView
            BindGrid(searchTerm);
        }

        private void BindGrid(string searchTerm = "")
        {
            //Filter database using Firstname, Lastname or matric no
            using (var _context = new studentsContext())
            {
                var filter = _context.Student.AsQueryable();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    // Apply filter based on search term
                    filter = filter.Where(s => s.Firstname.Contains(searchTerm) || s.Lastname.Contains(searchTerm) || s.MatricNo.Contains(searchTerm));
                }

                gvstudents.DataSource = filter.ToList();
                gvstudents.DataBind();
            }
        }

        protected void lbToggleFields_Click(object sender, EventArgs e)
        {
            // Toggle visibility of the Panel
            pnlHiddenFields.Visible = !pnlHiddenFields.Visible;
        }
        protected void cvMatricNo_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string matricNo = txtmatricno.Text.Trim();

            using (var context = new studentsContext())
            {
                // Check if the matriculation number already exists
                bool matricNoExists = context.Student.Any(i => i.MatricNo == matricNo);

                // If the matriculation number exists, validation fails
                if (matricNoExists)
                {
                    args.IsValid = false; // Set validation to fail
                }
                else
                {
                    args.IsValid = true; // Set validation to pass
                    context.Student.Add(new Students { Firstname = txtfirstname.Text, Lastname = txtlastname.Text, MatricNo = txtmatricno.Text });
                    context.SaveChanges();
               
                // Refresh the grid view or clear the form
                populateGridView();
                }
            }
        }


        protected void btnsave_Click(object sender, EventArgs e)
        {
            // Tiggers the validation.
        }

        protected void gvstudents_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                // Determine the row index that was clicked
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = gvstudents.Rows[rowIndex];

                // Assuming you want to pass the first cell value (e.g., MatricNo) to the next page
                string id = row.Cells[1].Text;
                string firstname = row.Cells[2].Text;

                // Redirect to the result upload page, passing the matric no
                Response.Redirect($"UploadResults.aspx?id={id}");
            }

        }

    }
}

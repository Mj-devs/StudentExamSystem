using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentExamSystem.Model.Datalayer
{
    public partial class Report
    {
        public int ReportId { get; set; }
        public int StudentId { get; set; }
        public string Grade { get; set; }
        public string Comments { get; set; }
        public DateTime? Date { get; set; }

        public virtual Info Student { get; set; }
    }
}

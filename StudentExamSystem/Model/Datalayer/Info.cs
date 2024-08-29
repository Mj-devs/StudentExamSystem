﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentExamSystem.Model.Datalayer
{
    public partial class Info
    {
        public Info()
        {
            Report = new HashSet<Report>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string MatricNo { get; set; }
        public int? ReportId { get; set; }

        public virtual ICollection<Report> Report { get; set; }
    }
}

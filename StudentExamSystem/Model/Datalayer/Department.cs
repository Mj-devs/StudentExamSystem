using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentExamSystem.Model.Datalayer
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public virtual List<Students> Students { get; set; }
        public List<Class> Classes { get; set; }
    }
}
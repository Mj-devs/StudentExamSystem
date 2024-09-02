using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentExamSystem.Model.Datalayer
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        //One class can have many students
        public List<Students> info { get; set; }
    }
}
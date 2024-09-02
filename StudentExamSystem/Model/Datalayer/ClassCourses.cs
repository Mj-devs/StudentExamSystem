using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentExamSystem.Model.Datalayer
{
    public class ClassCourses
    {
        public int Id {  get; set; }
        public int ClassId {  get; set; }
        public int CourseId { get; set; }

        public Class Class { get; set; }
        public Courses courses { get; set; }
    }
}
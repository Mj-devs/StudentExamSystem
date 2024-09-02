using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentExamSystem.Model.Datalayer
{
    public class StudentCourse
    {
        public int Id {  get; set; }
        public int StudentId {  get; set; }
        public int CourseId { get; set; }
        public Students students { get; set; }
        public Courses courses { get; set; }
    }
}
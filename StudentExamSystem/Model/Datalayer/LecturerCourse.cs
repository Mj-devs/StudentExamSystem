using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentExamSystem.Model.Datalayer
{
    public class LecturerCourse
    {
        public int Id {  get; set; }
        public int LecturerId {  get; set; }
        public int CourseId { get;set; }
        public int DepartmentId { get;set; }
        public int ClassId { get;set; }

        public Lecturer lecturer { get; set; }
        public Courses course { get; set; }
        public Department department { get; set; }
        public Class Class { get; set; }
    }
}
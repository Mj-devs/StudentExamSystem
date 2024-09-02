using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentExamSystem.Model.Datalayer
{
    public partial class Lecturer
    {
        public int Id { get; set; }
        public string LecturerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        
        //One Lecturer can have many students
        public virtual List<Students> Students { get; set; }

        //One Lecturer can have many courses
        public List<Courses> courses { get; set; }
    }
}
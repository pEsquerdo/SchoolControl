using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolControl.Model
{
    public class Student : Base.User
    {

        public DateTime BirthDate { get; set; }

        public virtual IList<Attendance> Attendances { get; set; }

        public virtual IList<Grade> Grades { get; set; }

        public Student()
        {
            Active = true;
        }
    }
}

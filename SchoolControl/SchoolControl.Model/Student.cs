using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolControl.Model
{
    public class Student : Base.User
    {
        
        public int Attendance { get; set; }

        public float Grade { get; set; }

        public Student()
        {
            Active = true;
        }
    }
}

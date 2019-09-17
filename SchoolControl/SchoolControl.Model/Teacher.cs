using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolControl.Model
{
    public class Teacher : Base.User
    {
        public string Specialty { get; set; }

        public Teacher()
        {
            Active = true;
        }
    }
}

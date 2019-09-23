using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolControl.Model
{
    public class Attendance : Base.GenericEntity
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        [ForeignKey("CoursePeriod")]
        public int CoursePeriodId { get; set; }
        public virtual CoursePeriod CoursePeriod { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public DateTime Date { get; set; }

        public float Load { get; set; }
    }
}

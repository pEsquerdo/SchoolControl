using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolControl.Model
{
    public class Grade : Base.GenericEntity
    {
        [ForeignKey("CoursePeriod")]
        public int CoursePeriodId { get; set; }
        public virtual CoursePeriod CoursePeriod { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherdId { get; set; }
        public virtual Teacher Teacher { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public string TextValue { get; set; }

        public float NumericValue { get; set; }

        public GradeType GradeType { get; set; }


    }
}

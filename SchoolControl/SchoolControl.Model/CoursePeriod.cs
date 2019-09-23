using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolControl.Model
{
    public class CoursePeriod : Base.GenericEntity
    {

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public float Load { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public virtual IList<Attendance> Attendances { get; set; }

        public virtual IList<Grade> Grades { get; set; }
    }
}

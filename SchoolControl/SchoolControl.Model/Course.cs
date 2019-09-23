using System;
using System.Collections.Generic;

namespace SchoolControl.Model
{
    public class Course : Base.GenericEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public float Load { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public GradeType GradeType { get; set; }

        public virtual IList<CoursePeriod> CoursePeriods { get; set; }

    }

    public enum GradeType
    {
        Text = 1,
        Numeric = 0
    }
}

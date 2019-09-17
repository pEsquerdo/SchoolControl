using System;

namespace SchoolControl.Model
{
    public class Course : Base.GenericEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public float Load { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}

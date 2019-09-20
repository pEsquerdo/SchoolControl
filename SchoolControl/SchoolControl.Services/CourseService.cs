using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolControl.Dao;
using SchoolControl.Model;

namespace SchoolControl.Services
{
    class CourseService : GenericService<Course>
    {
        public CourseService(DataContext context) : base(context)
        {
        }
    }
}

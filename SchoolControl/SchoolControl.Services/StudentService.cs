using SchoolControl.Dao;
using SchoolControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolControl.Services
{
    class StudentService : GenericService<Student>
    {
        public StudentService(DataContext context) : base(context)
        {

        }
    }
}

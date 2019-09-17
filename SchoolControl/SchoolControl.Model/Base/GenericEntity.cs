using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolControl.Model.Base
{
    public class GenericEntity : IGenericEntity
    {
        //[Key] - Data Annotation que define Codigo como chave primária

        [Key]
        public int Id { get; set; }

        public bool Active { get; set; }
    }
}

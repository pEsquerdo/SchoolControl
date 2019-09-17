using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolControl.Model.Base
{
    public class User :  GenericEntity, IUser
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(32), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, StringLength(100), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber), StringLength(20)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Address { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Students.Models.Entity
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [StringLength(15,MinimumLength =3)]
        public string Name { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string SurName { get; set; }
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Provided phone number not valid")]
        public string Phone { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Cource { get; set; }


    }
}
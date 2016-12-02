using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC2kunskapskoll.Models
{
    [Table("Person")]
    public class PersonModel
    {
       
        public Guid ID { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(30),MinLength(3)]
        public string Name { get; set; }
        public string Address { get; set; }

        [MaxLength(30), MinLength(3)]
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }

        public PersonModel()
        {
            ID = Guid.NewGuid();
        }
    }
}
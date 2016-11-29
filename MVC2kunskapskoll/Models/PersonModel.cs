using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2kunskapskoll.Models
{
    public class PersonModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC2kunskapskoll.DAL
{
    public class PersonContext : DbContext
    {

        public PersonContext():base("name=PersonContext")
        {

        }
        public DbSet<Models.PersonModel> persons {get;set;}
    }
}
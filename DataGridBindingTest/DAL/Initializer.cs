using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridBindingTest.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Entities>
    {
        protected override void Seed(Entities context)
        {
            var persons = new List<Person>
            {
                new Person{ Id=1, Firstname = "Alex", Lastname = "Erwin", DateOfBirth = new DateTime(1980,01,01) },
                new Person{ Id=2, Firstname = "Scott", Lastname = "Fairclough", DateOfBirth = new DateTime(1985,04,12)}
            };

            persons.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();

        }
    }
}

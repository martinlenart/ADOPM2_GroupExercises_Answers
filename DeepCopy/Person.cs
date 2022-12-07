using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomInit;
namespace DeepCopy
{
    public class Person:IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString() => $"Hi, I'm {FirstName} {LastName}. I was is born on {Birthday:d} " +
            $"and you can reach me on {Email}";

        //Class factory
        public static class Factory
        {
            public static Person CreateRandom()
            {
                IGetRandom rnd = new GetRandom();

                string fname = rnd.FirstName;
                string lname = rnd.LastName;

                return new Person
                {
                    FirstName = fname,
                    LastName = lname,
                    Email = rnd.Email(fname, lname),
                    Birthday = rnd.Date(1970, 2000)
                };
            }
        }

        //Copy constructor
        public Person(Person original)
        {
            FirstName= original.FirstName;
            LastName= original.LastName;
            Email= original.Email;
            Birthday= original.Birthday;
        }

        public Person()
        {

        }
     }
}

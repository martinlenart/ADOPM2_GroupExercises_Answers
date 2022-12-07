using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomInit
{
    public class Person:IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString() => $"Hi, I'm {FirstName} {LastName}. I was is born on {Birthday:d} " +
            $"and you can reach me on {Email}";
     }
}

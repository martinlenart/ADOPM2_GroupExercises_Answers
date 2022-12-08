using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace IEquatable_IComparable
{
    public class Person:IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        #region Implementation of IEquatable<T> interface
        public bool Equals(IPerson other) => (this.FirstName, this.LastName, this.Email, this.Birthday) ==
            (other.FirstName, other.LastName, other.Email, other.Birthday);

        //Needed to implement as part of IEquatable
        public override bool Equals(object obj) => Equals(obj as IPerson);
        public override int GetHashCode() => (this.FirstName, this.LastName, this.Email, this.Birthday).GetHashCode();
        #endregion

        #region operator overloading
        public static bool operator ==(IPerson c1, Person c2) => c1.Equals(c2);
        public static bool operator !=(IPerson c1, Person c2) => !c1.Equals(c2);
        #endregion

        #region Implementation IComparable<T> interface
        public int CompareTo(IPerson other)
        {
            //Sort on Make -> Model -> Year
            if (LastName != other.LastName)
                return LastName.CompareTo(other.LastName);

            return FirstName.CompareTo(other.FirstName);
        }
        #endregion

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

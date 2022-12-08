namespace IEquatable_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> persons = new List<IPerson>();
            for (int i = 0; i < 100; i++)
            {
                persons.Add(Person.Factory.CreateRandom());
            }

            //Testing IEquatable
            var aPerson = new Person((Person) persons[0]);
            Console.WriteLine(persons.Contains(aPerson));   //true

            
            //Testing operator overload
            //As I have implemented overloading on IPerson, one of the operands has to
            //casted to the instantiated type.
            //If interface was not used this is ofcourse not needed as the compiler knows what
            //what implementation type the == is meant to work on
            Console.WriteLine(aPerson == persons[0]); //true

            //Testing Sort
            persons.Sort();
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
           

         }
    }
}
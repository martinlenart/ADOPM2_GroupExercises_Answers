namespace DeepCopy;
class Program
{
    static void Main(string[] args)
    {
        IPerson aFriend = Person.Factory.CreateRandom();
        Console.WriteLine(aFriend);

        //Shallow copy
        IPerson anotherFriend = aFriend;
        Console.WriteLine(anotherFriend);

        aFriend.FirstName = "Donald";
        aFriend.LastName = "Duck";
        Console.WriteLine(anotherFriend);

        //Deep copy
        anotherFriend = new Person((Person) aFriend);
        Console.WriteLine(anotherFriend);

        aFriend.FirstName = "Mickey";
        aFriend.LastName = "Mouse";
        Console.WriteLine(anotherFriend);

        //List of persons
        Person[] persons = new Person[20];
        for (int i = 0; i < persons.Length; i++)
        {
            persons[i] = Person.Factory.CreateRandom();
        }

        //Shallow list copy
        Person[] people = new Person[20];
        Array.Copy(persons, people, persons.Length);

        persons[0].FirstName = "Donald";
        persons[0].LastName = "Duck";
        Console.WriteLine(persons[0]);
        Console.WriteLine(people[0]);

        //Deep list copy
        for (int i = 0; i < persons.Length; i++)
        {
            people[i] = new Person(persons[i]);
        }
        persons[5].FirstName = "Donald";
        persons[5].LastName = "Duck";
        Console.WriteLine(persons[5]);
        Console.WriteLine(people[5]);
    }
}


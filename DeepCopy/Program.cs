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
        Person[] list = new Person[20];
        for (int i = 0; i < list.Length; i++)
        {
            list[i] = Person.Factory.CreateRandom();
        }

        //Shallow list copy
        Person[] people = new Person[20];
        Array.Copy(list, people, list.Length);

        list[0].FirstName = "Donald";
        list[0].LastName = "Duck";
        Console.WriteLine(list[0]);
        Console.WriteLine(people[0]);

        //Deep list copy
        for (int i = 0; i < list.Length; i++)
        {
            people[i] = new Person(list[i]);
        }
        list[5].FirstName = "Donald";
        list[5].LastName = "Duck";
        Console.WriteLine(list[5]);
        Console.WriteLine(people[5]);
    }
}


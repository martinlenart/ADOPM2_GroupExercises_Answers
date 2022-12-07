namespace RandomInit;
class Program
{
    static void Main(string[] args)
    {
        IGetRandom rnd = new GetRandom();

        Console.WriteLine(rnd.FirstName);
        Console.WriteLine(rnd.LastName);
        Console.WriteLine(rnd.FullName);
        Console.WriteLine(rnd.Email());
        Console.WriteLine(rnd.Email("donald", "duck"));
        Console.WriteLine(rnd.Country);
        Console.WriteLine(rnd.Date().ToString());
        Console.WriteLine(rnd.Date(1970, 2000).ToString());

        IPerson aFriend = new Person();

        aFriend.FirstName = rnd.FirstName;
        aFriend.LastName = rnd.LastName;
        aFriend.Email = rnd.Email(aFriend.FirstName, aFriend.LastName);
        aFriend.Birthday = rnd.Date(1970, 2000);

        Console.WriteLine(aFriend);
    }
}


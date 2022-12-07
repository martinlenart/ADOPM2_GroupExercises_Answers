// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace FriendList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Friend f1 = new Friend {
                FirstName = "Mikael", LastName = "Petersen",
                Email = "m.petersen@gmail.com", Address= new AddressType {
                    Street = "Mainstreet 1", Zip=12345, City="Gavle", Country="Sweden"}
            };

            Console.WriteLine(f1.ToString());

            Friend f2 = new Friend("Anne", "Sterling", "a.sterling@icloud.com",
                new AddressType { Street = "Backstreet 3", Zip = 98765, City = "Sigtuna", Country = "Sweden" });

            Console.WriteLine(f2);

            Friend f3 = Friend.Factory.CreateRandom();
            Console.WriteLine(f3);

            
            Console.WriteLine("\nFriendList - friends1");
            var friends1 = FriendList.Factory.CreateRandom(10_000);
            Console.WriteLine($"[123]: {friends1[123]}");
            Console.WriteLine($"[456]: {friends1[456]}");
            Console.WriteLine($"[457]: {friends1[457]}");
            
             /*
            Console.WriteLine("\nFriendList - friends2");
            var friends2 = FriendList.Factory.CreateRandom(5);
            Console.WriteLine(friends2);

            */
        }
    }
}
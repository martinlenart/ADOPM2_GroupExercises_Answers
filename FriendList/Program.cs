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

            List<Friend> myFriends = new List<Friend>();
            for (int i = 0; i < 10_000; i++)
            {
                myFriends.Add(Friend.Factory.CreateRandom());
            }

            Console.WriteLine("\nFirst 20");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(myFriends[i]);
            }
            Console.WriteLine("\nLast 20");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(myFriends[myFriends.Count-1-i]);
            }

            Console.WriteLine("\nFriendList - friends1");
            var friends1 = FriendList.Factory.CreateRandom(10, QuanFriend);
            Console.WriteLine(friends1);

            Console.WriteLine("\nFriendList - friends2");
            var friends2 = FriendList.Factory.CreateRandom(5, SemiraFriend);
            Console.WriteLine(friends2);

            var friendsToDisk = FriendList.Factory.CreateRandom(100);
            //friendsToDisk.WriteToDisk();

            friendsToDisk.SerializeXml();
            friendsToDisk.DeSerializeXml();

            Console.WriteLine("\nHello to Finland");
            friendsToDisk.SayHello(HelloFinland);

            Console.WriteLine("\nHello to Gavle");
            friendsToDisk.SayHello(HelloGavle);

            Console.WriteLine("\nHello to Scandinavia");
            friendsToDisk.SayHello(HelloScandinavia);

            Console.WriteLine("\nHuge friendlist");
            FriendList.CreationProgress += ProgressReport;
            var huge = FriendList.Factory.CreateRandom(1_000_000);

        }

        public static void ProgressReport(int completion)
        {
            Console.WriteLine($"completed {completion} number");
        }
        public static void HelloFinland(Friend friend)
        {
            if (friend.Address.Country == "Finland")
            {
                Console.WriteLine($"Hello {friend.FirstName}, {friend.Address.Country} from Finland");
            }
        }
        public static void HelloGavle(Friend friend)
        {
            if (friend.Address.City == "Gavle")
            {
                Console.WriteLine($"Hello {friend.FirstName}, {friend.Address.City} from Gavle");
            }
        }
        public static void HelloScandinavia(Friend friend)
        {
            if (friend.Address.Country != "Finland")
            {
                Console.WriteLine($"Hello {friend.FirstName}, {friend.Address.Country} from Scandinavia");
            }
        }


        public static Friend QuanFriend(Friend orgFriend)
        {
            orgFriend.FirstName = "Jane";
            return orgFriend;
        }

        public static Friend SemiraFriend(Friend orgFriend)
        {
            var newAddress = orgFriend.Address;
            newAddress.City = "Gavle";

            orgFriend.Address = newAddress;
            return orgFriend;
        }
    }
}
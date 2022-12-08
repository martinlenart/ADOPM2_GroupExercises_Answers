using System;
namespace IEquatable_IComparable
{
	public class GetRandom : IGetRandom
    {
		Random rnd = new Random();

        string _country = "Sweden, Norway, Denmark";
        string[][] _city = 
            {
                new string[] { "Stockholm", "Göteborg", "Malmö", "Uppsala", "Linköping", "Örebro" },
                new string[] { "Oslo", "Bergen","Trondheim","Stavanger","Dramen"},
                new string[] { "Köpenhamn", "Århus", "Odense", "Aahlborg", "Esbjerg"},
             };

        public string FirstName
		{
			get
			{
                var _fnames = "Harry, Lord, Hermione, Albus, Severus, Ron, Draco, Frodo, Gandalf, Sam, Peregrin, Saruman".Split(", ");
				return _fnames[rnd.Next(0, _fnames.Length)];
            }
        }
        public string LastName
        {
            get
            {
                var _lnames = "Potter, Voldemort, Granger, Dumbledore, Snape, Malfoy, Baggins, the Gray, Gamgee, Took, the White".Split(", ");
                return _lnames[rnd.Next(0, _lnames.Length)];
            }
        }
        public string FullName => $"{FirstName} {LastName}";

        public DateTime Date (int? fromYear=null, int? toYear = null)
        {
            bool dateOK = false;
            DateTime _date = default;
            while (!dateOK)
            {
                fromYear ??= DateTime.Today.Year;
                toYear ??= DateTime.Today.Year+1;

                try
                {
                    int year = rnd.Next(Math.Min(fromYear.Value, toYear.Value), 
                        Math.Max(fromYear.Value, toYear.Value));
                    int month = rnd.Next(1, 13);
                    int day = rnd.Next(1, 31);

                    _date = new DateTime(year, month, day);
                    dateOK = true;
                }
                catch
                {
                    dateOK = false;
                }
            }
            return _date;
        }

        public string Email (string fname=null, string lname=null)
        {
            fname ??= FirstName;
            lname ??= LastName;

            var _domains = "icloud.com, me.com, mac.com, hotmail.com, gmail.com".Split(", ");
            return $"{fname}.{lname}@{_domains[rnd.Next(0, _domains.Length)]}";
        }

        public string Country
        {
            get
            {
                var _country = "Stockholm, Copenhagen, Oslo, Helsinki".Split(", ");
                return _country[rnd.Next(0, _country.Length)];
            }
        }
    }
}


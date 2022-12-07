using System;
namespace RandomInit
{
	public interface IGetRandom
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get; }

        public DateTime Date(int? fromYear = null, int? toYear = null);
        public string Email(string fname = null, string lname = null);
        public string Country { get; }
    }
}


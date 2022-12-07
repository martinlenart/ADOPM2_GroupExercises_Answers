using System;
namespace RandomInit
{
	public interface IGetRandom
    {
        /// <summary>
        /// Returns a randomly generated FirstName, e.g. "Harry"
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Returns a randomly generated LastName, e.g. "Potter"
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Returns a randomly generated Fullname, e.g. "Harry Potter"
        /// </summary>
        public string FullName { get; }

        /// <summary>
        /// Return a random date between fromYear and toYear(inclusive).
        /// </summary>
        /// <param name="fromYear">null = this year</param>
        /// <param name="toYear">null = this year</param>
        /// <returns>generated date</returns>
        public DateTime Date(int? fromYear = null, int? toYear = null);

        /// <summary>
        /// Generates a random email address. 
        /// when fname and lname is provided the form fname.lname@... is used
        /// when fname=null or lname=null a random name is generated
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <returns>generated email address</returns>
        public string Email(string fname = null, string lname = null);
        
        /// <summary>
        /// Returns a generated random Country, e.g. "Stockholm"
        /// </summary>
        public string Country { get; }
    }
}


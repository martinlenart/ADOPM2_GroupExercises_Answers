using System;
namespace IEquatable_IComparable
{
	public interface IGetRandom
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get; }

        /// <summary>
        /// Return a random date between fromYear and toYear(inclusive).
        /// </summary>
        /// <param name="fromYear">null = this year</param>
        /// <param name="toYear">null = this year</param>
        /// <returns>the generated random date</returns>
        public DateTime Date(int? fromYear = null, int? toYear = null);

        /// <summary>
        /// Generates a random email address. when fname and lname is provided the form fname.lname@... is
        /// used.
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <returns></returns>
        public string Email(string fname = null, string lname = null);
        public string Country { get; }
    }
}


using System;
namespace IEquatable_IComparable
{
    public interface IPerson :IEquatable<IPerson>, IComparable<IPerson>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}
   

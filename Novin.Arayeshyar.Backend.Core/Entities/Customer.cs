using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class Customer
    {
        public string MobileNumber { get; set; }
        public string Password { get; set; }

        public Customer(string mobileNumber, string password)
        {
            MobileNumber = mobileNumber;
            Password = password;
        }

        public string? NationalCode { get; set; }
        public required string CustomerCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public Address? Address { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class Barber
    {
        public required string BarberCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Address? Addrees { get; set; }
        public string? NationalCode { get; set; }
        public string MobileNumber { get; set; }

        public Barber(string mobileNumber, string password)
        {
            MobileNumber = mobileNumber;
            Password = password;
        }

        public string Password { get; set; }
        public string? Gender { get; set; }
    }
}

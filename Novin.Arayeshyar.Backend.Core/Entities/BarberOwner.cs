using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class BarberOwner
    {
        public required string BarberOwnerCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public required Address Address { get; set; }
        public int LicenseCode { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }

        public BarberOwner(string mobileNumber, string password, int licenseCode)
        {
            MobileNumber = mobileNumber;
            Password = password;
            LicenseCode = licenseCode;
        }

        public string? NationalCode { get; set; }
        public string? Gender { get; set; }
    }
}

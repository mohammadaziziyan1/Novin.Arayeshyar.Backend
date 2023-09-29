using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class Address
    {
        public required string FullAddress { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? Alley { get; set; }
        public int? Plaque { get; set; }
        public required string PostalCode { get; set; }
    }
}

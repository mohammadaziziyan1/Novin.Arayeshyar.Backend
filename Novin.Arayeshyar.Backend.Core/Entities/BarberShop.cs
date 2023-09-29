using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class BarberShop
    {
        public required string BarberShopCode { get; set; }
        public string? Name { get; set; }
        public required Address Address { get; set; }
        public required string Tel { get; set; }
    }
}

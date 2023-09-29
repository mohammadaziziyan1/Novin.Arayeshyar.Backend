using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class Makeup
    {
        public required string MakeUpCode { get; set; }
        public required string Model { get; set; }
        public required string MakeUpType { get; set; }
    }
}

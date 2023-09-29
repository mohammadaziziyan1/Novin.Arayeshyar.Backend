using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class Cost
    {
        public required string CostCode { get; set; }
        public required string CustomerCode { get; set; }
        public required string PaymentMethod { get; set; }
        public required string BankName { get; set; }
        public required DateTime Date { get; set; }
        public required DateTime Time { get; set; }
        public required double Amount { get; set; }


    }
}

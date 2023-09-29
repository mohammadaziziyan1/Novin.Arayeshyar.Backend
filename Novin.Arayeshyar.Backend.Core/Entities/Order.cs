using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class Order
    {
        public required string MakeUpCode { get; set; }
        public required string OrderCode { get; set; }
        public required string BarberCode { get; set; }
        public required string CustomerCode { get; set; }
        public required double Amount { get; set; }
        public required DateTime Date { get; set; }
        public required DateTime AttendanceTime { get; set; }//ساعت حضور مشتری
    }
}

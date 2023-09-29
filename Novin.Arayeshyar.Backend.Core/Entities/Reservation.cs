using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class Reservation
    {
        public required string ReservationCode { get; set; }
        public required string BarberCode { get; set; }
        public required string CustomerCode { get; set; }
        public required DateTime ReservationTime { get; set; }
        public required DateTime ReservationDate { get; set; }
        public required string ReservationType { get; set; }
        public string? MakeUpCode { get; set; }
        public required double Deposit { get; set; }//بیعانه
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class Survey
    {
        public required string SurveyCode { get; set; }
        public required string CustomerCode { get; set; }
        public required string SurveyType { get; set; }
        public DateTime Date { get; set; }
    }
}

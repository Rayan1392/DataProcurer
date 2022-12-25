using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FreeFloatShare
    {
        public int Id { get; set; }
        public long InsCode { get; set; }
        public decimal? FreeFloat { get; set; }
        public long? TotalShares { get; set; }
        public long? FreeFloatShares { get; set; }
    }
}

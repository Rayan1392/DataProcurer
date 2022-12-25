using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs.Response
{
    [DataContract]
    public class FreeFloatShareDto
    {
        [DataMember]
        public long InsCode { get; set; }
        [DataMember]
        public decimal? FreeFloat { get; set; }
        [DataMember]
        public long? TotalShares { get; set; }
        [DataMember]
        public long? FreeFloatShares { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs.Response
{
    [DataContract]
    public class TradeClientDto
    {
        [DataMember]
        public long InsCode { get; set; }
        [DataMember]
        public DateTime TradeDate { get; set; }
        [DataMember]
        public int? RealAskCount { get; set; }
        [DataMember]
        public int? LegalAskCount { get; set; }
        [DataMember]
        public float? RealAskVolume { get; set; }
        [DataMember]
        public float? LegalAskVolume { get; set; }
        [DataMember]
        public int? RealBidCount { get; set; }
        [DataMember]
        public int? LegalBidCount { get; set; }
        [DataMember]
        public float? RealBidVolume { get; set; }
        [DataMember]
        public float? LegalBidVolume { get; set; }
    }
}

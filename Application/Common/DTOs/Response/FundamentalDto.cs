using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs.Response
{
    [DataContract]
    public class FundamentalDto
    {
        [DataMember]
        public long InsCode { get; set; }
        [DataMember]
        public string InstrumentID { get; set; }
        [DataMember]
        public decimal CurrentRatio { get; set; }
        [DataMember]
        public decimal DebtToEquityRatio { get; set; }
        [DataMember]
        public decimal GrossProfitMargin { get; set; }
        [DataMember]
        public decimal OperatingProfitMargin { get; set; }
        [DataMember]
        public decimal NetProfitMargin { get; set; }
        [DataMember]
        public decimal NetProgiftGrowth { get; set; }
        [DataMember]
        public decimal ROEGrowth { get; set; }
        [DataMember]
        public decimal ROIGrowth { get; set; }
        [DataMember]
        public decimal PE { get; set; }
        [DataMember]
        public decimal PS { get; set; }
    }
    
}

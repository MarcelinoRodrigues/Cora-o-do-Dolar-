using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolarHG
{
    public class Currency
    {
        [JsonProperty(propertyName: "name")]
        public string Name { get; set; }
        [JsonProperty(propertyName: "buy")]
        public decimal Buy { get; set; }
        [JsonProperty(propertyName: "sell")]
        public decimal Sell { get; set; }
        [JsonProperty(propertyName: "variation")]
        public decimal Variation { get; set; }
    }
}

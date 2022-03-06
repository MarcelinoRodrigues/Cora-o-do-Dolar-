﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolarHG
{
    public class Market
    {
        public Market()
        {
            this.Currency = new Currency();
        }

        [JsonProperty(propertyName: "currencies")]
        public Currency Currency { get; set; }
    }
}

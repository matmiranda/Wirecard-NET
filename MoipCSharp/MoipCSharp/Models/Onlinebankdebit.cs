﻿using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Onlinebankdebit
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string bankNumber { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string expirationDate { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string bankName { get; set; }
    }
}
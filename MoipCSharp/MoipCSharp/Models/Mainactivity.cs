﻿using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Mainactivity
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string cnae { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string description { get; set; }
    }
}
﻿using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Card
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string brand { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool store { get; set; }
    }
}
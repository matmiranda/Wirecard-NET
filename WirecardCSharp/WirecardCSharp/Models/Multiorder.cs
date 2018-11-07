using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Multiorder
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string href { get => Href; set => value = Href; }
    }
    public partial class Multiorder
    {
        [JsonProperty("href", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Href { get; set; }
    }
}

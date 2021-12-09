using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotAPI
{
    public class Match
    {
        [JsonProperty(PropertyName = "info")]
        public Info Info { get; set; }
    }
}

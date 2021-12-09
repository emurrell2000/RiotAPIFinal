using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotAPI
{
    public class Info
    {
        [JsonProperty(PropertyName = "participants")]
        public List<Participant> Participants { get; set; }
    }
}

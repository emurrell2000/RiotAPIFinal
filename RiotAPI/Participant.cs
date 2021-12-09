using Newtonsoft.Json;

namespace RiotAPI
{
    public class Participant
    {
        [JsonProperty(PropertyName = "championName")]
        public string ChampionName { get; set; }

        [JsonProperty(PropertyName = "champLevel")]
        public int ChampionLevel { get; set; }

        [JsonProperty(PropertyName = "teamPosition")]
        public string Position { get; set; }

        [JsonProperty(PropertyName = "kills")]
        public int Kills { get; set; }

        [JsonProperty(PropertyName = "deaths")]
        public int Deaths { get; set; }

        [JsonProperty(PropertyName = "assists")]
        public int Assists { get; set; }

        [JsonProperty(PropertyName = "totalMinionsKilled")]
        public int MinionsKilled { get; set; }

        [JsonProperty(PropertyName = "turretKills")]
        public int TurretsKilled { get; set; }

        [JsonProperty(PropertyName = "visionScore")]
        public int VisionScore { get; set; }

        [JsonProperty(PropertyName = "win")]
        public bool MatchResult { get; set; }

        [JsonProperty(PropertyName = "firstBloodKill")]
        public bool FirstBlood { get; set; }

        [JsonProperty(PropertyName = "firstTowerKill")]
        public bool FirstTurret { get; set; }

        [JsonProperty(PropertyName = "largestCriticalStrike")]
        public int LargestCriticalStrike { get; set; }

        [JsonProperty(PropertyName = "timeCCingOthers")]
        public int TotalCCDuration { get; set; }

        [JsonProperty(PropertyName = "largestMultiKill")]
        public int HighestMultikill { get; set; }

        [JsonProperty(PropertyName = "totalDamageDealt")]
        public int TotalDamageDealt { get; set; }

        [JsonProperty(PropertyName = "physicalDamageDealt")]
        public int PhysicalDamageDealt { get; set; }

        [JsonProperty(PropertyName = "magicDamageDealt")]
        public int MagicDamageDealt { get; set; }

        [JsonProperty(PropertyName = "trueDamageDealt")]
        public int TrueDamageDealt { get; set; }

        [JsonProperty(PropertyName = "totalDamageTaken")]
        public int TotalDamageTaken { get; set; }

        [JsonProperty(PropertyName = "physicalDamageTaken")]
        public int PhysicalDamageTaken { get; set; }

        [JsonProperty(PropertyName = "magicDamageTaken")]
        public int MagicDamageTaken { get; set; }

        [JsonProperty(PropertyName = "trueDamageTaken")]
        public int TrueDamageTaken { get; set; }

        [JsonProperty(PropertyName = "totalHeal")]
        public int HealingDone { get; set; }

        [JsonProperty(PropertyName = "totalDamageShieldedOnTeammates")]
        public int ShieldingDone { get; set; }

        [JsonProperty(PropertyName = "damageSelfMitigated")]
        public int DamageMitigated { get; set; }

        [JsonProperty(PropertyName = "summonerName")]
        public string SummonerName { get; set; }
    }
}

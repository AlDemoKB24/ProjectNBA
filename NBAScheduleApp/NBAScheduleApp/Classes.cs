using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NBAScheduleApp
{
    public class Team
    {
        [JsonProperty("strTeam")]
        public string Name { get; set; }

        [JsonProperty("strStadium")]
        public string Stadium { get; set; }

        public class Match
        {
            [JsonProperty("dateEvent")]
            public string Date { get; set; }

            [JsonProperty("strHomeTeam")]
            public string HomeTeam { get; set; }

            [JsonProperty("strAwayTeam")]
            public string AwayTeam { get; set; }

            [JsonProperty("intHomeScore")]
            public string HomeScore { get; set; }

            [JsonProperty("intAwayScore")]
            public string AwayScore { get; set; }

            public string Score => HomeScore != null ? $"{HomeScore} - {AwayScore}" : "Не сыгран";
        }
        public class TeamsResponse
        {
            [JsonProperty("teams")]
            public List<Team> Teams { get; set; }
        }

        public class MatchesResponse
        {
            [JsonProperty("events")]
            public List<Match> Events { get; set; }
        }
    }
}

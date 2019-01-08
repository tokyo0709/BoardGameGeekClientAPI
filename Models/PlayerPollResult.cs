using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameGeekClientAPI.Models
{
    public class PlayerPollResult
    {
        public int NumPlayers { get; set; }
        public int Best { get; set; }
        public int Recommended { get; set; }
        public int NotRecommended { get; set; }

        public bool NumPlayersIsAndHigher { get; set; }
    }
}
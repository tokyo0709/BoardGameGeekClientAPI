using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameGeekClientAPI.Models
{
    public class ChallengeItem
    {
        public string Name { get; set; }
        public int GameId { get; set; }
        public List<int> AdditionalGameIds { get; set; }
        public string Image { get; set; }
        public string Thumbnail { get; set; }
        public List<DateTime> Plays { get; set; }
        public int PlayCount { get; set; }
        public bool Complete { get; set; }
    }
}
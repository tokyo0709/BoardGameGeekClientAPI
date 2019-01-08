using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameGeekClientAPI.Models
{
    public class HotGame
    {
        public int Rank { get; set; }
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public int YearPublished { get; set; }
    }
}
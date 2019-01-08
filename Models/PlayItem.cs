using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameGeekClientAPI.Models
{
    public class PlayItem
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Thumbnail { get; set; }
        public DateTime PlayDate { get; set; }
        public int NumPlays { get; set; }
        public string Comments { get; set; }
    }
}
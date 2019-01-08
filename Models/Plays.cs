using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameGeekClientAPI.Models
{
    public class Plays
    {
        public int Total { get; set; }
        public IEnumerable<PlayItem> Items { get; set; }
    }
}
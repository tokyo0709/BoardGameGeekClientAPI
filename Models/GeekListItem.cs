using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameGeekClientAPI.Models
{
    public class GeekListItem
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int? ImageId { get; set; }
        public string Description { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameGeekClientAPI.Models
{
    public class GeekList
    {
        public int GeekListId { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<GeekListItem> Items { get; set; }
    }
}
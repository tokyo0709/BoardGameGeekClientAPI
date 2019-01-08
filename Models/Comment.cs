using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameGeekClientAPI.Models
{
    public class Comment
    {
        public string Username { get; set; }
        public decimal Rating { get; set; }
        public string Text { get; set; }
    }
}
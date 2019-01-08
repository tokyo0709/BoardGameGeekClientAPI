using System.Collections.Generic;

namespace BoardGameGeekClientAPI.Models
{
    public class Challenge
    {
        public int GeekListId { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public List<ChallengeItem> Items { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int GoalPerGame { get; set; }
        public bool Complete { get; set; }
    }
}
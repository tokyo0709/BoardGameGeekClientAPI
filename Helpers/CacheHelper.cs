using System.Runtime.Caching;

namespace BoardGameGeekClientAPI.Helpers
{
    public static class CacheHelper
    {
        public static MemoryCache Default = new MemoryCache("CustomCache");

        public static string CollectionKey(string username, bool grouped, bool details)
        {
            return "collection:" + (grouped ? "grouped:" : "ungrouped:") + (details ? "detailed:" : "basic:") + username;
        }

        public static string ThingKey(int id)
        {
            return "thing:" + id.ToString();
        }

        public static string PlaysKey(string username)
        {
            return "plays:" + username;
        }

        public static string LongThingKey(int id)
        {
            return "longthing:" + id.ToString();
        }

        public static string ChallengeKey(int id)
        {
            return "challenge:" + id.ToString();
        }

    }
}

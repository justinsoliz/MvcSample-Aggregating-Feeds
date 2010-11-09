using System;

namespace Api
{
    public class FeedItem
    {
        public FeedSource FeedSource { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }
        public bool Today { get; set; }
    }

    public enum FeedSource
    {
        Facebook,
        Twitter,
        Github,
        StackOverflow
    }
}

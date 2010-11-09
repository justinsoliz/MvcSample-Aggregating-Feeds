using System;
using System.Collections.Generic;

namespace Api
{
    public class Feed
    {
        private DateTime utcNow = DateTime.Now;

        public IEnumerable<FeedItem> Stream() {

            var feedItems = new List<FeedItem> {
                    new FeedItem
                        {
                            FeedSource = FeedSource.StackOverflow,
                            Content =
                                "Added a new comment - Why can't I use Html helper methods with strongly-typed views in ASP.NET MVC 2?",
                            DatePosted = new DateTime(2010,11,8),
                            Today = GetLiteralDate(new DateTime(2010,11,8))
                        },
                    new FeedItem
                        {   
                            FeedSource = FeedSource.Twitter,
                            Content =
                                "Who thinks Wade Phillips will have a job tomorrow?",
                            DatePosted = new DateTime(2010,11,7),
                            Today = GetLiteralDate(new DateTime(2010,11,7))
                        },
                    new FeedItem
                        {
                            FeedSource = FeedSource.Facebook,
                            Content = "Added new images to the Album, Halloween 2010",
                            DatePosted = new DateTime(2010,11,5),
                            Today = GetLiteralDate(new DateTime(2010,11,5))
                        }
            };

            return feedItems;
            //var feedItems = GetTwitterUpdates().ToList();
            //feedItems.AddRange(GetStackOverFlowUpdates());


            //// Grab the 10 most recent regardless of source
            //return feedItems.OrderByDescending(x => x.DatePosted).Take(10).ToList();
        }

        //protected IEnumerable<FeedItem> GetTwitterUpdates() {

        //    var client = new Twitter.Client();
        //    var updates = client.GetStatusUpdates("justinsoliz", 5);


        //    var twitterUpdates = updates.Select(update => new FeedItem {
        //        FeedSource = FeedSource.Twitter,
        //        Content = update.FormattedText,
        //        DatePosted = update.CreatedAt,
        //        Today = GetLiteralDate(update.CreatedAt)
        //    }).ToList();

        //    return twitterUpdates;
        //}
        //// <a href=\"$1\">$1</a>
        //protected IEnumerable<FeedItem> GetStackOverFlowUpdates(){
        //    var url = "http://stackoverflow.com/questions/";
        //    var feedItems = new List<FeedItem>();
        //    var updates = Stack.Client.GetAllUserEvents(407202);
        //    foreach (var update in updates){
        //        var datePosted = update.CreationDate.AddHours(-6);
        //        if (update.Action == "comment") {
        //            feedItems.Add(new FeedItem {
        //                FeedSource = FeedSource.StackOverflow,
        //                Content = String.Format("Added a new comment - <a href=\"{0}{1}\" target=\"_blank\">{2}</a>",
        //                url,update.PostId, update.Description),
        //                DatePosted = datePosted,
        //                Today = GetLiteralDate(datePosted)
        //            });
        //        }
        //        if (update.Action == "answered") {
        //            feedItems.Add(new FeedItem {
        //                FeedSource = FeedSource.StackOverflow,
        //                Content = String.Format("Added a new answer - <a href=\"{0}{1}\" target=\"_blank\">{2}</a>",
        //                url, update.PostId, update.Description),
        //                DatePosted = datePosted,
        //                Today = GetLiteralDate(datePosted)
        //            });
        //        }
        //        if (update.Action == "asked") {
        //            feedItems.Add(new FeedItem {
        //                FeedSource = FeedSource.StackOverflow,
        //                Content = String.Format("Added a new question - <a href=\"{0}{1}\" target=\"_blank\">{2}</a>",
        //                url, update.PostId, update.Description),
        //                DatePosted = datePosted,
        //                Today = GetLiteralDate(datePosted)
        //            });
        //        }
        //        if (update.Action == "awarded") {
        //            feedItems.Add(new FeedItem {
        //                FeedSource = FeedSource.StackOverflow,
        //                Content = String.Format("Awarded Badge - {0}", update.Description),
        //                DatePosted = datePosted,
        //                Today = GetLiteralDate(datePosted)
        //            });
        //        }
        //    }
        //    return feedItems;
        //}

        private bool GetLiteralDate(DateTime date) {
            return date.Year == utcNow.Year
                && date.Month == utcNow.Month
                && date.Day == utcNow.Day;
        }
    }
}

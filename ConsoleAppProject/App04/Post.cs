using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        public int PostId { get; }

        /// <summary>
        /// Username of the post's author
        /// </summary>
        public String Username { get; }

        /// <summary>
        /// Properties
        /// </summary>
        public DateTime Timestamp { get; }
        public static double Count { get; private set; }
        public IEnumerable<Post> posts { get; private set; }

        private static int instances = 0;
        
        private int likes;

        private int unlikes;

        private readonly List<String> comments;


        /// <summary>
        /// Post Class
        /// </summary>
        public Post(string author)
        {
            instances++;
            PostId = instances;

            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }


        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>        
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        ///<summary>
        /// Display the details of this post.
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Post ID: {PostId}");
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes >= 0)
            {
                Console.WriteLine($"    Likes:  {likes}  people liked this.");
            }
            if (unlikes < 0)
            {
                Console.WriteLine($"    Unlikes:  {unlikes}  people unliked this. ");
            }
            else 
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    Comments: {comments.Count} peoples comments.");
                foreach (string comment in comments)
                    Console.WriteLine("   " +  comment);
            }
        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}

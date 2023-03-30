using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Imaan Majid
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Imaan";

        private readonly List<Post> posts;

        ///<summary>
        /// Construct a news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();

            MessagePost post = new MessagePost(AUTHOR, "I love playing football");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "Football.jpg", "My Football Team");
            AddPhotoPost(photoPost);

        }

        /// <summary>
        /// Constructor for unliking post
        /// </summary>

        public void UnlikePost(int id)
        {
            Post post = FindPost(id);

            if (post != null)
            {
                post.Unlike();
            }
            else
            {
                Console.WriteLine(" Error: ID not found ");
            }
        }

        /// <summary>
        /// Constructor for liking a post
        /// </summary>

        public void LikePost(int id)
        {
            Post post = FindPost(id);

            if (post != null)
            {
                post.Like();
            }
            else
            {
                Console.WriteLine(" Error: ID not found ");
            }
        }

        /// <summary>
        /// Constructor for adding a comment
        /// </summary>

        public void AddComment(int id, string comment)
        {
            Post post = FindPost(id);

            if (post != null)
            {
                post.AddComment(comment);
            }
            else
            {
                Console.WriteLine(" Error: ID not found ");
            }
        }

        ///<summary>
        /// Add a text post to the news feed.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        /// <summary>
        /// Add a photo post to the news feed.
        /// </summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        /// <summary>
        /// Constructor for removing a post
        /// </summary>

        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($" \nPost with ID = {id} does not exist!!\n");
            }
            else
            {
                Console.WriteLine($" \nThe following Post {id} has been removed!\n");

                posts.Remove(post);
                post.Display();
            }
        }

        /// <summary>
        /// Constructor for finding a post
        /// </summary>

        public Post FindPost(int id)
        {
            foreach (Post post in posts)
            {
                if(post.PostId == id)
                {
                    return post;
                }
            }

            return null;
        }



        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }

        /// <summary>
        /// Constructor for Displaying posts of an author
        /// </summary>

        public void DisplayByAuthor(string author)
        {
            foreach (Post post in posts)
            {
                if (post.Username == author)
                {
                    post.Display();
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Constructor for Getting the number of posts
        /// </summary>

        public int GetNumberOfPosts() 
        { 
            return posts.Count; 
        }
    }

}

using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class Networkapp
    {
        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("    Imaan's News Feed");

            string[] choices = new string[]
            {
                "Post Message",
                "Post Image",
                "Remove Post",
                "Display All Posts",
                "Display Posts by Author",
                "Add Comments to Post",
                "Like Post",
                "Unlike Post",
                "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: AddComment(); break;
                    case 7: LikePosts(); break;
                    case 8: UnlikePosts(); break;
                    case 9: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void DisplayByAuthor()
        {
            ConsoleHelper.OutputTitle($" All Posts Displayed by Author ");
            Console.WriteLine();

            


        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($" Removing a Post ");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the post id > ",
                                                    1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Image");

            string author = InputName();

            Console.Write(" Please enter your image filename > ");
            string filename = Console.ReadLine();

            Console.Write(" Please enter your image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle(" You have just posted this image: ");
            post.Display();
        }

        private string InputName()
        {
            Console.Write(" Please enter your name > ");
            string author = Console.ReadLine();

            return author;
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle(" Posting a Message ");

            string author = InputName();

            Console.Write(" Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle(" You have just posted this message: ");
            post.Display();
        }

        private void UnlikePosts()
        {
            Console.WriteLine(" UnLiking a Post ");
            Console.WriteLine();

            int id = (int)ConsoleHelper.InputNumber(" Please enter the ID of the post you want to unlike ");

            news.UnlikePost(id);
        }
        private void LikePosts()
        {
            Console.WriteLine(" Liking a Post ");
            Console.WriteLine();

            int id = (int)ConsoleHelper.InputNumber(" Please enter the ID of the post you want to like ");

            news.LikePost(id);
        }

        private void AddComment()
        {
            Console.WriteLine(" Adding a comment to a post ");
            Console.WriteLine();

            int id = (int)ConsoleHelper.InputNumber(" Please enter the ID of the post you would like to comment under ");

            Console.WriteLine(" Please enter the comment ");
            string comment = Console.ReadLine();

            news.AddComment(id, comment);
        }
    }
}

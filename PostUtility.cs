using System;
using System.Collections.Generic;

namespace pa1
{
    public class PostUtility
    {
        public static List<Posts> SortAllPosts(List<Posts> post)
        {
            post.Sort((x, y) => y.CompareTo(x));
            return post;
        }

        public static void DisplayAllPosts(List<Posts> posts)
        {
            foreach(Posts post in posts)
            {
                Console.WriteLine(post.ToString());
            }
        }

        public static List<Posts> DeletePost(List<Posts> post)
        {
            int input = int.Parse(Console.ReadLine());
            int foundIndex = post.FindIndex(tempPost => tempPost.ID == input);
            try
            {
            if(foundIndex != -1)
            {
                post.RemoveAt(foundIndex);
            }
            }
            catch(Exception e)
            {
                Console.WriteLine("Post ID not found... " + e.Message);
                return post;
            }

                    
            return post;

        }

        public static List<Posts> AddPost(List<Posts> post)
        {
            Random rand = new Random();
            string userPost = Console.ReadLine();
            post.Add(new Posts(){ID = rand.Next(1, 1000), Text = userPost, Stamp = DateTime.Now});

            return post;
        }
    }
}
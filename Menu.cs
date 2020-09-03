using System;
using System.Collections.Generic;


namespace pa1
{
    public class Menu
    {
        public static void Option1(List<Posts> posts)
        {
            Console.Clear();
            Console.WriteLine("");
            PostUtility.SortAllPosts(posts);
            PostUtility.DisplayAllPosts(posts);
            Console.WriteLine("\nHere is a list of all posts sorted by most recent.\nPress a key to return to the main menu.\n");

            Console.ReadKey();
            Console.Clear();
        }
        public static void Option2(List<Posts> posts)
        {
            Console.Clear();
            Console.WriteLine("");
            PostUtility.SortAllPosts(posts);
            PostUtility.DisplayAllPosts(posts);

            Console.WriteLine("\nHere is a list of all posts sorted by most recent.\nType out a post and hit enter to upload it!\n");
            PostUtility.AddPost(posts);
            Console.WriteLine("");

            PostUtility.SortAllPosts(posts);
            PostUtility.DisplayAllPosts(posts);

        }
        public static void Option3(List<Posts> posts)
        {
            Console.Clear();
            Console.WriteLine("");
            PostUtility.SortAllPosts(posts);
            PostUtility.DisplayAllPosts(posts);

            Console.WriteLine("\nHere is a list of all posts sorted by most recent.\nPlease input a post ID to delete that post.");
            PostUtility.DeletePost(posts);
            Console.WriteLine("");
            
            PostUtility.SortAllPosts(posts);
            PostUtility.DisplayAllPosts(posts);
            
        }
    }
}
using System;
using System.Collections.Generic;

namespace pa1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Posts> allPosts = PostFile.GetAllPosts();
            do
            {
                Console.WriteLine("\nIt is time for you to help Big Al go Social. Please select an option below, and press Enter:\n\nSelect '1' to view all posts\nSelect '2' to Add a new post\nSelect '3' to Delete an existing post\nSelect '4' to Exit the application");
                switch(Console.ReadLine())
                {
                    case "1": Menu.Option1(allPosts);
                    break;
                    case "2": Menu.Option2(allPosts);
                    break;
                    case "3": Menu.Option3(allPosts);
                    break;
                    case "4": Console.Clear();
                              Console.WriteLine("Thanks for coming!");
                              Environment.Exit(0);
                    break;  
                    default: Console.WriteLine("Please select a number available on the menu.\n");
                    break;
                }
            } while(true);
        }
    }
}

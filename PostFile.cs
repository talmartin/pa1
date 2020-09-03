using System;
using System.IO;
using System.Collections.Generic;


namespace pa1
{
    public class PostFile
    {
        public static List<Posts> GetAllPosts()
        {
            List<Posts> allPosts = new List<Posts>();
            StreamReader inFile = null;

            try
            {
                inFile = new StreamReader("posts.txt");
            }
            catch(Exception e)
            {
                Console.WriteLine("Oops! Something went wrong... " + e.Message);
                return allPosts;
            }

            string line = inFile.ReadLine();
            while(line != null)
            {
                string[] temp = line.Split("#");
                allPosts.Add(new Posts(){ID = int.Parse(temp[0]), Text = temp[1], Stamp = DateTime.Parse(temp[2])});
                line = inFile.ReadLine();
                
            }

            inFile.Close();

            return allPosts;
            
        }
    }
}
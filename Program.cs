using System;

namespace StackOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            var post = new StackOverFlow();
            Console.WriteLine("Enter post title: \n");
            post.Title = Console.ReadLine();
            Console.WriteLine("Enter description of problem for post body");
            post.PostBody = Console.ReadLine();

            Console.WriteLine($"Title: {post.Title}");
            Console.WriteLine($"Created on: {post.Created}");
            Console.WriteLine($"Body: \n{post.PostBody}");
            
            while (active)
            {
                Console.WriteLine("Press [u]p vote or [d]own vote: ");
                var input = Console.ReadLine();
                if (input == "u" || input == "d")
                {
                    post.UpdateScore(input);
                    Console.WriteLine(post.Score);
                }
                else
                {
                    Console.WriteLine($"Final post score was: {post.Score}");
                    active = false;
                }
            }
        }
    }
}
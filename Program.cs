using System;

namespace StackOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new StackOverFlow();
            post.Title = "First new post";
            post.PostBody = "This is where I will post some drivel that is simple";

            Console.WriteLine($"You created a new post titled: {post.Title}");
            Console.WriteLine($"The body of the post is \n{post.PostBody}");
        }
    }

    class StackOverFlow
    {
        private string _title;
        private string _postBody;

        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        public string PostBody
        {
            get => _postBody;
            set => _postBody = value;
        }
    }
}
using System;
using Instagram.Models;

namespace Instagram.Models
{
    public class Post
    {
        public Post()
        {
        }
        public int User { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public virtual void AddPost()
        {
            this.Type = "Images";
            Console.WriteLine("You have uploaded a new posts");
        }
        public void AddPost(string NewPosts)
        {
            this.Type = NewPosts;
        }
    }
}

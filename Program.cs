using System;
using Blog_entityframework.Data;
using Blog_entityframework.Models;

namespace Blog_entityframework
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new DataContext();
            
             var user = new User {
                Name = "John Doe",
                Email = "johndoe@example.com",
                PasswordHash = "1234567890",
                Bio = "I'm a software engineer.",
                Image = "https://balta.io",
                Slug = "john-doe"
            };

            var category = new Category {
                Name = "Backend",
                Slug = "backend"
            };

            var post = new Post {
                Author = user,
                Category = category,
                Title = "My First Blog Post",
                Slug = "my-first-blog-post",
                Body = "<p>This is the content of my first blog post.</p>",
                Summary = "Neste artigo tem um exemplo legal", 
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };

            context.Posts.Add(post);
            context.SaveChanges();       
        }
    }
}

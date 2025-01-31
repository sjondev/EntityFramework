using System;
using System.Linq;
using Blog_entityframework.Data;
using Blog_entityframework.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog_entityframework
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new DataContext();

            // context.Users.Add(new User {
            //     Bio ="2x Microsoft MVP",
            //     Email = "jonatassilva.doe@example.com",
            //     Image = "jonatas.jpg",
            //     Name = "Jonatas Silva",
            //     PasswordHash = "1234",
            //     Slug = "jonatas-silva"
            // });
            
            var user = context.Users.FirstOrDefault();
            var post = new Post {
                Author = user,
                Body = "Hello World!",
                Category = new Category {
                    Name = "Backend",
                    Slug = "backend"
                },
                CreateDate = System.DateTime.Now,
                Slug = "hello-world",
                Summary = "Ola mundo para que a maldição não me pegue!",
                Title = "Hello World"
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
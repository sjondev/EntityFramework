using System;
using System.Linq;
using Blog_entityframework.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog_entityframework
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new DataContext();

            var posts = context.PostsWithContTags.ToList();                            
            foreach (var post in posts) {
                Console.WriteLine($"{post.Name} {post.Count}");
            }
            
        }
    }
}
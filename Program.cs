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
            
             var post = context.Posts
            // .AsNoTracking() // AQUI ELE VAI PRECISAR DO TRACKING para pegar a referencia do ID do Author e do Category
            .Include(x => x.Author)
            .Include(x => x.Category)
            .OrderByDescending(x => x.LastUpdateDate)
            .FirstOrDefault();
            post.Author.Name = "Jonatas silva";
            context.Posts.Update(post);
            context.SaveChanges();
        }
    }
}
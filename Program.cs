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
            
             var posts = context
                .Posts
                .AsNoTracking()
                // .Where(x => x.AuthorId == 7)
                .Include(x => x.Author) // o include ele faz um INNER JOIN para trazer os valores da tabela.
                .Include(x => x.Category)
                .ThenInclude(x => x.Name) // evitar essa abordagem porque pode trazer SUBSELECTS e isso pode gerar perca de perfomace nas consultas
                .OrderByDescending(x => x.LastUpdateDate)
                .ToList();

            foreach (var post in posts) Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em categoria {post.Category?.Name}");
        }
    }
}
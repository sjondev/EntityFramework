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
            using (var context = new DataContext()) 
            {
               var list = context.Posts
                    .AsNoTracking() // Serve para melhorar a performace de consulta, não vale a pena trabalhar com ele em Delete e Update porque pode dar uma cagadinha caso ele esteja relacionado com alguma tabela que tem chave estrangeira.
                    .ToList();

                foreach (var post in list)
                {
                    Console.WriteLine($"Post: {post.Title}");
                    Console.WriteLine($"Sumario: {post.Summary}");
                    Console.WriteLine($"Data de criação: {post.CreateDate}");
                }
            }
        }
    }
}

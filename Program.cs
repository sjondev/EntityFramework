using System;
using System.Linq;
using Blog_entityframework.Data;

namespace Blog_entityframework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext()) 
            {
               var list = context
                            .Posts
                            .Where(p => p.Title.Contains("aspnet")) // -- ISSO AQUI É LINQ UM FILTRO
                            .ToList(); // To list sempre tem que ficar no final para ter uma boa performace. porque precisamos fazer filtros ou seja trabalhar com LINQ!!!

               foreach (var post in list){
                 Console.WriteLine($"{post.Title}");
               }
            }
        }
    }
}

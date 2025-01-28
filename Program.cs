using System;
using Blog_entityframework.Data;
using Blog_entityframework.Models;

namespace Blog_entityframework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext()) 
            {
                var tag = new Tag {Name = "Program", Slug = "aspnet-program"};
                context.Tags.Add(tag);
                context.SaveChanges(); // Save changes pega os todos os valores que estão na memoria e salva do banco de dados
            }
        }
    }
}

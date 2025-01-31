using System;
using System.Collections.Generic;
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
        }


        public static List<Post> GetPosts (DataContext context, int skip = 0, int take = 25)
        {
            /*
                Utilizando uma paginação caso um dia se minha base de dados tiver 1milhão de linhas 
                pelomenos quando for trazer esses dados eu vou trazer no maximo 25 em 25
            */
            var posts = context.Posts
                .AsNoTracking()
                .Skip(skip)
                .Take(take)
                .ToList();

            return posts;
        }
    }
}
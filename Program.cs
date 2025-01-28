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
                var item = context.Posts
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Id == 50); // Aqui vou trabalhar as ferramentas de filtragem para mostrar como lidar com um erro caso não exista algum valor
                Console.WriteLine(item?.Title); // Aqui voce pode analisar que estou colocando um PONTO DE INTERROGAÇÃO na frente do "item?" ele evita dar um erro de throw new Exception
                Console.WriteLine(item.Slug); // Ao contrario desse aqui que vai estar sem e pode dar um erro
            }
        }
    }
}

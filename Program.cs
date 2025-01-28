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

                var item2 = context.Posts
                    .AsNoTracking()
                    .SingleOrDefault(x => x.Id == 50); // O sigle é quase a mesma coisa que o FirstOrDefault unica coisa que muda nele é o fato de que ele da um erro caso encontre 2 Ids mesmo que ele.
                Console.WriteLine(item?.Title); 
                Console.WriteLine(item.Slug); 

                var item3 = context.Posts
                    .AsNoTracking()
                    .First(x => x.Id == 50); // First sempre ira trazer o primeiro valor sem trazer um valor padrão ou seja um valor nulo
                Console.WriteLine(item?.Title);
                Console.WriteLine(item.Slug);

                var item4 = context.Posts
                    .AsNoTracking()
                    .First(x => x.Id == 50); // Sigle é mesma coisa do first somente com aquele detalhe do erro caso encontre um Id duplicado.
                Console.WriteLine(item?.Title);
                Console.WriteLine(item.Slug);
            }
        }
    }
}

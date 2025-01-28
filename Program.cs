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
               // Update sem Tracking
                var tag = context.Tags.FirstOrDefault(x => x.Id == 3);
                tag.Name= ".NET";
                tag.Slug= "dotnet";

                context.Update(tag);
                context.SaveChanges();
            }
        }
    }
}

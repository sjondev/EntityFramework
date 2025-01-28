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
               // Delete sem Tracking
                var tag = context.Tags.FirstOrDefault(x => x.Id == 3);
                context.Remove(tag); 
                context.SaveChanges();
            }
        }
    }
}

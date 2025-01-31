using Blog_entityframework.Data;
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
                        .Include(x => x.Author)
                            /* em alguns cenarios vamos usar o theninlude porem deve ser envitado 
                            porque ele execulta um subselect no sql e isso não é bom porque
                            perde performace no banco de dados. */
                            .ThenInclude(x => x.Roles); 
                            
            

        }
    }
}
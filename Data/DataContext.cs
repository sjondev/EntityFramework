using Blog_entityframework.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog_entityframework.Data 
{
    public class DataContext : DbContext 
    {
        // Por enquanto agente não vai usar esses caras aqui porque eles não tem chave primaria somente chave composta
        // public DbSet<UserRole> UserRoles {get; set;}
        // public DbSet<PostTag> PostTags { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles {get; set;}
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=localhost,1433;Database=Blog;User ID=SA;Password=1q2w3e4r@#$;TrustServerCertificate=True;");
    }
}
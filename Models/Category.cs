using System.Collections.Generic;

namespace Blog_entityframework.Models
{
    public class Category 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public List<Post> Posts{ get; set; }
    }
}
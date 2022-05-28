using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace Entity_Framework_practice
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }  
        public DbSet<Post> Posts { get; set; }
        public string DbPath { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BQ1O4AU;Initial Catalog=LMS_Project2;Integrated Security=True");
        }
    }

    public class Post
    {
        public int PostId {  get; set; }  
        public string Title { get; set; } 
        public string COntent { get; set; }
        public int BlogId {  get;set; }
        public Blog Blog {  get; set; }

    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; } 
        public List<Post> Posts { get; set; } 
    }
}

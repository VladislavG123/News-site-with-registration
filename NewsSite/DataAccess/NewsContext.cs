using NewsSite.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace NewsSite.DataAccess
{
    
    public class NewsContext : DbContext
    {
        public NewsContext()
            : base("name=NewsContext")
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
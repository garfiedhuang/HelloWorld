using System;
using System.Data.Entity;
using GLD.GBES.Models;

namespace GLD.GBES.DAL
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext()
            : base("MyDbContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

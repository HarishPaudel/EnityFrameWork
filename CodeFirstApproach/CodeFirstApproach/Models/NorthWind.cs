using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace CodeFirstApproach.Models
{
    public class NorthWind : DbContext
    {
        public NorthWind():base("name=northwindconnection")
        {
                
        }

        public DbSet<Category> categorytables { get; set; }
        public DbSet<Products> productstables { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YdGorev.Models.EF
{
    public class YdGorevDbContext : DbContext
    {
        public YdGorevDbContext() : base("name = YdGorevDbContext")
        {
        }

        // setting EF convention
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // use singular table name
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<BasvuranPersoneller> BasvuranPersonellers { get; set; }
    }
}

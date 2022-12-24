using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace BitirmeProjesi.Models.AllClass
{
    public class Context: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Beslenme> Beslenmes { get; set; }
        public DbSet<Destek> Desteks { get; set; }
        public DbSet<Spor> Spors { get; set; }
        public DbSet<YemekServisi> YemekServisis { get; set; }

    }
}
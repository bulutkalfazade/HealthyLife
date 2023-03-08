using DataAccess.Concrete;
using Entities.Concrete;
using FireSharp.Config;
using FireSharp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DataAccess.Concrete.EntitityFramework
{
    public class HealthyLifeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB ;
                                        Database=HealthyLife; 
                                        Trusted_Connection=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Person { get; set; }



    }
}

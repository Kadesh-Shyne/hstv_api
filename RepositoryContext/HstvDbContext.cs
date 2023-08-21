using HSTV_Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HSTV_Api.Data
{
    public class HstvDbContext : DbContext
    {
        public HstvDbContext(DbContextOptions options) : base(options) { }

     

        public DbSet<Subscribers> Subscribers { get; set; }
        public DbSet<Country> Countries { get; set; }  
        public DbSet<Amount> Amounts { get; set; }
        

    }
}


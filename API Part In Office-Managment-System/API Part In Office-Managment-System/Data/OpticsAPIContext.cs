using Microsoft.EntityFrameworkCore;
using System;

namespace API_Part_In_Office_Managment_System.Data
{
    public class OpticsAPIContext : DbContext
    {
        public OpticsAPIContext(DbContextOptions<OpticsAPIContext> options) : base(options) { }

        public DbSet<Reports> Reports { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<DestroyedOptic> DestroyedOptics { get; set; }
        public DbSet<Bill> Bills { get; set; }


    }
}

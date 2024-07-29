using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    public class OpticsOfficeContext : DbContext
    {
        public OpticsOfficeContext() : base("Data source=DESKTOP-AR1U854;Initial catalog=OpticsOffice;Integrated security= true ; TrustServerCertificate=True;") 
        { }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillIteam> BillsIteam { get; set;}
        public DbSet<Borrowers> Borrowers { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<CustomerPayments> CustomerPayments { get; set; }
        public DbSet<Optics> Optics { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<SuppliersPayment> SuppliersPayment { get; set; }
        public DbSet<Workers> Workers { get; set; }

        public DbSet<DestroyedOptics> DestroyedOptics { get; set; }

        public DbSet<GlassesType> GlassesTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Optics>()
            //    .HasMany(o => o.Workers)
            //    .WithMany(w => w.Optics)
            //    .Map(m =>
            //    {
            //        m.ToTable("DestroyedOptics");
            //        m.MapLeftKey("Optics_Code");
            //        m.MapRightKey("Workers_Id");
            //    });

            modelBuilder.Entity<DestroyedOptics>()
                .HasRequired(d => d.Workers)
                .WithMany(w => w.DestroyedOptics)
                .HasForeignKey(d => d.Workers_Id);

            modelBuilder.Entity<DestroyedOptics>()
                .HasRequired(d => d.Optics)
                .WithMany(o => o.DestroyedOptics)
                .HasForeignKey(d => d.Optics_Id);
                //.WillCascadeOnDelete(true); //Cascade will delete The Optics when deleted fromthe database

            base.OnModelCreating(modelBuilder);
        }
    }
}

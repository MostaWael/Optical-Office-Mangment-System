using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optical_Office_Mangment_System.Models
{
    internal class OpticsOfficeContext : DbContext
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
    }
}

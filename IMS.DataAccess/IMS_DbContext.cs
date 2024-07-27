using IMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess
{
    public class IMS_DbContext : DbContext
    {
        public DbSet<Item> items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=MSI\\SQLEXPRESS;Database=IMS_DB;Trusted_connection=true;TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

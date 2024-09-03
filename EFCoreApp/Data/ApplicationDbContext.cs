using System;
using EFCoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> personContext { get; set; }
        public DbSet<Corporate> corporateContext { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MARVIN\SQLEXPRESS01;Initial Catalog=WinApp;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}

using ArqProy.Models.Clients;
using Microsoft.EntityFrameworkCore;
using System;

namespace ArqProy.Repositories
{
    public class ArqProyDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=AR1258832W1\SQLSERVER2019;Initial Catalog=MomentoDB;Integrated Security=True");
        }
    }
}

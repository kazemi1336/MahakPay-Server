using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MahakPay.Data.Models;

namespace MahakPay.Data.DatabaseContext
{
    class MahakDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=MAHAK\SQLINST01;Initial Catalog=MahakPaydb;Integrated Security=True;MultipleActiveResultSets=True;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<BankCard> BankCards { get; set; }
    }
}

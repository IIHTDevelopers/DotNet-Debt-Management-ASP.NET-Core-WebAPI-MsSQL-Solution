using DebtManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DebtManagement.DataLayer
{
    public class DebtDbContext : DbContext
    {
        public DebtDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Debt> Debts { get; set; }
    }

}
using Core.Entities.Concreate;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.EntityFramewok.Context
{
    public class ContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //gerekli sql bağlantısını yapan kod
            optionsBuilder.UseSqlServer(@"Server=ELIF;Database=eReconciliationDb;Integrated Security=true");
        }

        public DbSet<AccountReconciliationDetails> accountReconciliationDetails { get; set; }
        public DbSet<AccountReconciliations> AccountReconciliations { get; set; }
        public DbSet<BaBsReconciliationDetails> BaBsReconciliationDetails { get; set; }
        public DbSet<BaBsReconciliations> BaBsReconciliations { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Currency> Currencies { get; set }
        public DbSet<CurrencyAccount> CurrencyAccounts { get; set; }
        public DbSet<MailParameter> MailParameters { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCompany> UserCompanies { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; } 

    }
}

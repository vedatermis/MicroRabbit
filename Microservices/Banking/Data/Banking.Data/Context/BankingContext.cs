using Banking.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Banking.Data.Context
{
    public class BankingContext: DbContext
    {
        public BankingContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
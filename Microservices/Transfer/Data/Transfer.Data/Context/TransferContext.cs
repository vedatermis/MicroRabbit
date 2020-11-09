using Microsoft.EntityFrameworkCore;
using Transfer.Domain.Model;

namespace Transfer.Data.Context
{
    public class TransferContext: DbContext
    {
        public TransferContext(DbContextOptions options): base(options) { }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}

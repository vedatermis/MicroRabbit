using System.Collections.Generic;
using Transfer.Domain.Model;

namespace Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
using System.Collections.Generic;
using Transfer.Domain.Model;

namespace Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
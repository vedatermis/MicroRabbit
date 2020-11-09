using System.Collections.Generic;
using Transfer.Data.Context;
using Transfer.Domain.Interfaces;
using Transfer.Domain.Model;

namespace Transfer.Data.Repository
{
    public class TransferRepository: ITransferRepository
    {
        private readonly TransferContext _transferContext;

        public TransferRepository(TransferContext transferContext)
        {
            _transferContext = transferContext;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferContext.TransferLogs;
        }
    }
}
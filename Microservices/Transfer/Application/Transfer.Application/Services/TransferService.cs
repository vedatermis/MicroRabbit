﻿using System.Collections.Generic;
using RabbitMq.Core.Bus;
using Transfer.Application.Interfaces;
using Transfer.Domain.Interfaces;
using Transfer.Domain.Model;

namespace Transfer.Application.Services
{
    public class TransferService: ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _eventBus;

        public TransferService(ITransferRepository transferRepository, IEventBus eventBus)
        {
            _transferRepository = transferRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
﻿using System.Collections.Generic;
using Banking.Application.Interfaces;
using Banking.Application.Models;
using Banking.Domain.Commands;
using Banking.Domain.Interfaces;
using Banking.Domain.Model;
using RabbitMq.Core.Bus;

namespace Banking.Application.Services
{
    public class AccountService: IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccount()
        {
            return _accountRepository.GetAccounts();
        }

        public void TransferFunds(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(accountTransfer.FromAccount, accountTransfer.ToAccount, accountTransfer.TransferAmount);
            _eventBus.SendCommand(createTransferCommand);
        }
    }
}
using System.Collections.Generic;
using Banking.Application.Models;
using Banking.Domain.Model;

namespace Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccount();
        void TransferFunds(AccountTransfer accountTransfer);
    }
}
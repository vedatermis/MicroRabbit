using System.Collections;
using System.Collections.Generic;
using Banking.Domain.Model;

namespace Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
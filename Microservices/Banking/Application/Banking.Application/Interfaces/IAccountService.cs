using System.Collections.Generic;
using Banking.Domain.Model;

namespace Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccount();
    }
}
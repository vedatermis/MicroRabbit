using System.Collections.Generic;
using Banking.Data.Context;
using Banking.Domain.Interfaces;
using Banking.Domain.Model;

namespace Banking.Data.Repository
{
    public class AccountRepository: IAccountRepository
    {
        private readonly BankingContext _bankingContext;

        public AccountRepository(BankingContext bankingContext)
        {
            _bankingContext = bankingContext;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _bankingContext.Accounts;
        }
    }
}
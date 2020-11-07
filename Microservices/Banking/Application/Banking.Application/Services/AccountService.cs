using System.Collections.Generic;
using Banking.Application.Interfaces;
using Banking.Domain.Interfaces;
using Banking.Domain.Model;

namespace Banking.Application.Services
{
    public class AccountService: IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccount()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
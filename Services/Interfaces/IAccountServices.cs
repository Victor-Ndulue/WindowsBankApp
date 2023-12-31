﻿using Models;

namespace Services.Interfaces
{
    public interface IAccountServices
    {
        Task<string> CreateAccount(string firstName, string lastName, byte phoneNumber, AccountType accountType, double initialDeposit, string emailAddress);
    }
}

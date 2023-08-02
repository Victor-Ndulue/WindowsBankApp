using Models;
using Repositories.UnitOfWork.Implementation;
using Utilities;

namespace Services.Implementations
{
    internal sealed class AccountServices
    {
        private readonly UnitOfWork _unitOfWork;

        public AccountServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> CreateAccount(string firstName, string lastName, byte phoneNumber,AccountType accountType ,decimal initialDeposit, string emailAddress) 
        {
            User user = await _unitOfWork.userRepository.GetUserAsync(emailAddress);
            firstName = Utility.RemoveDigitFromStart(firstName);
            firstName = Utility.FirstCharacterToUpper(firstName);
            if (firstName.IsNullOrEmpty()) { return "invalid naming format"; }
            lastName = Utility.RemoveDigitFromStart(lastName);
            lastName = Utility.FirstCharacterToUpper(lastName);
            string accountNumber = Utility.GenerateAccountNumber();
            if (lastName.IsNullOrEmpty()) { return "invalid naming format"; }
            if (initialDeposit>=0)
            {
                Account account = new Account
                {
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phoneNumber,
                    AccountType = accountType,
                    AccountBalance = initialDeposit,
                    AccountNumber = accountNumber,
                    UserId = user.Id
                };
                return $" Account successfully created for {account.FirstName}  {account.LastName}.\n" +
                    $" Attached is your account number {account.AccountNumber}";
            }
            return "Intial deposit must not be less than 0.00";
        }
    }
}

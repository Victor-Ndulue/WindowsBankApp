using Models;
using Repositories.UnitOfWork.Interface;
using Services.Interfaces;
using Utilities;

namespace Services.Implementations
{
    internal sealed class UserService:IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> CreateUserAccount(string username, string password, string email)
        {
            string userName = Utility.RemoveDigitFromStart(username);
            if (Utility.IsEmailValid(email))
            {
                var User = _unitOfWork.userRepository.GetUserAsync(email);
                if (User != null)
                {
                    var saltAndHash = Utility.GenerateHash(password);
                    var user = new User
                    {
                        UserName = userName,
                        EmailAddress = email,
                        PasswordHash = saltAndHash[0],
                        PasswordSalt = saltAndHash[1]
                    };
                    await _unitOfWork.userRepository.CreateAsync(user);
                    await _unitOfWork.SaveAsync();
                    _unitOfWork.Dispose();
                    return $"Account successfuly created for {user.UserName}";
                }
                else { return "Account already existing"; }
            } else { return "Mail passed not valid. Account creation unsuccessful."; }
        }
        public async Task<bool> LoginAsync(string email, string password)
        {
            var user = await _unitOfWork.userRepository.GetUserAsync(email);
            var PasswordHash = user.PasswordHash;
            var PasswordSalt = user.PasswordSalt;
            bool result = Utility.CompareHash(PasswordSalt, PasswordHash, password);
            if (result)  return true; 
            return false;
        }

        public async Task<string> UpdateUser(string oldEmail, string oldPassword, string username, string password, string email) 
        {
            var user = await _unitOfWork.userRepository.GetUserAsync(oldEmail);
            var PasswordHash = user.PasswordHash;
            var PasswordSalt = user.PasswordSalt;
            bool result = Utility.CompareHash(PasswordSalt, PasswordHash, oldPassword);
            if (result)
            {
                string userName;
                byte[] passwordHash;
                byte[] passwordSalt;
                userName = Utility.RemoveDigitFromStart(username);
                if (userName==null) return "empty or invalid unername";
                user.UserName = userName;
                bool checkMail = Utility.IsEmailValid(email);
                if (!checkMail) return "mail invalid";
                user.EmailAddress = email;
                if (password == null) return "Password field cannot be empty";
                var hashAndSalt = Utility.GenerateHash(password);
                passwordHash = hashAndSalt[0];
                passwordSalt = hashAndSalt[1];
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                _unitOfWork.userRepository.Update(user);
                await _unitOfWork.SaveAsync();
                _unitOfWork.Dispose();
                return $"User successfully updated";
            }
            return "User not created. Wrong old email or password entered. Check and try again";
        }
    }
}

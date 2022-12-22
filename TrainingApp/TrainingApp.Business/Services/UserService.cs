using TrainingApp.Business.Contracts;
using TrainingApp.Business.Models;
using TrainingApp.Data.Contracts;
using TrainingApp.Domain.Entities;

namespace TrainingApp.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task InsertUser(UserModel model)
        {
            var user = new User
            {
                Name = model.Name
            };
            await _userRepository.InsertAsync(user);
        }
    }
}

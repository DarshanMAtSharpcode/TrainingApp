using TrainingApp.Business.Models;

namespace TrainingApp.Business.Contracts
{
    public interface IUserService
    {
        Task InsertUser(UserModel model);
    }
}

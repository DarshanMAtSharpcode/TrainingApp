using TrainingApp.Data.Contracts;
using TrainingApp.Domain.Entities;
using TrainingApp.EF;

namespace TrainingApp.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(TrainingAppEFContext context) : base(context)
        {
        }
    }
}

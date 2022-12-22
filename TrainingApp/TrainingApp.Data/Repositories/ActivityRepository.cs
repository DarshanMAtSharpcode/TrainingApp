using TrainingApp.Data.Contracts;
using TrainingApp.Domain.Entities;
using TrainingApp.EF;

namespace TrainingApp.Data.Repositories
{
    public class ActivityRepository : Repository<Activity>, IActivityRepository
    {
        public ActivityRepository(TrainingAppEFContext context) : base(context)
        {
        }
    }
}

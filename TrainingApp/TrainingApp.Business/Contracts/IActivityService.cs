using TrainingApp.Business.Models;

namespace TrainingApp.Business.Contracts
{
    public interface IActivityService
    {
        Task InsertActivityAsync(ActivityBaseModel model);
        Task<IList<ActivityModel>> GetActivitiesAsync();
    }
}

using TrainingApp.Business.Contracts;
using TrainingApp.Business.Models;
using TrainingApp.Data.Contracts;
using TrainingApp.Domain.Entities;

namespace TrainingApp.Business.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public async Task<IList<ActivityModel>> GetActivitiesAsync()
        {
            var activities = await _activityRepository.GetAsync();
            return activities.Select(activity => new ActivityModel
            {
                Id = activity.Id,
                Title = activity.Title,
                Description = activity.Description,
                Status = activity.Status,
                DueDateTime = activity.DueDateTime
            }).ToList();
        }

        public async Task InsertActivityAsync(ActivityBaseModel model)
        {
            var activity = new Activity
            {
                Title = model.Title,
                Description = model.Description,
                Status = model.Status,
                DueDateTime = model.DueDateTime,
                UserId = 1
            };
            await _activityRepository.InsertAsync(activity);
        }
    }
}

using TrainingApp.Domain.Enums;

namespace TrainingApp.Business.Models
{
    public class ActivityBaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDateTime { get; set; }
        public ActivityStatus Status { get; set; }
    }
}

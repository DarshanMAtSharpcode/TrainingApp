using TrainingApp.Domain.Enums;

namespace TrainingApp.Domain.Entities
{
    public class ActivityHistory : BaseEntity
    {
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public ActivityStatus ActivityStatus { get; set; }
    }
}

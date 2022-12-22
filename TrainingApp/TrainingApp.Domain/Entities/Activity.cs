﻿namespace TrainingApp.Domain.Entities
{
    public class Activity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDateTime { get; set; }
        public TaskStatus MyProperty { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

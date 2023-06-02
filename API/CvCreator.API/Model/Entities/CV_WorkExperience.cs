﻿namespace CvCreator.Model.Entities
{
    public class CV_WorkExperience : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public bool IsContinuing { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Projects { get; set; }
        public string ProjectsDetails { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string Description { get; set; }
        public string ProgrammingLanguages { get; set; }

        public Guid PersonId { get; set; }
        public virtual CV_Person Person { get; set; }
    }
}

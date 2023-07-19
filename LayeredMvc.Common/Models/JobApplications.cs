using System.Collections.Generic;

namespace LayeredMvc.Common.Models
{
    public class JobApplications
    {
        public Job Job { get; }
        public List<Application> Applications { get; }

        public JobApplications(Job job, List<Application> applications)
        {
            Job = job;
            Applications = applications;
        }
    }
}

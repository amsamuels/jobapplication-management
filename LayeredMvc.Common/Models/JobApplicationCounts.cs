namespace LayeredMvc.Common.Models
{
    public class JobApplicationCount
    {
        public Job Job { get; }
        public int ApplicationCount { get; }

        public JobApplicationCount(Job job, int applicationCount)
        {
            Job = job;
            ApplicationCount = applicationCount;
        }
    }
}

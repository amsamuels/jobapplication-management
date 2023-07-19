using LayeredMvc.Common.Models;
using System.Collections.Generic;

namespace LayeredMvc.Common
{
    public interface IJobLogic
    {
        List<Job> GetAll();
        List<JobApplicationCount> GetAllJobApplicationCounts();
        
        Job GetById(int jobId);
    }
}

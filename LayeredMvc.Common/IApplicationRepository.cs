using System.Collections.Generic;

namespace LayeredMvc.Common
{
    public interface IApplicationRepository
    {
        Application GetById(int applicationId);
        List<Application> GetByJobId(int jobId);
    }
}

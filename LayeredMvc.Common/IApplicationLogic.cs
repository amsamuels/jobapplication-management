using System.Collections.Generic;

namespace LayeredMvc.Common
{
    public interface IApplicationLogic
    {
        Application GetById(int applicationId);
        List<Application> GetByJobId(int jobId);
    }
}

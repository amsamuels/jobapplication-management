using LayeredMvc.Common;
using LayeredMvc.Data;
using System.Collections.Generic;

namespace LayeredMvc.Logic
{
    public class ApplicationLogic : IApplicationLogic
    {
        private IApplicationRepository applicationRepository = new JsonApplicationRepository();
        
        public Application GetById(int applicationId)
        {
            return applicationRepository.GetById(applicationId);
        }

        public List<Application> GetByJobId(int jobId)
        {
            return applicationRepository.GetByJobId(jobId);
        }
    }
}

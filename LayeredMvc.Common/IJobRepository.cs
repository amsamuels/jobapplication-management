using System.Collections.Generic;

namespace LayeredMvc.Common
{
    public interface IJobRepository
    {
        List<Job> GetAll();
        Job GetById(int jobId);
    }
}

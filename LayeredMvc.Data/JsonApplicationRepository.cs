using System.Collections.Generic;
using System.Linq;
using LayeredMvc.Common;
using Newtonsoft.Json;

namespace LayeredMvc.Data
{
    public class JsonApplicationRepository : IApplicationRepository
    {
        private readonly List<Application> applications;

        public JsonApplicationRepository()
        {
            applications = JsonConvert.DeserializeObject<List<Application>>(System.IO.File.ReadAllText(@"./applications.json"));
        }

        public Application GetById(int applicationId)
        {
            return applications.First(x => x.Id == applicationId);
        }

        public List<Application> GetByJobId(int jobId)
        {
            return applications.Where(x => x.JobId == jobId).ToList();
        }
    }
}

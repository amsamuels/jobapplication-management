using LayeredMvc.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LayeredMvc.Data
{
    public class MockJobRepository : IJobRepository
    {
        private List<Job> jobs = new List<Job>()
        {
            new Job(1000, "Junior Developer", "Junior development role, degree required but no experience.", "Manchester", 24000),
            new Job(1001, "Senior Developer", "Senior developer full-stack developer required, experience leading projects required.", "Manchester", 30000),
            new Job(1002, "Project Manager", "Experienced project manager required.", "Stockport", 40000),
            new Job(1003, "Software Tester", "Junior tester required to test mobile apps.", "Salford", 24000)
        };
        
        // Returns all the jobs in the database
        public List<Job> GetAll()
        {
            return jobs;
        }

        // Returns the job with the given Id
        public Job GetById(int jobId)
        {
            return jobs.Find(x => x.Id == jobId);
        }
    }
}

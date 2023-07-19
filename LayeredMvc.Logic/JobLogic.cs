using System;
using System.Collections.Generic;
using LayeredMvc.Common;
using LayeredMvc.Common.Models;
using LayeredMvc.Data;

namespace LayeredMvc.Logic
{
    public class JobLogic : IJobLogic
    {
        IJobRepository JobRepository = new JsonJobRepository();
        IApplicationRepository applicationRepository = new JsonApplicationRepository();

        public List<Job> GetAll()
        {
            return JobRepository.GetAll();
        }

        public Job GetById(int jobId)
        {
            return JobRepository.GetById(jobId);
        }

        public List<JobApplicationCount> GetAllJobApplicationCounts()
        {
            List<JobApplicationCount> applicationCounts = new List<JobApplicationCount>();

            foreach (Job j in JobRepository.GetAll())
            {
                if(applicationCounts.Find(x=>x.Job.Id==j.Id)==null)
                    applicationCounts.Add(new JobApplicationCount(j, applicationRepository.GetByJobId(j.Id).Count));
            }

            return applicationCounts;
        }

    }
}

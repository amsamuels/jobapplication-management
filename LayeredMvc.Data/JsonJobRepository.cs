using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LayeredMvc.Common;
using Newtonsoft.Json;

namespace LayeredMvc.Data
{
    public class JsonJobRepository : IJobRepository
    {
        private List<Job> jobs = new List<Job>();

        public JsonJobRepository()
        {
            jobs = JsonConvert.DeserializeObject<List<Job>>(System.IO.File.ReadAllText(@"./jobs.json"));
        }

        public List<Job> GetAll()
        {
            return jobs;
        }

        public Job GetById(int jobId)
        {
            return jobs.Find(x => x.Id==jobId);
        }
    }
}

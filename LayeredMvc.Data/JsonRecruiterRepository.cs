using LayeredMvc.Common;
using LayeredMvc.Common.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace LayeredMvc.Data
{
    public class JsonRecruiterRepository : IRecruiterRepository
    {
        private List<Recruiter> recruiters = new List<Recruiter>();

        public JsonRecruiterRepository()
        {
            recruiters =  JsonConvert.DeserializeObject<List<Recruiter>>(System.IO.File.ReadAllText(@"Data\recruiters.json"));

        }

        public List<Recruiter> GetAll()
        {
            return recruiters;
        }

        public Recruiter GetById(int recruiterId)
        {
            return recruiters.First(x => x.Id == recruiterId);
        }
    }
}

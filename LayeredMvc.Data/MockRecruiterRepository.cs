using System.Collections.Generic;
using System.Linq;
using LayeredMvc.Common;
using LayeredMvc.Common.Models;

namespace LayeredMvc.Data
{
    public class MockRecruiterRepository : IRecruiterRepository
    {
        private List<Recruiter> recruiters = new List<Recruiter>()
        {
            new Recruiter(3001, "Jobs R Us", "123 Oxford Road", "0161 7157364", true),
            new Recruiter(3002, "Recruitment Specialists", "12 Stockport Street", "0161 7151123", false),
            new Recruiter(3003, "Manchester Jobs", "22 High Street", "0161 7159849", true)
        };

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

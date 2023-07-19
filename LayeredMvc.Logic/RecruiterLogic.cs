using LayeredMvc.Common;
using LayeredMvc.Common.Models;
using LayeredMvc.Data;
using System.Collections.Generic;

namespace LayeredMvc.Logic
{
    public class RecruiterLogic : IRecruiterLogic
    {
        private IRecruiterRepository recruiterRepository = new JsonRecruiterRepository();

        public List<Recruiter> GetAll()
        {
            return recruiterRepository.GetAll();
        }

        public Recruiter GetById(int recruiterId)
        {
            return recruiterRepository.GetById(recruiterId);
        }
    }
}

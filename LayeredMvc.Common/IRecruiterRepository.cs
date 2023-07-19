using LayeredMvc.Common.Models;
using System.Collections.Generic;

namespace LayeredMvc.Common
{
    public interface IRecruiterRepository
    {
        List<Recruiter> GetAll();
        Recruiter GetById(int recruiterId);
    }
}

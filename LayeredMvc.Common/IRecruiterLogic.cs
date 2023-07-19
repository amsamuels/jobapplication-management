using LayeredMvc.Common.Models;
using System.Collections.Generic;

namespace LayeredMvc.Common
{
    public interface IRecruiterLogic
    {
        List<Recruiter> GetAll();
        Recruiter GetById(int recruiterId);
    }
}

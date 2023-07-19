using LayeredMvc.Common;
using System.Collections.Generic;

namespace LayeredMvc.Presentation.Models
{
    public class JobApplicationsViewModel
    {
        public Job Job { get; set; }
        public List<Application> Applications { get; set; }
    }
}

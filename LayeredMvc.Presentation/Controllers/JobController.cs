using LayeredMvc.Common;
using LayeredMvc.Logic;
using LayeredMvc.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace LayeredMvc.Presentation.Controllers
{
    public class JobController : Controller
    {
        private IJobLogic logic = new JobLogic();
        private IApplicationLogic applicationLogic = new ApplicationLogic();

        public IActionResult Index()
        {
            JobsViewModel model = new JobsViewModel();
            model.Jobs = logic.GetAll();

            foreach (Job j in model.Jobs)
            {
                j.Applications = applicationLogic.GetByJobId(j.Id).Count;
            }

            return View("Jobs", model);
        }

        public IActionResult Job(int id)
        {
            JobViewModel model = new JobViewModel();

            model.Job = logic.GetById(id);
            model.Job.Applications = applicationLogic.GetByJobId(id).Count;

            return View("Job", model);
        }
    }
}
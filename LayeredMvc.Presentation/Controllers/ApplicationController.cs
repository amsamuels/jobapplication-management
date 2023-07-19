using LayeredMvc.Common;
using LayeredMvc.Logic;
using LayeredMvc.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace LayeredMvc.Presentation.Controllers
{
    public class ApplicationController : Controller
    {
        private IApplicationLogic applicationLogic = new ApplicationLogic();
        private IJobLogic jobLogic = new JobLogic();

        public IActionResult Index()
        {
            ApplicationsViewModel model = new ApplicationsViewModel();
            model.ApplicationCounts = jobLogic.GetAllJobApplicationCounts();
            return View("Applications", model);
        }

        public IActionResult Application(int id)
        {
            ApplicationViewModel model = new ApplicationViewModel();
            model.Application = applicationLogic.GetById(id);
            model.Job = jobLogic.GetById(model.Application.JobId);
            return View("Application", model);
        }

        public IActionResult JobApplications(int id)
        {
            JobApplicationsViewModel model = new JobApplicationsViewModel();
            model.Job = jobLogic.GetById(id);
            model.Applications = applicationLogic.GetByJobId(id);
            return View("JobApplications", model);
        }
    }
}

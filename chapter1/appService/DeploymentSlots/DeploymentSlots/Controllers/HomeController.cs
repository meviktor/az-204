using DeploymentSlots.Models;
using DeploymentSlots.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DeploymentSlots.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ApplicationDbContext context)
        {
            _applicationDbContext = context;
        }

        public IActionResult Index()
        {
            var model = new UserViewModel();
            try
            {
                model.Users = _applicationDbContext.Users.ToList();
            }
            catch(Exception e)
            {
                model.ExceptionName = e.GetType().Name;
            }
            return View(model);
        }
    }
}
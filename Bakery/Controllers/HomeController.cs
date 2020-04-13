using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;
using Bakery.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICakesRepository _cakesRepository;

        public HomeController(ICakesRepository cakesRepository)
        {
            _cakesRepository = cakesRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CakesOfTheWeek = _cakesRepository.CakesOfTheWeek
            };
            return View(homeViewModel);
        
        }
    }
}

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
    public class CakesController : Controller
    {
        private readonly ICakesRepository _cakesRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CakesController(ICakesRepository cakeRepository, ICategoryRepository categoryRepository)
        {
            _cakesRepository = cakeRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {

            ViewModels.CakesListViewModel cakesListViewModel = new CakesListViewModel();
            cakesListViewModel.Cakes = _cakesRepository.AllCakes;

            cakesListViewModel.CurrentCategory = "Cheese Cakes";
            return View(cakesListViewModel);
        }
    }
}

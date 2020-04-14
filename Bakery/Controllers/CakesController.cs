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

        /*public IActionResult List()
        {

            ViewModels.CakesListViewModel cakesListViewModel = new CakesListViewModel();
            cakesListViewModel.Cakes = _cakesRepository.AllCakes;

            cakesListViewModel.CurrentCategory = "Cheese Cakes";
            return View(cakesListViewModel);
        }*/

        public ViewResult List(string category)
        {
            IEnumerable<Cakes> cakes;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                cakes = _cakesRepository.AllCakes.OrderBy(p => p.CakesId);
                currentCategory = "All pies";
            }
            else
            {
                cakes = _cakesRepository.AllCakes.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.CakesId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CakesListViewModel
            {
                Cakes = cakes,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var cake = _cakesRepository.GetCakesById(id);

            if (cake == null)
                return NotFound();

            return View(cake);
                    
        }
    }
}

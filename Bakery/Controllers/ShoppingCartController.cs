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
    public class ShoppingCartController : Controller
    {
        private readonly ICakesRepository _cakesRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICakesRepository cakesRepository, ShoppingCart shoppingCart)
        {
            _cakesRepository = cakesRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int cakesId)
        {
            var selectedCake = _cakesRepository.AllCakes.FirstOrDefault(p => p.CakesId == cakesId);

            if (selectedCake != null)
            {
                _shoppingCart.AddToCart(selectedCake, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int cakesId)
        {
            var selectedCake = _cakesRepository.AllCakes.FirstOrDefault(p => p.CakesId == cakesId);

            if (selectedCake != null)
            {
                _shoppingCart.RemoveFromCart(selectedCake);
            }
            return RedirectToAction("Index");
        }
    }
}

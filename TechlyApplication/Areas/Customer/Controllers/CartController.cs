using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Techly.BLL.Interfaces;
using Techly.DAL.Models;
using Techly.DAL.ViewModels;

namespace Techly.Presentation.Areas.Customer.Controllers
{
    [Area("customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShoppingCartVm ShoppingCartVm { get; set; }

        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            ShoppingCartVm = new()
            {
                ShoppingCartList = _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId, includeProperties: "Product")
            };
            foreach (var cart in ShoppingCartVm.ShoppingCartList)
            {
                cart.Price = GetPriceBasedOnQuantity(cart);
                ShoppingCartVm.OrderTotal += (cart.Price * cart.Count);
            }

            return View(ShoppingCartVm);
        }
        public IActionResult Summary()
        {
            return View();
        }
        public IActionResult Plus(int cartId)
        {
            var carFromDb = _unitOfWork.ShoppingCart.Get(u => u.Id == cartId);
            carFromDb.Count += 1;
            _unitOfWork.ShoppingCart.Update(carFromDb);
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Minus(int cartId)
        {
            var carFromDb = _unitOfWork.ShoppingCart.Get(u => u.Id == cartId);
            if (carFromDb.Count <= 1)
            {
                _unitOfWork.ShoppingCart.Delete(carFromDb);
            }
            else
            {
                carFromDb.Count -= 1;
                _unitOfWork.ShoppingCart.Update(carFromDb);
            }
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Remove(int cartId)
        {
            var carFromDb = _unitOfWork.ShoppingCart.Get(u => u.Id == cartId);
            _unitOfWork.ShoppingCart.Delete(carFromDb);
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }

        private double GetPriceBasedOnQuantity(ShoppingCart shoppingCart)
        {
            if (shoppingCart.Count <= 50)
            {
                return shoppingCart.Product.Price;
            }
            else
            {
                if (shoppingCart.Count <= 100)
                {
                    return shoppingCart.Product.Price50;
                }
                else
                {
                    return shoppingCart.Product.Price100;
                }
            }
        }
    }
}

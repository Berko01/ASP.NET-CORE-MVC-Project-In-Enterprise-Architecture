using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUITest.Helpers;

namespace MvcWebUITest.Controllers
{
	public class CartController:Controller
	{
		private ICartService _cartService;
		private ICartSessionHelper _cartSessionHelper;
		private IProductService _productService;

		public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
		{
			_cartService = cartService;
			this._cartSessionHelper = cartSessionHelper;
			_productService = productService;
		}

		public IActionResult AddToCart(int productId)
		{
			//ürünü çek
			Product product = _productService.GetById(productId);
			var cart = _cartSessionHelper.GetCart("cart");
			_cartService.AddToCart(cart, product);
			_cartSessionHelper.SetCart("cart",cart);

			return RedirectToAction("Index", "Product");
		}

		public IActionResult RemoveFromCart(int productId)
		{
			Product product = _productService.GetById(productId);
			var cart = _cartSessionHelper.GetCart("cart");
			_cartService.RemoveFromCart(cart, productId);
			_cartSessionHelper.SetCart("cart", cart);

			return RedirectToAction("Index", "Product");
		}
	}
}

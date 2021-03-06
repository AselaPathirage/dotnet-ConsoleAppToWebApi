using ConsoleApptoAPI.Models;
using ConsoleApptoAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApptoAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductRepository _productRepository;

		public ProductController(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		[HttpPost("")]
		public IActionResult AddProduct([FromBody] ProductModel product)
		{
			_productRepository.AddProduct(product);
			var products = _productRepository.GetAllProducts();
			return Ok(products);
		}
	}
}
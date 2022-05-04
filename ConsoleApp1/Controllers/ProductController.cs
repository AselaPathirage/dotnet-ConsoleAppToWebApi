using ConsoleApptoAPI.Models;
using ConsoleApptoAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApptoAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly ProductRepository productRepository;

		public ProductController()
		{
			productRepository = new ProductRepository();
		}

		[HttpPost("")]
		public IActionResult AddProduct([FromBody] ProductModel product)
		{
			productRepository.AddProduct(product);
			var products = productRepository.GetAllProducts();
			return Ok(products);
		}
	}
}
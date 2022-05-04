using ConsoleApptoAPI.Models;
using ConsoleApptoAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApptoAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		[Route("")]
		public EmployeeModel GetEmployees()
		{
			return new EmployeeModel() { Id = 1, Name = "emp1" };
		}

		[Route("{id}")]
		public IActionResult GetEmployeesById(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			return Ok(new List<EmployeeModel>(){
				new EmployeeModel() { Id = 1, Name = "emp1" },
				new EmployeeModel() { Id = 2, Name = "emp2" }
			});
		}

		[Route("{id}/basic")]
		public ActionResult<EmployeeModel> GetEmployeesByIdBasicInformation(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			return new EmployeeModel() { Id = 1, Name = "emp1" };
		}

		[Route("name")]
		public IActionResult GetName([FromServices]IProductRepository _productRepository)
		{
			var name = _productRepository.GetProductName();
			return Ok(name);
		}
	}
}
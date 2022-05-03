using ConsoleApptoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApptoAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	//[BindProperties]
	public class CountriesController : ControllerBase
	{
		//	[BindProperty]
		//	public string Name { get; set; }
		//	[BindProperty]
		//	public int Population { get; set; }
		//	[BindProperty]
		//	public int Area { get; set; }

		//[BindProperty]
		[BindProperty(SupportsGet =true)] //httpget
		public CountryModel Country { get; set; }

		[HttpPost("")]
		public IActionResult AddCountry()
		{
			return Ok($"Name={this.Country.Name},Population={this.Country.Population},Area={this.Country.Area}");
		}
	}
}
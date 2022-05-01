using Microsoft.AspNetCore.Mvc;

namespace ConsoleApptoAPI.Controllers
{
	[ApiController]
	[Route("test/[action]")]
	public class TestController : ControllerBase
	{
		public string Get()
		{
			return "Hello";
		}

		public string Get1()
		{
			return "Hello1";
		}
	}
}
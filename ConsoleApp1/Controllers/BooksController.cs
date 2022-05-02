using Microsoft.AspNetCore.Mvc;

namespace ConsoleApptoAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BooksController : ControllerBase
	{
		[Route("{id:int:min(10):max(20)}")]
		public string GetId(int id)
		{
			return "id int" + id;
		}

		[Route("{id:minlength(5):maxlength(20):alpha}")] // range(10,20) ,length(20))
		public string GetId(string id)
		{
			return "id string" + id;
		}

		[Route("{id:regex(a(b|c))}")]  
		public string GetIdByRegex(string id)
		{
			return "id regex" + id;
		}
	}
}
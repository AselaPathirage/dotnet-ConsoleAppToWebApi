using Microsoft.AspNetCore.Mvc;

namespace ConsoleApptoAPI.Controllers
{
	[Route("api/[controller]")]
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[Route("/get-all")]
		[Route("/getall")]
		[Route("getall")] //api/values/getall - this works even this line doesnt exits
		[Route("/[controller]/[action]")]
		public string GetAll()
		{
			return "Hello getall";
		}

		//[Route("/get-all-authors")]
		//[Route("/[action]/[controller]")]

		// api/values/getallauthors - works bcuz of no routes defined specifically to this method
		public string GetAllAuthors()
		{
			return "get all auhtors";
		}

		[Route("/get-all/{id}/author/{authorId}")]
		public string GetAllAuthorsById(int id, int authorId)
		{
			return "get id" + id + " author" + authorId;
		}

		// Query String in Routing
		[Route("/search")]
		public string GetAllBooks(int id, int authorId, string name, int rating, int price)
		{
			return "get from search";
		}
	}
}
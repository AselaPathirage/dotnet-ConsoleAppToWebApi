using Microsoft.AspNetCore.Mvc;

namespace ConsoleApptoAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[Route("/get-all")]
		public string GetAll()
		{
			return "Hello getall";
		}

		[Route("/get-all-authors")]
		public string GetAllAuthors()
		{
			return "get all auhtors";
		}

		[Route("/get-all/{id}/author/{authorId}")]
		public string GetAllAuthorsById(int id,int authorId)
		{
			return "get id"+id+" author"+authorId;
		}
	}
}
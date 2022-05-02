using ConsoleApptoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApptoAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AnimalsController : ControllerBase
	{
		private List<AnimalsModel> animals = null;

		public AnimalsController()
		{
			animals = new List<AnimalsModel>()
			{
				new AnimalsModel(){AnimalId=1,AnimalName="asdasd" },
				new AnimalsModel(){AnimalId=2,AnimalName="asdasassd" }
			};
		}

		[Route("", Name = "All")]
		public IActionResult GetAnimals()
		{
			return Ok(animals);
		}

		[Route("test")]
		public IActionResult GetAnimalsTest()
		{
			//return Accepted("~api/animals");
			//return AcceptedAtAction("GetAnimals");
			//return AcceptedAtRoute("All");

			return LocalRedirect("~/api/animals");
		}

		[Route("{name}")]
		public IActionResult GetAnimalsByName(string name)
		{
			if (!name.Contains("ABC"))
				return BadRequest();
			return Ok(animals);
		}

		[Route("{id:int}")]
		public IActionResult GetAnimalsById(int id)
		{
			if (id == 0)
				return BadRequest();
			//return Ok(animals.FirstOrDefault(x => x.AnimalId == id));
			
			var animal=animals.FirstOrDefault(x => x.AnimalId == id);
			if (animal==null)		
			{
				return NotFound();
			}
			return Ok(animal);
		}

		[HttpPost("")]
		public IActionResult GetAnimals(AnimalsModel animal)
		{
			animals.Add(animal);
			//return Created("~/api/animals", new { id = animal.AnimalId });
			//return Created("~/api/animals"+animal.AnimalId, animal);
			return CreatedAtAction("GetAnimalsById",new {id=animal.AnimalId }, animal);
		}
	}
}
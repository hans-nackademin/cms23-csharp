using _03_Records_WebApi.Models;
using _03_Records_WebApi.Records;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _03_Records_WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private static List<User> users = new List<User>();


		[HttpPost]
		public IActionResult Create(UserCreate record)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			// --> spara information till databasen
			users.Add(new User
			{
				Id = Guid.NewGuid(),
				FirstName = record.firstName,
				LastName = record.lastName,
				Email = record.email
			});
			return Ok();
		}

		[HttpGet]
		public IActionResult GetAll() 
		{
			return Ok(users);
		}
	}
}

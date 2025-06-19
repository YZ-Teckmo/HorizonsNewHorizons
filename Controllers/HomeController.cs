using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OriginsNewHorizons.Models;
using Database;
using System.Net;

namespace OriginsNewHorizons.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("getCharacter/{id:int}")]
    public Character GetCharacter(int id)
    {
        using (var context = new DatabaseContext())
        {
            return context.Characters.Where(x => x.Id == id).Select(x => x).Single();
        }
    }

    [HttpGet("getAllCharacters")]
    public List<Character> GetAllCharacters()
    {
        using (var context = new DatabaseContext())
        {
            return context.Characters.Where(x => x == x).Select(x => x).ToList();
        }
    }

    [HttpPost("createCharacter")]
    public IActionResult CreateCharacter([FromBody]Character character)
    {
        Console.WriteLine("Chegou!");
        Console.WriteLine(character.ToString());
        using (var context = new DatabaseContext())
        {
            context.Characters.Add(character);
            context.SaveChanges();
        }

        return Ok();
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OriginsNewHorizons.Models;
using Database;

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

    [HttpGet("getCharacter")]
    public Character GetCharacter()
    {
        using (var context = new DatabaseContext())
        {
            return context.Characters.Where(x => x.Id == 1).Select(x => x).Single();
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
}
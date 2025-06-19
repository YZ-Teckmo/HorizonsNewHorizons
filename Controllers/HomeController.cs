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

    [HttpGet("getPlayerSkill/{id:int}/{index:int}")]
    public PlayerHability GetPlayerSkill(int id, int index)
    {
        using (var context = new DatabaseContext())
        {
            var player = context.Characters.Where(x => x.Id == id).Single();
            var hablt = player.Habilities[index];
            var hability = context.PlayerHabilities.Where(x => x.Id == hablt).Single();
            return hability;
        }
    }

    [HttpGet("getAllPlayerSkills")]
    public List<PlayerHability> GetAllPlayerSkills(int id)
    {
        using (var context = new DatabaseContext())
        {
            return context.PlayerHabilities.Where(x => x == x).Select(x => x).ToList();
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OriginsNewHorizons.Models;
using Database;
using System.Net;
using OriginsNewHorizons.Components.CharacterPageComponents;
using System.Threading.Tasks;

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
    public IActionResult CreateCharacter([FromBody] Character character)
    {
        int id;
        using (var context = new DatabaseContext())
        {
            context.Characters.Add(character);
            context.SaveChanges();
            id = context.Characters.Select(x => x.Id).ToArray().Last();
        }
        return Ok();
    }

    [HttpGet("GetLastCharacter")]
    public int GetLastCharacter()
    {
        using (var context = new DatabaseContext())
        {
            return context.Characters.Select(x => x.Id).ToArray().Last();
        }
    }

    [HttpGet("GetHability/{id:int}")]
    public PlayerHability GetHability(int id)
    {
        using (var context = new DatabaseContext())
        {
            return context.PlayerHabilities.Where(x => x.Id == id).Select(x => x).Single();
        }
    }

    [HttpPost("EditCharacter")]
    public IActionResult EditCharacter([FromBody] Character character)
    {
        using (var context = new DatabaseContext())
        {
            Console.WriteLine(character.Strength);
            var p = context.Characters.Where(x => x.Id == character.Id).Single();
            p.Strength = character.Strength;
            p.Dexterity = character.Dexterity;
            p.Inteligency = character.Inteligency;
            p.EnergyModifier = character.EnergyModifier;
            p.Charisma = character.Charisma;
            p.Will = character.Will;
            p.Lucky = character.Lucky;
            p.Apperence = character.Apperence;
            p.Personality = character.Personality;
            p.Notes = character.Notes;
            p.Lore = character.Lore;
            p.Curiosity = character.Curiosity;
            p.Level = character.Level;
            p.PlayerColor = character.PlayerColor;
            p.TransformedColor = character.TransformedColor;
            p.CurrentVitality = character.CurrentVitality;
            p.Vitality = character.Vitality;
            p.CurrentVigor = character.CurrentVigor;
            p.Vigor = character.Vigor;
            p.CurrentEnergyStats = character.CurrentEnergyStats;
            p.EnergyStats = character.EnergyStats;
            p.CurrentSanity = character.CurrentSanity;
            p.Sanity = character.Sanity;
            p.CurrentHumanity = character.CurrentHumanity;
            p.Humanity = character.Humanity;
            p.Afinnity = character.Afinnity;
            context.SaveChanges();
        }
        return Ok();
    }

    [HttpPost("CreateHability")]
    public async Task<IActionResult> CreateHability([FromBody] CharacterAndHability characterAndHability)
    {
        using (var context = new DatabaseContext())
        {
            context.PlayerHabilities.Add(characterAndHability.Hability);
            context.SaveChanges();
            
            Character p = context.Characters.Where(x => x.Id == characterAndHability.Character.Id).Single();
            int habId = context.PlayerHabilities.Select(x => x.Id).ToArray().Last();
            if (p.Habilities == null)
            {
                p.Habilities = new();
            }
            p.Habilities.Add(habId);
            context.SaveChanges();

            return Ok();
        }
    }

    async Task SaveHability(DatabaseContext context, int id)
    {

    }

}
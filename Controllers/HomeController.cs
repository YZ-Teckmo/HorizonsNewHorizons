using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OriginsNewHorizons.Models;
using Database;

namespace OriginsNewHorizons.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("~/Views/Home/Login.cshtml");
    }

    public IActionResult CharacterList()
    {
        return View();
    }

    public IActionResult CharacterPage()
    {
        using (var context = new DatabaseContext())
        {
            var ViewPlayer = GetCharacterData(context);
            return View(ViewPlayer);
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public Character GetCharacterData(DatabaseContext context)
    {
        Character PlayerChar = new Character();

        PlayerChar.Strength = context.Characters.Where(x => x.Id == 1).Select(x => x.Strength).Single();
        PlayerChar.Dexterity = context.Characters.Where(x => x.Id == 1).Select(x => x.Dexterity).Single();
        PlayerChar.Inteligency = context.Characters.Where(x => x.Id == 1).Select(x => x.Inteligency).Single();
        PlayerChar.EnergyModifier = context.Characters.Where(x => x.Id == 1).Select(x => x.EnergyModifier).Single();
        PlayerChar.Charisma = context.Characters.Where(x => x.Id == 1).Select(x => x.Charisma).Single();
        PlayerChar.Will = context.Characters.Where(x => x.Id == 1).Select(x => x.Will).Single();
        PlayerChar.Lucky = context.Characters.Where(x => x.Id == 1).Select(x => x.Lucky).Single();
        PlayerChar.Afinnity = context.Characters.Where(x => x.Id == 1).Select(x => x.Afinnity).Single();

        PlayerChar.Name = context.Characters.Where(x => x.Id == 1).Select(x => x.Name).Single();
        PlayerChar.Mentor = context.Characters.Where(x => x.Id == 1).Select(x => x.Mentor).Single();
        PlayerChar.Class = context.Characters.Where(x => x.Id == 1).Select(x => x.Class).Single();
        PlayerChar.SubClass1 = context.Characters.Where(x => x.Id == 1).Select(x => x.SubClass1).Single();
        PlayerChar.SubClass2 = context.Characters.Where(x => x.Id == 1).Select(x => x.SubClass2).Single();
        PlayerChar.Element = context.Characters.Where(x => x.Id == 1).Select(x => x.Element).Single();
        PlayerChar.Carrier = context.Characters.Where(x => x.Id == 1).Select(x => x.Carrier).Single();
        PlayerChar.PlayerColor = context.Characters.Where(x => x.Id == 1).Select(x => x.PlayerColor).Single();
        PlayerChar.TransformedColor = context.Characters.Where(x => x.Id == 1).Select(x => x.TransformedColor).Single();
        PlayerChar.Nation = context.Characters.Where(x => x.Id == 1).Select(x => x.Nation).Single();
        PlayerChar.Body = context.Characters.Where(x => x.Id == 1).Select(x => x.Body).Single();
        PlayerChar.TransformedColor = context.Characters.Where(x => x.Id == 1).Select(x => x.TransformedColor).Single();
        PlayerChar.Vitality = context.Characters.Where(x => x.Id == 1).Select(x => x.Vitality).Single();
        PlayerChar.Vigor = context.Characters.Where(x => x.Id == 1).Select(x => x.Vigor).Single();
        PlayerChar.EnergyStats = context.Characters.Where(x => x.Id == 1).Select(x => x.EnergyStats).Single();
        PlayerChar.Humanity = context.Characters.Where(x => x.Id == 1).Select(x => x.Humanity).Single();
        PlayerChar.Sanity = context.Characters.Where(x => x.Id == 1).Select(x => x.Sanity).Single();
        PlayerChar.Notes = context.Characters.Where(x => x.Id == 1).Select(x => x.Notes).Single();
        PlayerChar.Apperence = context.Characters.Where(x => x.Id == 1).Select(x => x.Apperence).Single();
        PlayerChar.Personality = context.Characters.Where(x => x.Id == 1).Select(x => x.Personality).Single();
        PlayerChar.Lore = context.Characters.Where(x => x.Id == 1).Select(x => x.Lore).Single();
        PlayerChar.Curiosity = context.Characters.Where(x => x.Id == 1).Select(x => x.Curiosity).Single();

        return PlayerChar;
    }
}

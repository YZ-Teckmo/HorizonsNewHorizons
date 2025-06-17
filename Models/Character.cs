namespace Database;

public class Character
{
    public int Id { get; set; }

    //Basic Information
    public string? Name { get; set; }
    public string? TransformedName { get; set; }
    public int? Level { get; set; }
    public string? Mentor { get; set; }
    public List<byte>? CharacterPortrait { get; set; }
    public List<byte>? TransformedPortrait { get; set; }
    public string? Class { get; set; }
    public string? SubClass1 { get; set; }
    public string? SubClass2 { get; set; }
    public string? Element { get; set; }
    public string? Carrier { get; set; }
    public string? PlayerColor { get; set; }
    public string? TransformedColor { get; set; }
    public string? Nation { get; set; }
    public string? Body { get; set; }

    //Stats
    public string? Vitality { get; set; }
    public string? CurrentVitality { get; set; }
    public string? Vigor { get; set; }
    public string? CurrentVigor { get; set; }
    public string? EnergyStats { get; set; }
    public string? CurrentEnergyStats { get; set; }
    public string? Humanity { get; set; }
    public string? CurrentHumanity { get; set; }
    public string? Sanity { get; set; }
    public string? CurrentSanity { get; set; }

    //Basic Speciality
    public int? Strength { get; set; }
    public int? Dexterity { get; set; }
    public int? Inteligency { get; set; }
    public int? Charisma { get; set; }
    public int? EnergyModifier { get; set; }
    public int? Will { get; set; }
    public int? Lucky { get; set; }
    public int? Afinnity { get; set; }

    //Combat Stats
    /*int (ataque)
    int (ataque especial)
    int (defesa)
    int (velocidade)
    int (efeito negativo)
    int (efeito positivo)
    int (resistencia)
    int (chance de esquiva)
    int (chance de bloqueio)
    int (chance critica)
    int (penetração)*/

    //Lists
    public List<int>? Speciality { get; set; }
    public List<int>? Habilities { get; set; }
    public List<int>? Inventory { get; set; }
    public List<int>? Effects { get; set; }

    //Lore Information
    public string? Notes { get; set; }
    public string? Apperence { get; set; }
    public string? Personality { get; set; }
    public string? Lore { get; set; }
    public string? Curiosity { get; set; }
};

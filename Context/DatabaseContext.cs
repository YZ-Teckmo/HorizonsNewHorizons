using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Database;

public class DatabaseContext : DbContext
{
    public DbSet<Character> Characters { get; set; }
    public DbSet<Effect> Effects { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<PlayerHability> PlayerHabilities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source=Database.db");
    }
}

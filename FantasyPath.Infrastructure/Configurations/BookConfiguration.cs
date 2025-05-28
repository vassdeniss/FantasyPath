using FantasyPath.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FantasyPath.Infrastructure.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasData(GetFightingFantasyBooks());
    }

    private static IEnumerable<Book> GetFightingFantasyBooks()
    {
        return new List<Book>
        {
            new() { Order = 1, Title = "The Warlock of Firetop Mountain", Author = "Steve Jackson & Ian Livingstone", Isbn = "9780743475112" },
            new() { Order = 2, Title = "The Citadel of Chaos", Author = "Steve Jackson", Isbn = "9780140316032 " },
            new() { Order = 3, Title = "The Forest of Doom", Author = "Ian Livingstone", Isbn = "9781840464290" },
            new() { Order = 4, Title = "Starship Traveller", Author = "Steve Jackson", Isbn = "9781840465525" },
            new() { Order = 5, Title = "City of Thieves", Author = "Ian Livingstone", Isbn = "9780140316452"},
            new() { Order = 6, Title = "Deathtrap Dungeon", Author = "Ian Livingstone", Isbn = "9780140317084"},
            new() { Order = 7, Title = "Island of the Lizard King", Author = "Ian Livingstone", Isbn = "9780140317435" },
            new() { Order = 8, Title = "Scorpion Swamp", Author = "Steve Jackson", Isbn = "9780140318296" },
            new() { Order = 9, Title = "Caverns of the Snow Witch", Author = "Ian Livingstone", Isbn = "9780140318302" },
            new() { Order = 10, Title = "House of Hell", Author = "Steve Jackson", Isbn = "9780140318319" },
            new() { Order = 11, Title = "Talisman of Death", Author = "Mark Smith & Jamie Thomson", Isbn = "9781840465662" },
            new() { Order = 12, Title = "Space Assassin", Author = "Andrew Chapman", Isbn = "9780440981497" },
            new() { Order = 13, Title = "Freeway Fighter", Author = "Ian Livingstone", Isbn = "9780140317107" },
            new() { Order = 14, Title = "Temple of Terror", Author = "Ian Livingstone", Isbn = "9781840465280" },
            new() { Order = 15, Title = "The Rings of Kether", Author = "Andrew Chapman", Isbn = "9780440974079" },
            new() { Order = 16, Title = "Seas of Blood", Author = "Andrew Chapman", Isbn = "9780440977087" },
            new() { Order = 17, Title = "Appointment with F.E.A.R.", Author = "Steve Jackson", Isbn = "9781840465273" },
            new() { Order = 18, Title = "Rebel Planet", Author = "Robin Waterfield", Isbn = "99780140319521" },
            new() { Order = 19, Title = "Demons of the Deep", Author = "Steve Jackson & Ian Livingstone", Isbn = "9780440918431" },
            new() { Order = 20, Title = "Sword of the Samurai", Author = "Mark Smith & Jamie Thomson", Isbn = "9781840467321" },
            // TODO: 21-59
        };
    }
}

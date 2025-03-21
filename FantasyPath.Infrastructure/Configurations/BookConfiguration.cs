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
            new() { Title = "The Warlock of Firetop Mountain", Author = "Steve Jackson & Ian Livingstone", Isbn = "9780743475112", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110049i/26066622.jpg" },
            new() { Title = "The Citadel of Chaos", Author = "Steve Jackson", Isbn = "9780140316032 ", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1181233137i/1129656.jpg" },
            new() { Title = "The Forest of Doom", Author = "Ian Livingstone", Isbn = "9781840464290", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110513i/26066654.jpg" },
            new() { Title = "Starship Traveller", Author = "Steve Jackson", Isbn = "9781840465525", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1357726081i/17228871.jpg" },
            new() { Title = "City of Thieves", Author = "Ian Livingstone", Isbn = "9780140316452", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439126001i/26067801.jpg" },
            new() { Title = "Deathtrap Dungeon", Author = "Ian Livingstone", Isbn = "9780140317084", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1177021348i/675314.jpg" },
            new() { Title = "Island of the Lizard King", Author = "Ian Livingstone", Isbn = "9780140317435", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439111136i/26066685.jpg" },
            new() { Title = "Scorpion Swamp", Author = "Steve Jackson", Isbn = "9780140318296", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1328038532i/1129804.jpg" },
            new() { Title = "Caverns of the Snow Witch", Author = "Ian Livingstone", Isbn = "9780140318302", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125616i/26067773.jpg" },
            new() { Title = "House of Hell", Author = "Steve Jackson", Isbn = "9780140318319", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1457004279i/1261049.jpg" },
            new() { Title = "Talisman of Death", Author = "Mark Smith & Jamie Thomson", Isbn = "9781840465662", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125202i/26067637.jpg" },
            new() { Title = "Space Assassin", Author = "Andrew Chapman", Isbn = "9780440981497", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124891i/26067557.jpg"  },
            new() { Title = "Freeway Fighter", Author = "Ian Livingstone", Isbn = "9780140317107", CoverImageUrl = "https://cybeswebsite.com/wp-content/uploads/2019/01/Figfan13n-186x300.jpg" },
            new() { Title = "Temple of Terror", Author = "Ian Livingstone", Isbn = "9781840465280", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121250i/26067291.jpg" },
            new() { Title = "The Rings of Kether", Author = "Andrew Chapman", Isbn = "9780440974079", CoverImageUrl = "https://static.wikia.nocookie.net/fightingfantasy/images/e/ee/15_06.jpg/revision/latest/scale-to-width-down/1000?cb=20191223080002" },
            new() { Title = "Seas of Blood", Author = "Andrew Chapman", Isbn = "9780440977087", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121633i/1261180.jpg"},
            new() { Title = "Appointment with F.E.A.R.", Author = "Steve Jackson", Isbn = "9781840465273", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1188764984i/1817973.jpg" },
            new() { Title = "Rebel Planet", Author = "Robin Waterfield", Isbn = "99780140319521", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1232604646i/6123272.jpg" },
            new() { Title = "Demons of the Deep", Author = "Steve Jackson & Ian Livingstone", Isbn = "9780440918431", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124598i/26067514.jpg" },
            new() { Title = "Sword of the Samurai", Author = "Mark Smith & Jamie Thomson", Isbn = "9781840467321", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439123656i/1029657.jpg" },
            new() { Title = "Trial of Champions", Author = "Ian Livingstone", Isbn = "9780140320398", CoverImageUrl = "https://static.wikia.nocookie.net/fightingfantasy/images/1/14/21_11.jpg/revision/latest/scale-to-width-down/1000?cb=20191223064046" },
            new() { Title = "Robot Commando", Author = "Steve Jackson", Isbn = "9780140321524", CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1344077625i/1261601.jpg" },
            // TODO: 23-59
        };
    }
}

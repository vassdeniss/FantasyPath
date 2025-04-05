namespace FantasyPath.Services.Models;

public class BookSaveServiceModel
{
    public BookSaveServiceModel Book { get; set; }
    
    public ICollection<SaveServiceModel> Saves { get; set; }
}

using Microsoft.AspNetCore.Identity;

namespace FantasyPath.Infrastructure.Models;

public class User : IdentityUser<Guid>
{
    public virtual ICollection<UserBook> UserBooks { get; set; } = new HashSet<UserBook>();
    
    public virtual ICollection<Save> Saves { get; } = new HashSet<Save>();    
}

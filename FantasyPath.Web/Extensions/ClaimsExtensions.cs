using System.Security.Claims;

namespace FantasyPath.Web.Extensions;

public static class ClaimsExtensions
{
    public static Guid Id(this ClaimsPrincipal user)
    {
        return Guid.Parse(user.FindFirstValue(ClaimTypes.NameIdentifier)!);
    }    
}

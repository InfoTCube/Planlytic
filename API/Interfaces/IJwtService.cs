using API.Entities;

namespace API.Interfaces;

public interface IJwtService
{
    string GenerateToken(AppUser user);
}
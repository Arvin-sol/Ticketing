using Ticketing.Data.Entities.UserEntities;

namespace Ticketing.Data.Interfaces;
public interface IJwtProvider
{
    public string Generate(User model);
}


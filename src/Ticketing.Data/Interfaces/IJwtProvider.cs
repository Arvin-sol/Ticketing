using Ticketing.Data.Entities;

namespace Ticketing.Data.Interfaces;
public interface IJwtProvider
{
    public string Generate(User model);
}


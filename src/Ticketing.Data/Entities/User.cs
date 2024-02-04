
namespace Ticketing.Data.Entities;
public class User :BaseEntity,IEntity
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public ICollection<UserSelectedRols> UserSelectedRols { get; set; }
}


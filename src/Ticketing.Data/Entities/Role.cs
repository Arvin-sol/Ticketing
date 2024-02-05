namespace Ticketing.Data.Entities;
public class Role : BaseEntity, IEntity
{
    public string UniqRoleTitle { get; set; }

    public ICollection<UserSelectedRols> UserSelectedRol { get; set; }
}


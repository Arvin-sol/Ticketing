namespace Ticketing.Data.Entities.UserEntities;
public class Role : BaseEntity, IEntity
{
    public string UniqRoleTitle { get; set; }

    public ICollection<UserSelectedRols> UserSelectedRol { get; set; }
}


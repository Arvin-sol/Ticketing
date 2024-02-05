namespace Ticketing.Data.Entities.UserEntities;
public class UserSelectedRols : BaseEntity, IEntity
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }


    //Relations
    public Role Roles { get; set; }
    public User users { get; set; }
}


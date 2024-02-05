using Ticketing.Data.Entities.TicketingEntities;
using Ticketing.Data.Entities.UserEntities;
using Ticketing.Data.DTOs;

namespace Ticketing.Services.Common;
public static class CustomMapper
{
    public static UserDTO ConvertToDTO(this User model)
        =>new UserDTO(model.Name, model.LastName, model.Email);
    public static RoleDTO ConvertToDTO(this Role model)
        => new RoleDTO(model.Id, model.UniqRoleTitle);
    public static TicketCategoryDTO ConvertToDTO(this TicketCategory model)
    => new TicketCategoryDTO(model.CategoryTitle,model.Id);

}




namespace Ticketing.Services.RolesService.Create;
public record CreateRoleCommand(string RoleTitle):IRequest<bool>;


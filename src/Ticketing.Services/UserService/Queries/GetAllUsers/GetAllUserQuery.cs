

using Ticketing.Data.DTOs;

namespace Ticketing.Services.UserService.Queries.GetAllUsers;
public record GetAllUserQuery() : IRequest<ICollection<UserDTO>>;

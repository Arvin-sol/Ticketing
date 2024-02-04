
namespace Ticketing.Services.UserService.Commands.Login;
public record LoginUserCommand(string email , string password):IRequest<bool>;



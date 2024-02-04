using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.UserService.Commands.Login;
public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, bool>
{
    #region DI
    private readonly IUserRepository _userRepository;
    public LoginUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    #endregion
    public async Task<bool> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var getUser =  await _userRepository.FindByEmail(request.email);
        if (getUser == null)
            return false;
        return BCrypt.Net.BCrypt.Verify(request.password, getUser.Password);
    }
}


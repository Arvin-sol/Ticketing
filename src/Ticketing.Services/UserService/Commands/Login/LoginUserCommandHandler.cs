using Ticketing.Data.Interfaces;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.UserService.Commands.Login;
public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, bool>
{
    #region DI
    private readonly IUserRepository _userRepository;
    private readonly IJwtProvider _jwtProvider;
    public LoginUserCommandHandler(IUserRepository userRepository, IJwtProvider jwtProvider)
    {
        _userRepository = userRepository;
        _jwtProvider = jwtProvider;
    }
    #endregion
    public async Task<bool> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var getUser =  await _userRepository.FindByEmail(request.email);
        if (getUser == null)
            return false;
        _jwtProvider.Generate(getUser);
        return BCrypt.Net.BCrypt.Verify(request.password, getUser.Password);
    }
}


using Ticketing.Data.Interfaces;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.UserService.Commands.Login;
public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, string>
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
    public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var getUser =  await _userRepository.FindByEmail(request.email);
        if (getUser == null)
            return "User Not Found";
        string token =  _jwtProvider.Generate(getUser);
        bool resualt =  BCrypt.Net.BCrypt.Verify(request.password, getUser.Password);
        if (resualt)
            return token;
        return default;
    }
}


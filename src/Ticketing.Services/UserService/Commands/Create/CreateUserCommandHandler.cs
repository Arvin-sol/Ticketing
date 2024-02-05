using Ticketing.Data.Interfaces;
using BCrypt.Net;
using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Data.Entities;

namespace Ticketing.Services.UserService.Commands.Create;
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
{
    #region DI
    private readonly IApplicationUnitOfWork _uow;
    private readonly IUserRepository _userRepository;
    private readonly IJwtProvider _jwtProvider;
    public CreateUserCommandHandler(IJwtProvider jwtProvider,IApplicationUnitOfWork applicationUnitOfWork, IUserRepository userRepository)
    {
        _uow = applicationUnitOfWork;
        _userRepository = userRepository;
        _jwtProvider = jwtProvider;
    }
    #endregion


    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var hashPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);

        User NewUser = new()
        {
            Name = request.Name,
            Email = request.Email,
            LastName = request.LastName,
            Password = hashPassword
        };

        var createNewUser = await _userRepository.CreateAsync(NewUser);
        if (createNewUser)
        {
            _jwtProvider.Generate(NewUser);
            return await _uow.SaveChangesAsync();

        }

        return false;


    }
}


using Ticketing.Data.Interfaces;
using Ticketing.Data.Entities;
using BCrypt.Net;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.UserService.Commands.Create;
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
{
    #region DI
    private readonly IApplicationUnitOfWork _uow;
    private readonly IUserRepository _userRepository;
    public CreateUserCommandHandler(IApplicationUnitOfWork applicationUnitOfWork, IUserRepository userRepository)
    {
        _uow = applicationUnitOfWork;
        _userRepository = userRepository;
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
            return await _uow.SaveChangesAsync();
        return false;


    }
}


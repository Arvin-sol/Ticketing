using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Interfaces;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.UserService.Commands.Delete;
public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
{
    #region DI
    private readonly IUserRepository _userRepository;
    private readonly IApplicationUnitOfWork _uow;
    public DeleteUserCommandHandler(IUserRepository userRepository, IApplicationUnitOfWork applicationUnitOfWork)
    {
        _userRepository = userRepository;
        _uow = applicationUnitOfWork;
    }
    #endregion
    public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var getUser = await _userRepository.GetByIdAsync(request.Id);
        if (getUser == null)
            return false;
        bool deleteUser = _userRepository.Delete(getUser);
        if (deleteUser)
            return await _uow.SaveChangesAsync();
        return deleteUser;
    }
}


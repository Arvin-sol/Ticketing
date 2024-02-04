using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Interfaces;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.UserService.Commands.Update;
public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
{
    #region DI
    private readonly IUserRepository _userRepository;
    private readonly IApplicationUnitOfWork _uow;
    public UpdateUserCommandHandler(IUserRepository userRepository, IApplicationUnitOfWork applicationUnitOfWork)
    {
        _userRepository = userRepository;
        _uow = applicationUnitOfWork;
    }
    #endregion
    public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var getUser = await _userRepository.GetByIdAsync(request.Id);
        if (getUser == null)
            return false;
        getUser.Name = request.Name;
        getUser.Email = request.Email;
        getUser.LastName = request.LastName;
        getUser.UpdateDate = DateTime.Now;
        return await _uow.SaveChangesAsync();
    }
}


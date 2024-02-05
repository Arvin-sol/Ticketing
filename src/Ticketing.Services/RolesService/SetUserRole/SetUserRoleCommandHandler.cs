using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Entities.UserEntities;
using Ticketing.Data.Interfaces;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.RolesService.SetUserRole;
public class SetUserRoleCommandHandler : IRequestHandler<SetUserRoleCommand, bool>
{
    #region DI
    private readonly IUserSelectedRolesRepository _rolesRepository;
    private readonly IApplicationUnitOfWork _uow;
    public SetUserRoleCommandHandler(IUserSelectedRolesRepository rolesRepository,IApplicationUnitOfWork applicationUnitOfWork) 
    {
        _rolesRepository = rolesRepository;
        _uow = applicationUnitOfWork;
    }
    #endregion
    public async Task<bool> Handle(SetUserRoleCommand request, CancellationToken cancellationToken)
    {

        UserSelectedRols userSelectedRols = new()
        {
            UserId = request.User,
            RoleId = request.Role
        };
        bool setRole = await _rolesRepository.CreateAsync(userSelectedRols);
        if (setRole)
            return await _uow.SaveChangesAsync();
        return setRole;
    }
}


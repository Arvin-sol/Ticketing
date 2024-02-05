using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Interfaces;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.RolesService.ChangeUserRole;
public class ChangeUserRoleCommandHandler : IRequestHandler<ChangeUserRoleCommand, bool>
{
    #region DI
    private readonly IUserSelectedRolesRepository _userSelected;
    private readonly IApplicationUnitOfWork _uow;
    #endregion
    public ChangeUserRoleCommandHandler(IUserSelectedRolesRepository userSelected , IApplicationUnitOfWork uow)
    {
        _userSelected = userSelected;
        _uow = uow;
    }
    
    public async Task<bool> Handle(ChangeUserRoleCommand request, CancellationToken cancellationToken)
    {
        var getUserRole =  await _userSelected.GetByUserIdAsync(request.UserId);
        getUserRole.RoleId = request.RoleId;
        getUserRole.UpdateDate = DateTime.Now;
        return await _uow.SaveChangesAsync();
    }
}


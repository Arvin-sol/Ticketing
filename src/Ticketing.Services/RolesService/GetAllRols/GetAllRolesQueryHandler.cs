using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Data.DTOs;

namespace Ticketing.Services.RolesService.GetAllRols;
public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, ICollection<RoleDTO>>
{
    #region DI
    private readonly IRoleRepository _roleRepository;
    public GetAllRolesQueryHandler(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }
    #endregion
    public async Task<ICollection<RoleDTO>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
    {
        var getAllRoles =  await _roleRepository.GetAllAsync();
        return getAllRoles.Select(x=>x.ConvertToDTO()).ToList();
    }
}


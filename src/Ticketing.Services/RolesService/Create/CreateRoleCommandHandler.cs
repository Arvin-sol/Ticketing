using Ticketing.Data.Entities;
using Ticketing.Data.Interfaces;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Services.RolesService.Create;
public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, bool>
{
    #region DI
    private readonly IRoleRepository _roleRepository;
    private readonly IApplicationUnitOfWork _uow;
    public CreateRoleCommandHandler(IRoleRepository roleRepository,IApplicationUnitOfWork applicationUnitOfWork)
    {
        _roleRepository = roleRepository;
        _uow = applicationUnitOfWork;
    }
    #endregion
    public async Task<bool> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        Role newRole = new()
        {
            UniqRoleTitle = request.RoleTitle
        };
        bool addRole = await _roleRepository.CreateAsync(newRole);
        if (addRole)
            return await _uow.SaveChangesAsync();
        return false;
    }
}


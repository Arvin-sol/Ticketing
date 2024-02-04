using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Interfaces.IRepositories;
using Ticketing.Services.DTOs;

namespace Ticketing.Services.UserService.Queries.GetAllUsers;
internal class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, ICollection<UserDTO>>
{
    #region DI
    private readonly IUserRepository _userRepository;
    public GetAllUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;   
    }
    #endregion
    public async Task<ICollection<UserDTO>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
    {
        var allUsers =  await _userRepository.GetAllAsync();
        return allUsers.Select(x => x.ConvertToDTO()).ToList();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Services.UserService.Commands.Update;
public record UpdateUserCommand
    (Guid Id , string Name , string LastName , string Email) 
    : IRequest<bool>;



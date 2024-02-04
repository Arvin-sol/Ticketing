using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Services.UserService.Commands.Delete;
public record DeleteUserCommand(Guid Id) 
    : IRequest<bool>;



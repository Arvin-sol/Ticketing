using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Services.UserService.Commands.Delete;
public class DeleteUserCommand
    : IRequest<bool>
{
    public Guid Id { get; set; }
}



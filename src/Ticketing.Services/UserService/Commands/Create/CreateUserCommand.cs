using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Services.UserService.Commands.Create;
public record CreateUserCommand
    (string Name , string LastName , string Password , string Email) 
    : IRequest<bool>;



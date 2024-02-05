using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Interfaces;
using Ticketing.Data.Interfaces.IRepositories;

namespace Ticketing.Data.Implementations;
public class TokenValidator : ITokenValidator
{
    private readonly IUserRepository _userRepository;
    public TokenValidator(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task Execute(TokenValidatedContext token)
    {
        var claims = token.Principal.Identity as ClaimsIdentity;
        if (claims?.Claims == null || !claims.Claims.Any())
        {
            token.Fail("claims not fount");
            return;
        }
        var userId = claims.FindFirst("sub").Value;
        if(!Guid.TryParse(userId,out Guid userGuid))
        {
            token.Fail("claims not fount");
            return;
        }
        var user = await _userRepository.GetByIdAsync(userGuid);
        if (user == null)
        {
            token.Fail("User not found");
            return;
        }
    }
}


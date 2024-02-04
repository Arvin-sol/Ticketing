
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Ticketing.Data.Entities;
using Ticketing.Data.Interfaces;

namespace Ticketing.Data.Implementations;
public class JwtProvider : IJwtProvider
{
    private readonly JwtOptions _jwtOptions;
    public JwtProvider(IOptions<JwtOptions> options)
    {
        _jwtOptions = options.Value;
    }
    public string Generate(User model)
    {
        var claims = new Claim[] 
        {
            new(JwtRegisteredClaimNames.Sub , model.Id.ToString()),
            new(JwtRegisteredClaimNames.Email , model.Email),
        };
        var signingCredentials = new SigningCredentials
            (new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)), SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken
            (_jwtOptions.Issuer,_jwtOptions.Audience,claims,null,DateTime.Now.AddHours(1), signingCredentials);

        string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
        return tokenValue;
    }
}


using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Data.Interfaces;
public interface ITokenValidator
{
    Task Execute(TokenValidatedContext token);
}


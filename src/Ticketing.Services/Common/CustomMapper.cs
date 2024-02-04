using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Entities;
using Ticketing.Services.DTOs;

namespace Ticketing.Services.Common;
public static class CustomMapper
{
    public static UserDTO ConvertToDTO(this User model)
        =>
            new UserDTO(model.Name, model.LastName, model.Email);
    
}


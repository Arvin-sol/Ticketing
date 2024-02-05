using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Data.DTOs;

public record UserDTO
    (
    string name,
    string lastName,
    string email
    );


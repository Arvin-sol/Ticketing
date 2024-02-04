using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Data.Entities;
public class Role :BaseEntity , IEntity
{
    public string UniqRoleTitle { get; set; }

    public ICollection<UserSelectedRols> UserSelectedRol { get; set; }
}


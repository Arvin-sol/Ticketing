using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Enums;

namespace Ticketing.Data.DTOs;
public class TicketMessegeDTO
{
    public string message { get; init; }
    public string senderName { get; init; }
    public string CategoryTitle { get; init; }
    public ReadOrClosedTicketEnum Status { get; init; }
}
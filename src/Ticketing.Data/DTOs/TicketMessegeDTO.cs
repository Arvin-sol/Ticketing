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
    public string message { get; set; }
    public string senderName { get; set; }
    public string CategoryTitle { get; set; }
    public ReadOrClosedTicketEnum Status { get; set; }
}
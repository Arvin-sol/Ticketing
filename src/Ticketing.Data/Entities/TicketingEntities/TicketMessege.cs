using Ticketing.Data.Entities.UserEntities;
using Ticketing.Data.Enums;

namespace Ticketing.Data.Entities.TicketingEntities;
public class TicketMessege : BaseEntity, IEntity
{
    public string Message { get; set; }
    public ReadOrClosedTicketEnum Status{ get; set; }
    public Guid SenderId { get; set; }
    public Guid CategoryId { get; set; }


    public TicketCategory Category { get; set; }
    public User Sender { get; set; }
}


namespace Ticketing.Data.Entities;
public class TicketMessege : BaseEntity, IEntity
{
    public string Message { get; set; }
    public Guid SenderId { get; set; }
    public Guid CategoryId { get; set; }

    public TicketCategory Category { get; set; }
    public User Sender { get; set; }
}


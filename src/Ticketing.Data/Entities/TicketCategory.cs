namespace Ticketing.Data.Entities;
public class TicketCategory : BaseEntity, IEntity
{
    public string CategoryTitle { get; set; }

    public ICollection<TicketMessege> messeges { get; set; }
}


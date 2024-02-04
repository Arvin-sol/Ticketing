
namespace Ticketing.Data.Common;
public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public DateTime? UpdateDate { get; set; }
}


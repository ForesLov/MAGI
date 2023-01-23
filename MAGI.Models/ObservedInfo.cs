

namespace MAGI.Models;

public class ObservedInfo : EntityBase
{
    public DbTable ObservedTable { get; set; }
    public List<DbTableColumn> DbTableColumns { get; set; } = new();

}

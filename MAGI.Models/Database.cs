namespace MAGI.Models;

public class Database:EntityBase
{
    public string Name { get; set; }
    public string ConnectionString { get; set; }
    public List<ObservedInfo> ObservedInfo { get; set; }
}
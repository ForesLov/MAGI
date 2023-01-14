namespace MAGI.Models
{
    public class Database
    {
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public ObservedInfo ObservedInfo { get; set; }
    }
}
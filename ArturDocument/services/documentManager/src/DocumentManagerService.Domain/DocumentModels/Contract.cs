using DocumentManagerService.DDD;

namespace DocumentManagerService.Domain
{
    public class Contract : Entity<int>
    {
        public Contract(int id, string name, string subject)
        {
            Id = id;
            Name = name;
            Subject = subject;
        }
        public string Name { get; protected set; }
        public string Subject { get; protected set; }
    }
}

namespace WebAPI.Models
{
    public class BaseEntity<Tid>
        where Tid : IEquatable<Tid>
    {
        public BaseEntity()
        {
            //this.CreateAt = DateTime.UtcNow;
        }

        public Tid Id { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
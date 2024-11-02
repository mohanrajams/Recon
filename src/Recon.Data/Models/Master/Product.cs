namespace Recon.Data.Models.Master
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public long ProviderId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual Provider Provider { get; set; }    
    }
}

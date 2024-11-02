namespace Recon.Data.Models.Master
{
    public class Provider
    {
        public Provider()
        {
            Products = [];   
        }

        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

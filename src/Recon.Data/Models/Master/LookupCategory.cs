namespace Recon.Data.Models.Master
{
    public class LookupCategory
    {
        public LookupCategory()
        {
            LookUps = [];   
        }

        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<LookUp> LookUps { get; set; }
    }
}

namespace Recon.Data.Models.Master
{
    public class LookUp
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public long LookUpCategoryId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LookupCategory LookUpCategory { get; set; }    
    }
}

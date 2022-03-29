namespace NorthwindAPI.Models.DTO
{
    public class SupplierDTO
    {
        public SupplierDTO()
        {
            Products = new List<string>();
        }

        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Country { get; set; }
        public virtual ICollection<string> Products { get; set; }
    }
}
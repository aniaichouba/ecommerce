using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string ImageURL { get; set; } = String.Empty;
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
    }
}

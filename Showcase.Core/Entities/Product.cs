namespace Showcase.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; } 
        public string Description { get; set; }
        public double Price { get; set; }
        public byte Rating { get; set; }
        public bool Sale{ get; set; }
        public bool IsActive { get; set; } = true;
        public string ImagePath { get; set; } = "//";
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
    }
}

using Server.Domain.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace Server.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        // Foreign Key for Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Foreign Key for Image
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}

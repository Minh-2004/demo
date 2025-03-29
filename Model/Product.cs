using System.ComponentModel.DataAnnotations.Schema;

namespace phamminh_2122110339.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")] // Sửa lỗi
        public decimal Price { get; set; }

        public string Description { get; set; }
        public string Img { get; set; }
    }
}

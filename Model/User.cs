using System.ComponentModel.DataAnnotations;

namespace phamminh_2122110339.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Thiết lập mối quan hệ 1-n với Order
        public List<Order> Orders { get; set; }
    }
}

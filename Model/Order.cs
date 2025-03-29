using System;
using System.Collections.Generic;

namespace phamminh_2122110339.Model
{
    public class Order
    {
        public int Id { get; set; } // Mã đơn hàng
        public int UserId { get; set; } // Khóa ngoại liên kết với User
        public DateTime OrderDate { get; set; } = DateTime.Now; // Ngày đặt hàng
        public decimal TotalAmount { get; set; } // Tổng tiền
        public string Status { get; set; } = "Pending"; // Trạng thái đơn hàng (Pending, Completed, Canceled)

        // Thiết lập mối quan hệ với User
        public User User { get; set; }

        // Chi tiết đơn hàng
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}

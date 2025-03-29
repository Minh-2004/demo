namespace phamminh_2122110339.Model
{
    public class OrderDetail
    {
        public int Id { get; set; } // Mã chi tiết đơn hàng
        public int OrderId { get; set; } // Mã đơn hàng
        public int ProductId { get; set; } // Mã sản phẩm
        public int Quantity { get; set; } // Số lượng sản phẩm
        public decimal UnitPrice { get; set; } // Giá sản phẩm
    }
}

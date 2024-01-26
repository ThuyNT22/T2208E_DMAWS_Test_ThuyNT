using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class OrderModel
    {
        [Key]
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ItemQty { get; set; }
        public string OrderDelivery { get; set; }
        public string OrderAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}

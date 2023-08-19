using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Website.Models
{
    public class Order
    {
        [Key]
        public int order_id { get; set; }
        public int cart_id { get; set; }
        public int order_status { get; set; }
    }
}

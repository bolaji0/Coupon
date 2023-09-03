using System.ComponentModel.DataAnnotations;

namespace CouponApi.Model
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; }
        public int DiscountAmount { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeBuying.Model
{
    public class PriceDataContract
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal PriceInclVAT { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int ShopId { get; set; }

        [Required]
        public decimal PricePerUnit { get; set; }

        [Required]
        public ItemDataContract Item { get; set; }

        [Required]
        public ShopDataContract Shop { get; set; }

        [Required]
        public List<DiscountDataContract> Discount { get; set; }

        [Required]
        public List<int> DiscountsId { get; set; }
    }
}

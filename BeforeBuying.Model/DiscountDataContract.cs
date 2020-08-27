using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeBuying.Model
{
    public class DiscountDataContract
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public System.DateTime DiscountFrom { get; set; }
        [Required]
        public System.DateTime DiscountTo { get; set; }
        [Required]
        public short Percent { get; set; }
        [Required]
        public decimal PriceInclVAT { get; set; }
        [Required]
        public Nullable<int> PriceId { get; set; }

        [Required]
        public PriceDataContract Price { get; set; }

    }
}

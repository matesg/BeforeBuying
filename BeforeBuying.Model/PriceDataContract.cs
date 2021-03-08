using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BeforeBuying.Model
{
    [DataContract]
    public class PriceDataContract
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public decimal PriceInclVAT { get; set; }

        [Required]
        [DataMember]
        public int ItemId { get; set; }

        [Required]
        [DataMember]
        public int ShopId { get; set; }

        [Required]
        [DataMember]
        public decimal PricePerUnit { get; set; }

        [Required]
        [DataMember]
        public ItemDataContract Item { get; set; }

        [Required]
        [DataMember]
        public ShopDataContract Shop { get; set; }

        [Required]
        [DataMember]
        public List<DiscountDataContract> Discount { get; set; }

        [Required]
        [DataMember]
        public List<int> DiscountsId { get; set; }
    }
}

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
    public class DiscountDataContract
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public System.DateTime DiscountFrom { get; set; }

        [Required]
        [DataMember]
        public System.DateTime DiscountTo { get; set; }

        [Required]
        [DataMember]
        public short Percent { get; set; }

        [Required]
        [DataMember]
        public decimal PriceInclVAT { get; set; }

        [Required]
        [DataMember]
        public Nullable<int> PriceId { get; set; }

        [Required]
        [DataMember]
        public PriceDataContract Price { get; set; }

    }
}

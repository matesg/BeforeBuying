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
    public class ItemDataContract
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string Name { get; set; }
        
        [Required]
        [DataMember]
        public string EAN { get; set; }
        
        [Required]
        [DataMember]
        public string UnitOfMeasure { get; set; }

        [Required]
        [DataMember]
        public List<PriceDataContract> Price1 { get; set; }

        [Required]
        [DataMember]
        public List<int> PriceId {get; set;}
    }
}

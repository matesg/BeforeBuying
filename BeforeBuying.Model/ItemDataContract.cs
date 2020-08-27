using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeBuying.Model
{
    public class ItemDataContract
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string EAN { get; set; }
        [Required]
        public string UnitOfMeasure { get; set; }

        [Required]
        public List<PriceDataContract> Price1 { get; set; }

        [Required]
        public List<int> PriceId {get; set;}
    }
}

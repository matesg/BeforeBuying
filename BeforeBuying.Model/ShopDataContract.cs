using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeBuying.Model
{
    public class ShopDataContract
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public List<PriceDataContract> Price { get; set; }

        [Required]
        public List<int> PricesId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeBuying.Model
{
    public class Nakup
    {
        private int polozka;
        private decimal cena;
        private int kusov;
        

        public int Polozka { get; set; }
        public decimal Cena { get; set; }
        public int Kusov { get; set; }
        public int ShopId { get; set; }
    }
}

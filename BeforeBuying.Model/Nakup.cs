using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BeforeBuying.Model
{
    [DataContract]
    public class Nakup
    {
        private int polozka;
        private decimal cena;
        private int kusov;

        [DataMember]
        public int Polozka { get; set; }

        [DataMember]
        public decimal Cena { get; set; }

        [DataMember]
        public int Kusov { get; set; }

        [DataMember]
        public int ShopId { get; set; }

        [DataMember]
        public int ItemId { get; set; }
    }
}

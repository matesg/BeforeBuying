//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeforeBuying.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Price
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Price()
        {
            this.Discount = new HashSet<Discount>();
        }
    
        public int Id { get; set; }
        public decimal PriceInclVAT { get; set; }
        public int ItemId { get; set; }
        public int ShopId { get; set; }
        public decimal PricePerUnit { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Shop Shop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Discount> Discount { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeShopWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            this.BillInfoes = new HashSet<BillInfo>();
        }
    
        public string Id { get; set; }
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double IntputPrice { get; set; }
        public double OutputPrice { get; set; }
        public string Note { get; set; }
        public string IdImage { get; set; }
        public bool IsOutOfStock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfoes { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
        public virtual Image Image { get; set; }
    }
}

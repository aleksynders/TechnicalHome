//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpf_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.PriceChange = new HashSet<PriceChange>();
        }
    
        public int product_code { get; set; }
        public int manufacturer_code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int category { get; set; }
        public int price { get; set; }
        public int amount { get; set; }
        public Nullable<int> discount { get; set; }
        public byte[] image_product { get; set; }
        public Nullable<int> rate { get; set; }
    
        public virtual Manufacturers Manufacturers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceChange> PriceChange { get; set; }
        public virtual Ratings Ratings { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeHouse.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.SaleProduct = new HashSet<SaleProduct>();
        }
    
        public int IdProduct { get; set; }
        public string ProdName { get; set; }
        public decimal Price { get; set; }
        public Nullable<bool> InStock { get; set; }
        public Nullable<int> IdDiscount { get; set; }
        public string Description { get; set; }
        public byte[] ProdImage { get; set; }
        public int IdCategory { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Discount Discount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleProduct> SaleProduct { get; set; }
    }
}

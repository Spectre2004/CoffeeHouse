//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeHouse.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleProduct
    {
        public int IdSale { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
    }
}

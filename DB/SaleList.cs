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
    
    public partial class SaleList
    {
        public int SaleCode { get; set; }
        public System.DateTime SaleDateTime { get; set; }
        public string EmployeerName { get; set; }
        public string ClientName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> FullPrice { get; set; }
    }
}
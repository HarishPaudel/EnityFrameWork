using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CodeFirstApproach.Models
{
    //for migration steps
    //1) Enable-Migrations -ContextTypeName NorthWind.
    //2) Add-Migration ABC
    //3) Update-Database 

    [Table("tblproducts")]
    public class Products
    {
        [Key]
        public int productid { get; set; }
        public string productname { get; set; }
        public decimal price { get; set; }
        public decimal price1 { get; set; }
        public Category category { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach.Models
{
    [Table("tblcategory")]
    public class Category
    {
        [Key]
        public int categoryid { get; set; }
        public string categoryname { get; set; }
    }
}
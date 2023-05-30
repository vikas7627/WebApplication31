using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication31.Models
{
    public class Product
    {

        [Required]
        [Display(Name = "Product Id")]
        public int pid { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string pname { get; set; }
        [Required]
        [Display(Name = "Catagory Id")]
        public int cid { get; set; }
        [Required]
        [Display(Name = "Catagory Name")]
        public string cname { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace WebApplication31
{
    public class category
    {
        [Required]
        [Display(Name = "category Id")]

        public string cid { get; set; }

        [Display(Name = "category Name")]
        public string cname { get; set; }

    }
}
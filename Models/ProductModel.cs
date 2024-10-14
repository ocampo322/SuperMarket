﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Customers Id")]
        public int Id { get; set; }

        [DisplayName("Customers Firt_Name")]
        [Required(ErrorMessage = "Product  firt_name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Name { get; set; }

        [DisplayName("Customers Firt_Name")]
        public decimal Price { get; set; }

        [DisplayName("Customers Firt_Name")]
        public int Stock { get; set; }
    }
}

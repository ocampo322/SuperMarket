using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CustomerModel
    {
        [DisplayName("Customer Id")]
        public int Id { get; set; }

        [DisplayName("Customer Document Number")]
        [Required(ErrorMessage = "Customer Document Number is required")]
        public int Document_Number { get; set; }

        [DisplayName("Customer First Name")]
        [Required(ErrorMessage = "Customer First Namw is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Customer First Name must be between 5 and 20 characters")]
        public string First_Name { get; set; }

        [DisplayName("Customer Last Name")]
        [Required(ErrorMessage = "Customer Last Name is required")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Customer Last Name must be between 3 and 15 characters")]
        public string Last_Name { get; set; }

        [DisplayName("Customer Address")]
        [Required(ErrorMessage = "Customer Address is required")]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "Customer Address must be between 10 and 30 characters")]
        public string Address { get; set; }

        [DisplayName("Customer Birthday")]
        [Required(ErrorMessage = "Customer Birthay is required")]
        public string Birthday { get; set; }

        [DisplayName("Customer Phone Number")]
        [Required(ErrorMessage = "Customer Phone Number is required")]
        
        public int Phone_Number { get; set; }

        [DisplayName("Customer Email")]
        [Required(ErrorMessage = "Customer Email is required")]
        [StringLength(5, MinimumLength = 30, ErrorMessage = "Customer Email must be between 5 and 30 characters")]
        public string Email { get; set; }
    }
}

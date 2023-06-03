using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Shopping
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter First and Last Name")]
        public string FullName { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Delivery Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please select a Country")]
        public int City { get; set; }
        [Required(ErrorMessage = "Please select a Province/City")]
        public int District { get; set; }
        [Required(ErrorMessage = "Please select a District")]
        public int Street { get; set; }
        public int PaymentID { get; set; }
        public string Note { get; set; }
    }
}

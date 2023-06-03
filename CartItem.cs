using Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public class CartItem
	{
        public Product? product { get; set; }
		public int amount { get; set; }
		public double TotalMoney => amount * product.Price.Value;
	}
}

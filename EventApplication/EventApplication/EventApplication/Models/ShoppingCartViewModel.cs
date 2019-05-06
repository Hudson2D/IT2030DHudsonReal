using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems;

        public int CartTotal;

       
    }
}
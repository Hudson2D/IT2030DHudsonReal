using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;


namespace EventApplication.Controllers
{
    public class ShoppingCartController : Controller
    {
        EventApplicationDB db = new EventApplicationDB();

        // GET: ShoppingCart
        [Authorize]
        public ActionResult Index()
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);

            ShoppingCartViewModel vm = new ShoppingCartViewModel()
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetCartTotal()
            };

            return View(vm);
        }

        [Authorize]
        public ActionResult OrderSummary(int param1, int param2)
        {

            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            cart.RegisterPage2(param1, param2);

            Event @event = db.Events.Find(param1);

            ViewBag.TicketsOrdered = param2;
            
            return View(@event);
        }

        [Authorize]
        public ActionResult RegisterPage(int id)
        {
            Event @event = db.Events.Find(id);
            return View(@event);
            
        }


        [Authorize]
        public ActionResult AddToCart(int id)
        {
            // ShoppingCart cart = new ShoppingCart();
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            cart.AddToCart(id);
            /* for (int i = 0; i >= count; i++) {
                cart.AddToCart(id);
            } */
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Authorize]
        public ActionResult RemoveFromCart(int id)
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);

            Event events = db.Carts.SingleOrDefault(c => c.RecordId == id).EventSelected;

            int newItemCount = cart.RemoveFromCart(id);


            ShoppingCartRemoveViewModel vm = new ShoppingCartRemoveViewModel()
            {
                DeleteId = id,

                ItemCount = newItemCount,
                Message = events.EventTitle + " has been remove from the cart",
                OrderMessage = "Cancelled"
            };

            return Json(vm);
        }

    }
}
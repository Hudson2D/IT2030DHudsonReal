using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId;

        private EventApplicationDB db = new EventApplicationDB();

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }

        private string GetCartId(HttpContextBase context)
        {
            const string CartSessionId = "CartId";

            string cartId;

            if(context.Session[CartSessionId] == null)
            {

                cartId = Guid.NewGuid().ToString();

                context.Session[CartSessionId] = cartId;
            }
            else
            {

                cartId = context.Session[CartSessionId].ToString();

            }

            return cartId;
            
        }

        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(c => c.CartId == this.ShoppingCartId).ToList();

        }

        public int GetCartTotal()
        {
            return db.Carts.Count();
        }

        public void RegisterPage2(int eventId, int eventCount)
        {
            // TODO: Verify that the Album Id exists in the database.
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.ShoppingCartId && c.EventId == eventId);

            Event Removeticket = db.Events.SingleOrDefault(c => c.EventId == eventId);
            if(Removeticket.AvailableTickets < eventCount)
            {
                throw new NullReferenceException();
            }
            else if (cartItem == null)
            {
                // Item is not in cart, add new item
                cartItem = new Cart()
                {
                    CartId = this.ShoppingCartId,
                    EventId = eventId,
                    Count = eventCount,
                    DateCreated = DateTime.Now,
                    OrderStatus = "Processed"

                };
                Removeticket.AvailableTickets = Removeticket.AvailableTickets - eventCount;
                db.Carts.Add(cartItem);

            }
            else
            {
                // Item is already in cart, increase item count (quantity)
                Removeticket.AvailableTickets = Removeticket.AvailableTickets - eventCount;
                cartItem.Count = cartItem.Count + eventCount;
                cartItem.OrderStatus = "Processed";
            }

            db.SaveChanges();

            
        }

        public void AddToCart(int eventId)
        {
            // TODO: Verify that the Album Id exists in the database.
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.ShoppingCartId && c.EventId == eventId);

            Event Removeticket = db.Events.SingleOrDefault(c => c.EventId == eventId);

            if (cartItem == null)
            {
                // Item is not in cart, add new item
                cartItem = new Cart()
                {
                    CartId = this.ShoppingCartId,
                    EventId = eventId,
                    Count = 1,
                    DateCreated = DateTime.Now,
                    OrderStatus = "Processed"

                };
                Removeticket.AvailableTickets--;
                db.Carts.Add(cartItem);

            }
            else
            {
                // Item is already in cart, increase item count (quantity)
                Removeticket.AvailableTickets--;
                cartItem.Count++;
                cartItem.OrderStatus = "Processed";
            }

            db.SaveChanges();

           
        }

        public int RemoveFromCart(int recordId)
        {
            
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.ShoppingCartId && c.RecordId == recordId);
            Event Removeticket = db.Events.SingleOrDefault(c => c.EventId == cartItem.EventId);
            if (cartItem == null)
            {
                throw new NullReferenceException();
            }

            int newCount;
            if (cartItem.Count > 1)
            {
                Removeticket.AvailableTickets = Removeticket.AvailableTickets + cartItem.Count;
                // the count > 1; decrease count
                cartItem.Count = 0;
                newCount = cartItem.Count;
                if(cartItem.Count == 0)
                {
                    cartItem.OrderStatus = "Cancelled";
                }
                
            }
            else
            {
                Removeticket.AvailableTickets = Removeticket.AvailableTickets + cartItem.Count;
                // the count <= 0; remove item
                // db.Carts.Remove(cartItem);
                cartItem.Count--;
                newCount = 0;

                cartItem.OrderStatus = "Cancelled";

            }
            db.SaveChanges();

            return newCount;

        }


    }
}
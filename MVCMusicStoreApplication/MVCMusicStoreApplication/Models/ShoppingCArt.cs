using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStoreApplication.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId;

        private MVCMusicStoreDB db = new MVCMusicStoreDB();

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }

        private string GetCartId(HttpContextBase context)
        {
            const string CartSessionId = "CartId";
            String cartId;

            if (context.Session[CartSessionId] == null)
            {
                //If not exist
                //create new CartId
                cartId = Guid.NewGuid().ToString();

                context.Session[CartSessionId] = cartId;
            }
            else
            {
                cartId = context.Session[CartSessionId].ToString();


                // If Exists 
                // Return CartId

            }

            return cartId;

        }

        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(c => c.CartId == this.ShoppingCartId).ToList();

        }

        public decimal GetCartTotal()
        {
            decimal? total = (from cartItem in db.Carts
                         where cartItem.CartId == this.ShoppingCartId
                         select cartItem.AlbumSelected.Price * (int?)cartItem.Count).Sum();

            /*
            if (total.HasValue)
            {
                return total.Value;

            }
            else
            {
                return decimal.Zero;
            }
            */


            // return total.HasValue ? total.Value : decimal.Zero;

            return total ?? decimal.Zero;
        }

        public void AddToCart(int albumId)
        {
            // TODO: Verify that the Album Id exists in the database.
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.ShoppingCartId && c.AlbumID == albumId);

            if (cartItem == null)
            {
                // Item is not in cart, add new item
                cartItem = new Cart()
                {
                    CartId = this.ShoppingCartId,
                    AlbumID = albumId,
                    Count = 1,
                    DateCreated = DateTime.Now

                };
                db.Carts.Add(cartItem);

            }
            else
            {
                // Item is already in cart, increase item count (quantity)
                cartItem.Count++;
            }

            db.SaveChanges();
        }

        public int RemoveFromCart(int recordId)
        {
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.ShoppingCartId && c.RecordId == recordId);
            if(cartItem == null)
            {
                throw new NullReferenceException();
            }

            int newCount;
            if(cartItem.Count > 1)
            {
                // the count > 1; decrease count
                cartItem.Count--;
                newCount = cartItem.Count;
            }
            else
            {
                // the count <= 0; remove item
                db.Carts.Remove(cartItem);
                newCount = 0;

            }
            db.SaveChanges();

            return newCount;
           
        }
    }

    

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BakeryManager.Models
{
    public class CartModel
    {
        public string InsertCart(Cart cart)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                db.Carts.Add(cart);
                db.SaveChanges();
                return cart.DatePurchased + " was successfully inserted.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }

        }

        public string UpdateCart(int id, Cart cart)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                Cart p = db.Carts.Find(id); // fetching the object from the db.

                p.ClientId = cart.ClientId;
                p.PId = cart.PId;
                p.Amount = cart.Amount;
                p.DatePurchased = cart.DatePurchased;
                p.IsInCart = cart.IsInCart;

                db.SaveChanges();
                return cart.DatePurchased + " was successfully updated.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }

        }

        public string DeleteCart(int id)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                Cart cart = db.Carts.Find(id); // fetching the object from the db.

                db.Carts.Attach(cart);
                db.Carts.Remove(cart);
                db.SaveChanges();

                return cart.DatePurchased + " was successfully deleted.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }

        }
    }
}
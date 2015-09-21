using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BakeryManager.Models
{
    public class ProductModel
    {
        public string InsertProduct(Product product)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                db.Products.Add(product);
                db.SaveChanges();
                return product.PName + " was successfully inserted.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
          
        }

        public string UpdateProduct(int id, Product product)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                Product p = db.Products.Find(id); // fetching the object from the db.

                p.PName = product.PName;
                p.TypeId = product.TypeId;
                p.Price = product.TypeId;
                p.Info = product.Info;
                p.Image = product.Image;

                db.SaveChanges();
                return product.PName + " was successfully updated.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
            
        }

        public string DeleteProduct(int id)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                Product product = db.Products.Find(id); // fetching the object from the db.

                db.Products.Attach(product);
                db.Products.Remove(product);
                db.SaveChanges();

                return product.PName + " was successfully deleted.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
  
        }

        public Product GetProduct(int id)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                Product product = db.Products.Find(id);
                return product;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                List<Product> products = (from x in db.Products select x).ToList();
                return products;
            }
            catch (Exception)
            {
                return null;
               
            }
        }

        public List<Product> GetProductsByType(int typeId)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                List<Product> products = (from x in db.Products where x.TypeId == typeId select x).ToList();
                return products;
            }
            catch (Exception)
            {
                return null;
                
            }
        }
    }
}
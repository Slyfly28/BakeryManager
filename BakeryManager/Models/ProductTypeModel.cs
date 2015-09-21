using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BakeryManager.Models
{
    public class ProductTypeTypeModel
    {
        public string InsertProductType(ProductType productType)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                db.ProductTypes.Add(productType);
                db.SaveChanges();
                return productType.TName + " was successfully inserted.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }

        }

        public string UpdateProductType(int id, ProductType productType)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                ProductType p = db.ProductTypes.Find(id); // fetching the object from the db.

                p.TName = productType.TName;

                db.SaveChanges();
                return productType.TName + " was successfully updated.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }

        }

        public string DeleteProductType(int id)
        {
            try
            {
                BakeryDBEntities db = new BakeryDBEntities();
                ProductType productType = db.ProductTypes.Find(id); // fetching the object from the db.

                db.ProductTypes.Attach(productType);
                db.ProductTypes.Remove(productType);
                db.SaveChanges();

                return productType.TName + " was successfully deleted.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }

        }
    }
}
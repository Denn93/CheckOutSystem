using MyWCFService.ProjectEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFService.ProjectLogic
{
    public class ProductLogic 
    {
        public ProductEntity GetProduct(int id)
        {
          ProductEntity p = new ProductEntity();
          p.ProductID = id;
          p.ProductName = "fake product name from business logic layer";
          p.UnitPrice = (decimal)20.0;
          if(id > 50) p.UnitsOnOrder = 30;
            return p;
        }

        public bool UpdateProduct(ProductEntity product)
        {
          if (product.UnitPrice <= 0)
            return false;
          else if (product.ProductName == null || product.
                   ProductName.Length == 0)
            return false;
          else if (product.QuantityPerUnit == null || product.
                   QuantityPerUnit.Length == 0)
            return false;
          else
          {
            ProductEntity productInDB = GetProduct(product.ProductID);
            if (productInDB == null)
              return false;
           else if (product.Discontinued == true && productInDB.
                     UnitsOnOrder > 0)
             return false;
           else
             return true;
          }
        }
    }
}

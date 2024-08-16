using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using back.Models;
using back.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text.Json.Nodes;
using System.Text.Json;

namespace back.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {



        [HttpGet("{id}")]
        public Product? GetProduct(int id)
        {
            using (var context = new ProductTrialFeatContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == id);
            }

        }
        [HttpGet]
        public Product[] GetProducts()
        {
            using (var context = new ProductTrialFeatContext())
            {
                return context.Products.ToArray();
            }
        }
        [HttpPost]
        public Product PostProduct(Product product)
        {
            using (var context = new ProductTrialFeatContext())
            {
                product.Id = null;
                context.Products.Add(product).GetDatabaseValues();
                context.SaveChanges();
                return product;
            }
        }
        [HttpPatch("{id}")]
        public ActionResult<Product> PatchProduct(Product product, int id)
        {
          
            using (var context = new ProductTrialFeatContext())
            {
                var toUpdate = context.Products.FirstOrDefault(p => p.Id == id);
                
                if (toUpdate==null)
                {
                    return NotFound();
                }
                //idée pour le update : créer une focntion qui prends en parametre le body en json et la variable toUpdate, et met à jour uniquement les éléments renseignés
                toUpdate.InventoryStatus = product.InventoryStatus;
                toUpdate.Name = product.Name;  
                toUpdate.Description = product.Description;
                toUpdate.Price = product.Price;
                toUpdate.Quantity = product.Quantity;
                toUpdate.Rating = product.Rating;
                toUpdate.Category = product.Category;
                toUpdate.Code = product.Code;
                toUpdate.Image = product.Image;
                context.Products.Update(toUpdate);
                context.SaveChanges();
                return toUpdate;
            }
        }
        [HttpDelete("{id}")]
        public Product? DeleteProduct(int id)
        {
            using (var context = new ProductTrialFeatContext())
            {
                var toDel = context.Products.FirstOrDefault(p => p.Id == id);
                if (toDel != null)
                {
                    context.Products.Remove(toDel);
                    context.SaveChanges();
                }
                return toDel;
            }
        }
      
      
    }
}

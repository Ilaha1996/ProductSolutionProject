using PoductCore.Models;
using ProductBusiness.Services.DTOs;
using ProductBusiness.Services.Interfaces;
using ProductData.DAL;

namespace ProductBusiness.Services.Implementations
{
    public class PruductSevicesImp : IProduct
    {
        public void Create(ProductCreateDTO productCreateDTO)
        {
            ProductDataBase.Products.Add(new Product(productCreateDTO.Name,productCreateDTO.CostPrice,productCreateDTO.SalePrice)); 
        }

        public void Delete(int id)
        {
            ProductDataBase.Products.Remove(ProductDataBase.Products.Find(x => x.Id == id));
        }

        public ProductGetDTO Get(int id)
        {
            var wantedproduct = ProductDataBase.Products.Find(x => x.Id == id);
            return new ProductGetDTO(wantedproduct.Id, wantedproduct.Name, wantedproduct.SalePrice);
        }

        public List<ProductGetDTO> GetAll()
        {
            List<ProductGetDTO> wantedproducts = new List<ProductGetDTO>();

            foreach (var product in ProductDataBase.Products) 
            {
                var myProductDTO = new ProductGetDTO(product.Id, product.Name, product.SalePrice);
                wantedproducts.Add(myProductDTO);
            }
            return wantedproducts;
        }
    }
}

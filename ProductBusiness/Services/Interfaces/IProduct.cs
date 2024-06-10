using ProductBusiness.Services.DTOs;

namespace ProductBusiness.Services.Interfaces
{
    public interface IProduct
    {
        public void Create(ProductCreateDTO productCreateDTO);
        public ProductGetDTO Get(int id);
        public List<ProductGetDTO> GetAll();
        public void Delete(int id);
    }
}

using GenericRepository.Entities;
using GenericRepository.Models;

namespace GenericRepository.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetList();
        Task<Product> GetProduct(int Id);
        Task<int> AddProduct(ProductModel Productmodel);
        Task<int> UpdateProduct(ProductModel Productmodel);
        Task<int> DeleteProduct(int Id);
    }
}

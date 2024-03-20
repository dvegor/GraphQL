using Seminar3.Contracts.Requests.Products;
using Seminar3.Contracts.Responses;

namespace Seminar3.Abstractions
{
    public interface IProductServices
    {
            public int AddProduct(ProductCreateRequest product);
            public IEnumerable<ProductResponse> GetProducts();

            public ProductResponse GetProductById(int id);
            public bool DeleteProduct(int id);
            public bool UpdatePrice(int idProduct, int price);
            public bool DeleteCategory(string category);

    }
}

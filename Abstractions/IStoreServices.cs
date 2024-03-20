using Seminar3.Contracts.Requests;
using Seminar3.Contracts.Requests.Products;
using Seminar3.Contracts.Responses;

namespace Seminar3.Abstractions
{
    public interface IStoreServices
    {
        int AddStore(StoreCreateRequest CreateStoreRequest);
       
        IEnumerable<ProductResponse> GetProductsInStore(int id);
        
        int GetCountInStore(int id);

    }
}

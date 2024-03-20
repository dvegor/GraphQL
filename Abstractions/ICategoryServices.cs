using Seminar3.Contracts.Requests.Categories;
using Seminar3.Contracts.Responses;

namespace Seminar3.Abstractions
{
    public interface ICategoryServices
    {
        public int AddCategory(CategoryCreateRequest category);
        
        public IEnumerable<CategoryResponse> GetCategories();
        
        public CategoryResponse GetCategoryById(int id);

    }
}

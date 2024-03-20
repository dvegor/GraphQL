using Seminar3.Abstractions;
using Seminar3.Contexts;
using Seminar3.Contracts.Requests.Categories;
using Seminar3.Contracts.Responses;
using Seminar3.Models;
using AutoMapper;


namespace Seminar3.Services
{
    public class CategoryService : ICategoryServices
    {
        private readonly IMapper _mapper;
        private readonly StoreContext _storeContext;

        public CategoryService(StoreContext storeContext, IMapper mapper)
        {
            _storeContext = storeContext;
            _mapper = mapper;
        }
        public int AddCategory(CategoryCreateRequest createCategoryRequest)
        {
            var mapEntity = _mapper.Map<Category>(createCategoryRequest);
            _storeContext.Categories.Add(mapEntity);
            _storeContext.SaveChanges();

            return mapEntity.Id;
        }

        public IEnumerable<CategoryResponse> GetCategories()
        {
            IEnumerable<CategoryResponse> products = _storeContext.Categories.Select(_mapper.Map<CategoryResponse>);

            return products;
        }

        public CategoryResponse GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

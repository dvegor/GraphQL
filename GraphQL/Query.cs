﻿using Seminar3.Abstractions;
using Seminar3.Contracts.Responses;
using Seminar3.Services;

namespace Seminar3.GraphQL
{
    public class Query
    {
        private readonly IProductServices _productService;
        private readonly ICategoryServices _categoryService;
        private readonly IStoreServices _storeService;

        public Query(IProductServices productSrevice, ICategoryServices categoryService, IStoreServices storeService)
        {
            _productService = productSrevice;

            _categoryService = categoryService;

            _storeService = storeService;
        }
        public IEnumerable<CategoryResponse> GetCategories() => _categoryService.GetCategories();
        
        public IEnumerable<ProductResponse> GetProducts() => _productService.GetProducts();
       
        public ProductResponse GetProductById(int id) => _productService.GetProductById(id);
       
        public IEnumerable<ProductResponse> GetProductsInStore(int id) => _storeService.GetProductsInStore(id);
       
        public int GetCountInStore(int id) => _storeService.GetCountInStore(id);

    }
}

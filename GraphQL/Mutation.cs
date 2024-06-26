﻿using Seminar3.Abstractions;
using Seminar3.Contracts.Requests;
using Seminar3.Contracts.Requests.Categories;
using Seminar3.Contracts.Requests.Products;
using Seminar3.Services;

namespace Seminar3.GraphQL
{
    public class Mutation
    {
        private readonly IProductServices _productService;
        private readonly ICategoryServices _categoryService;
        private readonly IStoreServices _storeService;
       
        public Mutation(IProductServices productService, ICategoryServices categoryService, IStoreServices storeService)
        {
            _productService = productService;

            _categoryService = categoryService;

            _storeService = storeService;
        }

        public int AddProduct(ProductCreateRequest input) => _productService.AddProduct(input);
       
        public bool DeleteProduct(int id) => _productService.DeleteProduct(id);
        
        public bool UpdatePrice(int id, int price) => _productService.UpdatePrice(id, price);

        public int AddCategory(CategoryCreateRequest createCategoryRequest) => _categoryService.AddCategory(createCategoryRequest);

        public int AddStore(StoreCreateRequest storeCreate) => _storeService.AddStore(storeCreate);
    }
}

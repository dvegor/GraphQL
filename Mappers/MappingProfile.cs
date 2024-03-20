using Seminar3.Contracts.Requests;
using Seminar3.Contracts.Requests.Categories;
using Seminar3.Contracts.Requests.Products;
using Seminar3.Contracts.Responses;
using Seminar3.Models;
using AutoMapper;


namespace ApiAppLesson3Market.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductResponse>(MemberList.Destination).ReverseMap();

            CreateMap<Product, ProductCreateRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Product, ProductDeleteRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Product, ProductUpdateRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Category, CategoryCreateRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Category, CategoryResponse>(MemberList.Destination).ReverseMap();

            CreateMap<Store, StoreCreateRequest>(MemberList.Destination).ReverseMap();

            CreateMap<Store, StoreResponse>(MemberList.Destination).ReverseMap();
        }
    }
}

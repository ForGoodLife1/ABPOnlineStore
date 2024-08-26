using ABPCourse.Demo1.Products;
using ABPOnlineStore.Products;
using AutoMapper;

namespace ABPCourse.Demo1.Mappings
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<CreateUpdateProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}
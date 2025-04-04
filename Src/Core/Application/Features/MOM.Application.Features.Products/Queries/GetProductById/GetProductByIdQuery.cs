using MediatR;
using MOM.Application.DTOs.Products;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}

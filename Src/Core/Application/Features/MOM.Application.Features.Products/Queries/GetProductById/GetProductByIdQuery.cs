using MediatR;
using MOM.Application.Wrappers;
using MOM.Domain.Products.DTOs;

namespace MOM.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}

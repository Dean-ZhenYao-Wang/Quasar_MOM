using MediatR;
using MOM.Application.Wrappers;
using MOM.Domain.Products.DTOs;

namespace MOM.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string? Name { get; set; }
    }
}

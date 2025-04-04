using MediatR;
using MOM.Application.DTOs.Products;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string? Name { get; set; }
    }
}

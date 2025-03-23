using System.Threading.Tasks;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Features.Products.Commands.CreateProduct;
using MOM.Application.Features.Products.Commands.DeleteProduct;
using MOM.Application.Features.Products.Commands.UpdateProduct;
using MOM.Application.Features.Products.Queries.GetPagedListProduct;
using MOM.Application.Features.Products.Queries.GetProductById;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;
using MOM.Domain.Products.DTOs;

namespace MOM.Apps.Prodcut.Controllers
{
    [ApiVersion("1")]
    public class ProductController : BaseApiController
    {

        [HttpGet]
        public async Task<PagedResponse<ProductDto>> GetPagedListProduct([FromQuery] GetPagedListProductQuery model)
            => await Mediator.Send(model);

        [HttpGet]
        public async Task<BaseResult<ProductDto>> GetProductById([FromQuery] GetProductByIdQuery model)
            => await Mediator.Send(model);

        [HttpPost, Authorize]
        public async Task<BaseResult<Guid>> CreateProduct(CreateProductCommand model)
            => await Mediator.Send(model);

        [HttpPut, Authorize]
        public async Task<BaseResult> UpdateProduct(UpdateProductCommand model)
            => await Mediator.Send(model);

        [HttpDelete, Authorize]
        public async Task<BaseResult> DeleteProduct([FromQuery] DeleteProductCommand model)
            => await Mediator.Send(model);

    }
}

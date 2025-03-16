using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<BaseResult<string>>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string BarCode { get; set; }
    }
}

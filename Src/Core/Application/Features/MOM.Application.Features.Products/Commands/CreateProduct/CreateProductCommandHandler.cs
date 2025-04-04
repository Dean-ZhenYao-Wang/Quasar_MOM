using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Products;

namespace MOM.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, BaseResult<Guid>>
    {
        public async Task<BaseResult<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price, request.BarCode);

            await productRepository.AddAsync(product);
            await unitOfWork.SaveChangesAsync();

            return product.DtId;
        }
    }
}

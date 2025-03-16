using System.Threading.Tasks;
using MOM.Application.DTOs;
using MOM.Application.Wrappers;
using MOM.Domain.Products.DTOs;
using MOM.Domain.Products.Entities;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string? name);
    }
}

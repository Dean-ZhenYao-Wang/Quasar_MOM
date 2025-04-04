using System.Threading.Tasks;
using MOM.Application.DTOs;
using MOM.Application.DTOs.Products;
using MOM.Application.Wrappers;
using MOM.Domain.Products;

namespace MOM.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string? name);
    }
}

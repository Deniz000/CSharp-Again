using CSharpEgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEgitimKampi501.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);

        Task DeleteProductAsync(int productId);
        Task<ResultProductDto> GetByProductAsync(int id);
    }
}

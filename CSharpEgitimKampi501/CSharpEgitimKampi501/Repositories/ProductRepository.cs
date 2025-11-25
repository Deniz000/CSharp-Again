using CSharpEgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEgitimKampi501.Repositories
{
    public class ProductRepositoryÇ : IProductRepository
    {
        public Task CreateProductAsync(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultProductDto> GetByProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}

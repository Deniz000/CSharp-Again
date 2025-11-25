using EntityLayer.Concrete;
using EntityLayer.DtoLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<ProductWithCategoryDto> GetProductsWithCategory();
        
    }
}

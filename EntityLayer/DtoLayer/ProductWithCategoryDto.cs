using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DtoLayer
{
        public class ProductWithCategoryDto
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductDescription { get; set; }
            public decimal ProductPrice { get; set; }
            public int ProductStock { get; set; }
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }

}

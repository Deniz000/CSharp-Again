using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEgitimKampi501.Dtos
{
    //sql den tablonun propertelerini alırız
    public class ResultProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCategory { get; set; }
    }
}

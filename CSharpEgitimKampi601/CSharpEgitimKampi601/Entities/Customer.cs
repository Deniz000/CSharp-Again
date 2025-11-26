using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Driver => “C# kodun ile MongoDB server arasında köprü olan kütüphane.”
namespace CSharpEgitimKampi601.Entities
{
    public class Customer
    {
        //mongodbde ıd ler string tutuluyormuş ayrıca BsonId de dokümanın benzersiz atadığı ıd 
        [BsonId]   //-> “Kardeşim, bu sınıfın ID alanı budur. MongoDB’deki _id alanı bu property’e maplenecek.”
        [BsonRepresentation(BsonType.ObjectId)]  // “DB’de bu alan ObjectId ama C# tarafında **string olarak tut beni, convert işini sen hallet.”
        public string CustomerId { get; set; } /**Veriyi çekerken: ObjectId → string olarak çeviriyor.
        Veriyi kaydederken: string → ObjectId olarak çeviriyor.
        Sen ise her yerde sadece string kullanarak rahat ediyorsun.
        Eğer [BsonRepresentation(BsonType.ObjectId)] yazmazsan, CustomerId tipini genelde ObjectId yapman gerekir:**/
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerCity { get; set; }
        public decimal CustomerBalance { get; set; }
        public int CustomerShoppingCount { get; set; }

    }
}

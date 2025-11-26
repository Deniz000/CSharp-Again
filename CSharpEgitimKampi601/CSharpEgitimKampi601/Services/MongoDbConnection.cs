using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class MongoDbConnection
    {
        private IMongoDatabase _database;
        public MongoDbConnection()
        {
            var client = new MongoClient("mongodb://localhost:27017/"); //driver ın bağlantı cümlesi
            //➜ Sadece MongoDB’ye bağlanmak için bir client objesi oluşturur.
            _database = client.GetDatabase("Db601customer"); //şu an bu db yok, içerde yazan db yi bana oluştur diyoruz 
                                                             //➜ Bu da sana o isimdeki database’e erişim nesnesi verir.
                                                             //Bu satır “database oluştur” demek değildir.
                                                             //Daha çok: “Şu isimli database’le çalışacağım” diye bir handle alıyorsun.
                                                             //Mongo server her seferinde aynı isimde database handle’ını verir,
                                                             //DB’yi tekrar tekrar oluşturmaya kalkmaz,
                                                             // “Var olan DB ile çalışıyoruz” gibi davranır.
        }

        //bu metot benim tablomu temsil edecek. ben bu yapıyı - metodu kullanarak bağlanacam tablom
        public IMongoCollection<BsonDocument> GetCustomerCollection()
        {
            return _database.GetCollection<BsonDocument>("Customers");
        }
    }
}

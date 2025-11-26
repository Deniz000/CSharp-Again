using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations
    {
        private IMongoCollection<BsonDocument> _collection;

        public CustomerOperations()
        {
            MongoDbConnection connection = new MongoDbConnection();// veritabanına bağlantı kurdum, nesne aldım
            _collection = connection.GetCustomerCollection(); // tabloya bağlantı hazırladım / kurdum

        }

        public void AddCustomer(Customer customer)
        {

            var document = new BsonDocument
            {
                { "CustomerFirstName", customer.CustomerFirstName },
                { "CustomerLastName", customer.CustomerLastName },
                { "CustomerCity", customer.CustomerCity },
                { "CustomerBalance", customer.CustomerBalance },
                { "CustomerShoppingCount", customer.CustomerShoppingCount }
            };

            _collection.InsertOne(document); // ekleme işlemi
        }
        public List<Customer> GetAllCustomers()
        {
            var documents = _collection.Find(new BsonDocument()).ToList(); // yeni bir doköüman oluşturuyorum ve tüm kayıtları çekiyorum
            List<Customer> customers = new List<Customer>(); //boş bir müşteri listesi oluşturdum, bunu içine bulduklarımı yazacam
            foreach (var document in documents)
            {   //dokumanın içerisinde bulduğumuz her nesneyi müşteri listesine ekliyoruz
                //maping yani, yapmazsak Mongo’ya bağımlı hale gelir (her yerde BsonDocument tipi dolaşıyor).
                //Her yerde Convert.To... uğraşırsın.
                //Tip güvenliğin yok: document["CustomerBalance"] aslında decimal mi, string mi, int mi?
                customers.Add(new Customer
                {
                    CustomerId = document["_id"].ToString(),
                    CustomerFirstName = document["CustomerFirstName"].ToString(),
                    CustomerLastName = document["CustomerLastName"].ToString(),
                    CustomerCity = document["CustomerCity"].ToString(),
                    CustomerBalance = Convert.ToDecimal(document["CustomerBalance"]),
                    CustomerShoppingCount = Convert.ToInt32(document["CustomerShoppingCount"])
                });
            }
            /**
             * ŞU HALİ DAHA KISA AMA SEN ANLAMADIĞIN İÇİN YUKARIDAKİ GİBİ YAZ 
             * var collection = database.GetCollection<Customer>("Customers");
                var customers = collection.Find(Builders<Customer>.Filter.Empty).ToList();
                return customers;
                **/
            return customers; //müşteri listesini döndürüyorum
        }
        public void DeleteCustomer(string customerId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customerId));
            _collection.DeleteOne(filter);
        }
        public void UpdateCustomer(string customerId, Customer updatedCustomer)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customerId));
            var update = Builders<BsonDocument>.Update
                .Set("CustomerFirstName", updatedCustomer.CustomerFirstName)
                .Set("CustomerLastName", updatedCustomer.CustomerLastName)
                .Set("CustomerCity", updatedCustomer.CustomerCity)
                .Set("CustomerBalance", updatedCustomer.CustomerBalance)
                .Set("CustomerShoppingCount", updatedCustomer.CustomerShoppingCount);
            _collection.UpdateOne(filter, update);
        }
        public Customer GetCustomerById(string customerId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customerId));
            var document = _collection.Find(filter).FirstOrDefault();
            if (document != null)
            {
                return new Customer
                {
                    CustomerId = document["_id"].ToString(),
                    CustomerFirstName = document["CustomerFirstName"].ToString(),
                    CustomerLastName = document["CustomerLastName"].ToString(),
                    CustomerCity = document["CustomerCity"].ToString(),
                    CustomerBalance = Convert.ToDecimal(document["CustomerBalance"]),
                    CustomerShoppingCount = Convert.ToInt32(document["CustomerShoppingCount"])
                };
            }
            return null;
        }
    }
}
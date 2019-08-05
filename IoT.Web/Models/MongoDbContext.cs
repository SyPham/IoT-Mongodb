using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoT.Web.Models
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _mongoDb;
        public MongoDbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDb = client.GetDatabase("IoT");
        }
        public IMongoCollection<Employee> Employee
        {
            get
            {
                return _mongoDb.GetCollection<Employee>("Employee");
            }
        }
    }
}
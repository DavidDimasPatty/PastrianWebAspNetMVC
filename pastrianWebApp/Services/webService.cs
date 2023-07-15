using MongoDB.Driver;
using pastrianWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
namespace pastrianWebApp.Services
{
    public class webService 
    {
        private readonly IMongoCollection<user> _users;
        private const string _collectionName = "user";
        //Contains
        //all documents inside the collection
        public webService()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MongoDBConnection"].ConnectionString;
            string databaseName = ConfigurationManager.AppSettings["MongoDBDatabaseName"];
            webStoreDatabaseSettings webStoreSettings = new webStoreDatabaseSettings(connectionString, databaseName);
            this._users = webStoreSettings.Db.GetCollection<user>(_collectionName);
        }

    
        public user Create(user user)
        {
            _users.InsertOne(user);
            return user;
        }

        public List<user> Get()
        {
            return _users.Find(user => true).ToList();
        }

        public user Get(string id)
        {
            return _users.Find(user => user.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _users.DeleteOne(user => user.Id == id);
        }

        public void Update(string id, user user)
        {
            _users.ReplaceOne(users => users.Id == id, user);
        }
    }
}
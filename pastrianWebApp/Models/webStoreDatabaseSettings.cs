using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pastrianWebApp.Models
{
    public class webStoreDatabaseSettings 
    {
        public MongoClient Client;
        public IMongoDatabase Db;
    
        public webStoreDatabaseSettings(string url, string database)
        {
            this.Client = new MongoClient(url);
            //if the database is not exist, creates the database
            this.Db = this.Client.GetDatabase(database);
        }

    }
}
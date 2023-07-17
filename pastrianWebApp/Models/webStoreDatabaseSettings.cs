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
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;


        public webStoreDatabaseSettings(string connectionString, string databaseName)
        {
            this.ConnectionString = connectionString;
            this.DatabaseName = databaseName;
            this.Client = new MongoClient(connectionString);
            //if the database is not exist, creates the database
            this.Db = this.Client.GetDatabase(databaseName);

        }

        
    }

    

}
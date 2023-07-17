using MongoDB.Driver.Core.Configuration;
using pastrianWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace pastrianWebApp.Services
{
    public class webServiceGeneral
    {
        public string connectionString;
        public string databaseName;
        public webStoreDatabaseSettings webStoreSettings;

        public webServiceGeneral()
        {
             this.connectionString = ConfigurationManager.ConnectionStrings["MongoDBConnection"].ConnectionString;
             this.databaseName = ConfigurationManager.AppSettings["MongoDBDatabaseName"];
             this.webStoreSettings = new webStoreDatabaseSettings(connectionString, databaseName);
           
        }


    }
}
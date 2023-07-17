using Microsoft.Ajax.Utilities;
using MongoDB.Driver;
using pastrianWebApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

namespace pastrianWebApp.Services
{
    public class webServiceUser : webServiceGeneral
    {
        private  IMongoCollection<user> _users;

        public webServiceUser()
        {
            this._users = webStoreSettings.Db.GetCollection<user>("user");
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
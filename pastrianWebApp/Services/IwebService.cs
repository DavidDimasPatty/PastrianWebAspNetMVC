using pastrianWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pastrianWebApp.Services
{
    public interface IwebService
    {
        List<user> Get();
        user Get(string id);

        user Create(user user);

        void Update(string id, user user);

        void Remove(string id);
    }
}
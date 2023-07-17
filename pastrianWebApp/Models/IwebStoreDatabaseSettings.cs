using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pastrianWebApp.Models
{
    public interface IwebStoreDatabaseSettings
    {

        string ConnectionString { get; set; }

        string DatabaseName { get; set; }
    }
}
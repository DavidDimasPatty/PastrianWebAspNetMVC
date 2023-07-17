using Amazon.Runtime.Internal;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using pastrianWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace pastrianWebApp.Services
{
    public class webServiceAPIAlkitab 
    {
     
       
        public async Task<string> Get()
        {

            var connectionString = ConfigurationManager.ConnectionStrings["APIalkitab"].ConnectionString;
            using (HttpClient client = new HttpClient())
            {
              
                    // URL API yang akan diakses
                    string apiUrl = connectionString;

                    // Mengirim permintaan GET ke API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Memastikan permintaan berhasil (kode status 200)
                    response.EnsureSuccessStatusCode();

                    // Membaca respon JSON sebagai string
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;

               
            }
        }
    }
}
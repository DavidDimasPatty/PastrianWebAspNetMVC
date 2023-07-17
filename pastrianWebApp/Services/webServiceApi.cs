using Microsoft.Ajax.Utilities;
using MongoDB.Driver.Core.Configuration;
using pastrianWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace pastrianWebApp.Services
{
    public class webServiceApi
    {
        public HttpResponseMessage response;
      
    
        public  async void Connection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["APIalkitab"].ConnectionString;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // URL API yang akan diakses
                    string apiUrl = connectionString;

                    // Mengirim permintaan GET ke API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Memastikan permintaan berhasil (kode status 200)
                    response.EnsureSuccessStatusCode();

                    // Membaca respon JSON sebagai string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Menggunakan respons JSON sesuai kebutuhan Anda
                    Console.WriteLine(responseBody);
                }
                catch (HttpRequestException ex)
                {
                    // Penanganan kesalahan saat melakukan permintaan
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }
}
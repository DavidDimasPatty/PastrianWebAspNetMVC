using Newtonsoft.Json;
using pastrianWebApp.Models;
using pastrianWebApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace pastrianWebApp.Controllers
{
    public class AlkitabController : Controller
    {

        private webServiceAPIAlkitab _webService = new webServiceAPIAlkitab();
        private List<alkitab> _alkitab = new List<alkitab>();

        [HttpGet]
        public async Task<ActionResult> Alkitab()
        {
            string responseBody = await _webService.Get();
            dynamic obj = JsonConvert.DeserializeObject(responseBody);
            foreach (var i in obj["data"]["verses"])
            {
                string verse = i["verse"];
                string type = i["type"];
                string content = i["content"];
                this._alkitab.Add(new alkitab(verse, type, content));
            }
            return View(_alkitab);
        }
    }
}
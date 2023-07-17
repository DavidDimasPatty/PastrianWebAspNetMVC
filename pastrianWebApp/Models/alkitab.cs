using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pastrianWebApp.Models
{
    public class alkitab
    {
        public string chapter { get; set; }
        public string ayat { get; set; }
        public string isi { get; set; }
        public  alkitab(string chapters,string ayats,string isis) {
            this.chapter = chapters;
            this.ayat = ayats;
            this.isi = isis;
        }   
     
    }
}
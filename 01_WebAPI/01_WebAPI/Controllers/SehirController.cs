using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _01_WebAPI.Controllers
{
    [EnableCors("*","*","*")]
    public class SehirController : ApiController
    {
        //domainadresi/api/Sehir
        string[] sehirler = new string[] { "Ankara", "İstanbul", "Karaman" };
        public string[] Get()
        {
            return sehirler;
        }
        public string Get(int id)
        {
            return sehirler[id];
        }
    }
}

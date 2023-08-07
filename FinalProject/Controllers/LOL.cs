using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.IO;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject.Controllers
{
    public class LOL : Controller 
    {
        private readonly IConfiguration config;

        public LOL (IConfiguration configuration)
        {
            config = configuration;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var client = new RestClient("https://league-of-legends-galore.p.rapidapi.com/api/randomChamp");
            var request = new RestRequest();
            request.AddHeader("content-type", "application/octet-stream");
            request.AddHeader("X-RapidAPI-Key", config.GetConnectionString("AuthKey"));
            request.AddHeader("X-RapidAPI-Host", "league-of-legends-galore.p.rapidapi.com");
            var response = client.Execute(request).Content;
            var rootObject = JsonConvert.DeserializeObject<Root>(JArray.Parse(response)[0].ToString());
            return View(rootObject);

        }
    }
}


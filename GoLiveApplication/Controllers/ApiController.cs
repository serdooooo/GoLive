using GoLiveApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace GoLiveApplication.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public ActionResult Index()
        {
            var list = GetApiData();

            return View(list);
        }

        public List<GoLive> GetApiData()
        {
            GoLive gol = new GoLive();
            var apiUrl = "https://localhost:44354/api/GoLive";

            //Connect API
            Uri url = new Uri(apiUrl);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            string json = client.DownloadString(url);
            //END

            //JSON Parse START
            JavaScriptSerializer ser = new JavaScriptSerializer();
            List<GoLive> jsonList = ser.Deserialize<List<GoLive>>(json);
            //END
            return jsonList;
        }

    }
}
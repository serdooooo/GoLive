using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entity;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoLiveController : ControllerBase
    {
        private static List<GoLive> GoList = new List<GoLive>()
        {
            new GoLive(){ type= "T", name= "Ekip #44", mobile= "+90 5xx 11 11", pernr= "20190026", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc{ lat=39.768669,lng=30.507332} },
            new GoLive(){ type= "T", name= "Ekip #21", mobile= "+90 5xx 11 11", pernr= "20200034", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc{ lat= 39.769669, lng= 30.507332 } },
            new GoLive(){ type= "T", name= "Ekip #16", mobile= "+90 5xx 11 11", pernr= "20210004", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc{ lat= 39.790669, lng= 30.505332 }},
            new GoLive() { type= "T", name= "Ekip #35", mobile= "+90 5xx 11 11", pernr= "20190094", dep= "Bakım & Onarım Müdürlüğü", status= "Raporlu", loc= new Loc{ lat= 39.792669, lng= 30.507332 }},
            new GoLive() { type= "T", name= "Ekip #71", mobile= "+90 5xx 11 11", pernr= "20170019", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc{ lat= 39.771669, lng= 30.507332 }},
            new GoLive() { type= "T", name= "Ekip #39", mobile= "+90 5xx 11 11", pernr= "20100034", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc{ lat= 39.748669, lng= 30.507332 }},
            new GoLive() { type= "T", name= "Ekip #54", mobile= "+90 5xx 11 11", pernr= "20180037", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc{ lat= 39.749669, lng= 30.507332 }},
            new GoLive() { type= "V", name= "Servis Aracı #35", mobile= "", pernr= "V35", license_plate= "26 SBA 391", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc { lat= 39.767886, lng= 30.506046 }},
            new GoLive() { type= "V", name= "Servis Aracı #47", mobile= "", pernr= "V47", license_plate= "26 EB 1002", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc { lat= 39.773669, lng= 30.517332 }},
            new GoLive() { type= "V", name= "Servis Aracı #84", mobile= "", pernr= "V84", license_plate= "26 OED 87", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc { lat= 39.764858, lng= 30.502080 }},
            new GoLive() { type= "V", name= "Servis Aracı #12", mobile= "", pernr= "V12", license_plate= "26 SMG 551", dep= "Bakım & Onarım Müdürlüğü", status= "Arızalı", loc= new Loc { lat= 39.762669, lng= 30.525332 }},
            new GoLive() { type= "V", name= "Servis Aracı #76", mobile= "", pernr= "V76", license_plate= "26 SVB 77", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc { lat= 39.792643, lng= 30.504737 }},
            new GoLive() { type= "V", name= "Servis Aracı #22", mobile= "", pernr= "V22", license_plate= "26 FRR 631", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc { lat= 39.765769, lng= 30.524332 }},
            new GoLive() { type= "V", name= "Servis Aracı #39", mobile= "", pernr= "V39", license_plate= "26 UC 98", dep= "Bakım & Onarım Müdürlüğü", status= "Aktif", loc= new Loc { lat= 39.763869, lng= 30.521332 }}
        };
        // GET: api/<GoLiveController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(GoList);
        }
    }
}

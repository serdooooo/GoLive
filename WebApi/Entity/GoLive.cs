using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entity
{
    public class Loc
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class GoLive
    {
        public string type { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string pernr { get; set; }
        public string dep { get; set; }
        public string status { get; set; }
        public Loc  loc { get; set; }
        public string license_plate { get; set; }
    }

}

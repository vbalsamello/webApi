using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webApi.Models;

namespace webApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }


        // GET api/values
        [TokenAuthentication]
        [Route("api/Values/AllPrivate")]
        [HttpGet]
        public IEnumerable<string> All()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values
        [Route("api/Values/AllPublic")]
        [HttpGet]
        public IEnumerable<string> All2()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values
        [Route("api/Values/All/{valId}/Val")]
        [HttpGet]
        public IEnumerable<string> returnVal(string valId)
        {
            return new string[] { "value1"+ valId, "value2"+ valId };
        }

        // GET api/values
        [Route("api/Values/Val")]
        [HttpGet]
        public IEnumerable<string> returnVal2(string valId)
        {
            return new string[] { "value1" + valId, "value2" + valId };
        }

        
    }
}

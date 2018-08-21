using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
        [Route("api/Values/All")]
        [HttpGet]
        public IEnumerable<string> All()
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

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using WebApi.OutputCache.V2;

namespace ApiWithCache.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [CacheOutput(ServerTimeSpan = 120)]
        public IEnumerable<string> Get()
        {
            Thread.Sleep(20000);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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

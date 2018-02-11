using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestfulWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/Char")]
    public class CharController : Controller
    {
        // GET: api/Char
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Char/5
        [HttpGet("{id}/{name}", Name = "Get")]
        public string Get(int id, string name)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("id : {0}", id);
            sb.AppendLine();
            sb.AppendFormat("name : {0}", name);
            sb.AppendLine();

            var hostname = System.Net.Dns.GetHostName();
            var addrs = System.Net.Dns.GetHostAddresses(hostname);

            foreach (var item in addrs)
            {
                sb.AppendFormat("IP:{0}",item.ToString());
                sb.AppendLine();
            }

            return sb.ToString();
        }

        // POST: api/Char
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Char/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

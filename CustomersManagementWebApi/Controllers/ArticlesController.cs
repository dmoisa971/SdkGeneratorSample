using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomersManagementWebApi.Controllers
{
    public class ArticlesController : ApiController
    {
        // GET: api/Articles
        public IEnumerable<Article> Get()
        {
            var articles = new List<Article>();

            return articles;
        }

        // GET: api/Articles/5
        public Article GetById(int id)
        {
            return new Article();
        }

        // POST: api/Articles
        public void Post([FromBody]Article value)
        {
        }

        // PUT: api/Articles/5
        public void Put(int id, [FromBody]Article value)
        {
        }

        // DELETE: api/Articles/5
        public void Delete(int id)
        {
        }
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomersManagementWebApi.Controllers
{
    public class OrdersController : ApiController
    {
        // GET: api/Orders
        public IEnumerable<Order> Get()
        {
            var orders = new List<Order>();

            return orders;
        }

        // GET: api/Orders/5
        public Order GetById(int id)
        {
            return new Order();
        }

        // POST: api/Orders
        public void Post([FromBody]Order value)
        {
        }

        // PUT: api/Orders/5
        public void Put(int id, [FromBody]Order value)
        {
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
        }
    }
}

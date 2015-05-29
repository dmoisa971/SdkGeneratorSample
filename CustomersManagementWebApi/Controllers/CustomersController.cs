using AutoPoco;
using AutoPoco.Engine;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomersManagementWebApi.Controllers
{
    //[Authorize]
    public class CustomersController : ApiController
    {
        IGenerationSessionFactory factory = AutoPocoContainer.Configure(x =>
        {
            x.Conventions(c =>
            {
                c.UseDefaultConventions();
            });
            x.AddFromAssemblyContainingType<Customer>();
        });
        IGenerationSession session;
        List<Customer> customers;
        public CustomersController()
        {
            session = factory.CreateSession();

            customers = session.List<Customer>(80).First(20).Impose(c => c.Adresse, "Rue de la gloire").All().Get().ToList();
        }
        // GET api/values
        public IEnumerable<Customer> Get()
        {
            return customers;
        }

        // GET api/values/5
        public Customer GetById(int id)
        {
            return customers.Where(c => c.CustomerId.Equals(id)).FirstOrDefault();
        }

        // POST api/values
        public void Post([FromBody]Customer value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Customer value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

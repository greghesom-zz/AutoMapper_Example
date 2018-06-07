using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Core;
using API.Models;
using Swashbuckle.Swagger.Annotations;

namespace API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
     

            var person = new Person { Name = "John" };
            var customer = AutoMapper.Mapper.Map<Customer>(person);



            var dog = new Dog { Name = "Lucky" };
            var pet = AutoMapper.Mapper.Map<Pet>(dog);

            Console.WriteLine(customer.FirstName);
            // Output: Lackey
            return new string[] { "value1", "value2" };
        }

     
    }

   

}

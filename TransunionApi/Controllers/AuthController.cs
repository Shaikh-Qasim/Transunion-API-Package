using CC2Service;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TransunionApi.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly CC2Client _client;

        public AuthController(CC2Client client)
        {
            _client = client;
        }

        // GET: api/<controller>
        [HttpGet]
        public GetAuthenticationQuestionsResponse Get()
        {
            return _client.GetAuthenticationQuestionsAsync(new GetAuthenticationQuestionsRequest
            {
                AccountCode = "123456789",
                AccountName = "CC2PartnerTesting1",
                RequestKey = "12345676789089",
                ClientKey = "ND20111111-testauth",
                Customer = new Customer
                {
                    CurrentAddress = new Address
                    {
                        AddressLine1 = "2635 W EVERGREEN AV",
                        City = "VISALIA",
                        State = "IL",
                        Zipcode = "67450"
                    },
                    DateOfBirth = new DateTime(1957 - 09 - 01),
                    FullName = new Name
                    {
                        FirstName = "Anne",
                        LastName = "Test"
                    },
                    Ssn = "000000001"
                },
                ServiceBundleCode = "CC2PartnerTesting1Authentication"
            }).GetAwaiter().GetResult();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCVideo.Models;
using MVCVideo.Dtos;
using AutoMapper;

namespace MVCVideo.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private DatabaseContext _Context;

        public CustomersController()
        {
            _Context = new DatabaseContext();
        }
        // GET /api/customers
        public IEnumerable<CustomerDto> GetCustomers()
        {
            var customer = _Context.customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return customer;
        }

        // GET /api/customers/1
        public CustomerDto GetCustomer(int id)
        {
            var customer = _Context.customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Customer, CustomerDto>(customer);
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _Context.customers.Add(customer);
            _Context.SaveChanges();

            customerDto.Id = customer.Id; 
            return Created(new Uri(Request.RequestUri + "/" +customer.Id),customerDto);
        }

        // PUT /api/customers
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _Context.customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(customerDto, customerInDb);
            
            _Context.SaveChanges();

        }

        // DELETE api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _Context.customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _Context.customers.Remove(customerInDb);
            _Context.SaveChanges();

        }
    }
}

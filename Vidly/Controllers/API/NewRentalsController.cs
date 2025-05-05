using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using System.Data.Entity;
using AutoMapper;
using Vidly.Models.Dtos;

namespace Vidly.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            throw new NotImplementedException();
        }

        //public IHttpActionResult GetCustomer(int id)
        //{
        //    var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

        //    if (customer == null) 
        //        return NotFound();

        //    return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        //}
    }
}

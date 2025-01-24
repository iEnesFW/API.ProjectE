using Microsoft.AspNetCore.Mvc;
using ProjectE.Application.Interfaces;
using ProjectE.Domain.Entities;

namespace ProjectE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<Customer> _Customer;

        public CustomerController(IRepository<Customer> repository)
        {
            _Customer = repository;
        }

        [HttpGet("GetAllCustomers")]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _Customer.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("GetCustomerByID{id}")]
        public async Task<IActionResult> GetCustomerByID(int id)
        {
            var customer = await _Customer.GetByIdAsync(id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

        [HttpPost("AddCustomer")]
        public async Task<IActionResult> Add(Customer customer)
        {
            await _Customer.AddAsync(customer);
            return CreatedAtAction(nameof(GetCustomerByID), new { id = customer.CustomerID }, customer);
        }
    }
}

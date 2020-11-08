using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MahakPay.Data.DatabaseContext;
using MahakPay.Data.Infrastructure;
using MahakPay.Data.Models;
//using MahakPay.Data. ;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MahakPay.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork<MahakDbContext> _db;
        public ValuesController(IUnitOfWork<MahakDbContext> dbContext)
        {
            _db = dbContext;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            //return new string[] { "value1", "value2" };
            //var user = new User()
            //{
            //    Address = "",
            //    City = "",
            //    DateOfBirth = "",
            //    Gender = "",
            //    IsAcive = true,
            //    Name = "",

            //    PasswordHash = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, },
            //    PasswordSalt = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, },

            //    PhoneNumber = "",
            //    Status = true,
            //    UserName = ""
            //};

            //await _db.UserRepository.InsertAsync(user);
            //await _db.SaveAsync();

            //var model = await _db.UserRepository.GetAllAsync();
            return Ok("KAZEMI");
           
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<string> Post([FromBody] string value)
        {
            return null;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<string> Put(int id, [FromBody] string value)
        {
            return null;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return null;
        }
    }
}

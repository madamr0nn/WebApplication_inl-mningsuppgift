using Microsoft.AspNetCore.Mvc;
using WebApplication_inlämningsuppgift.Models;
using WebApplication_inlämningsuppgift.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication_inlämningsuppgift.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CustomerController : ControllerBase
    {
        private readonly IUserServices userServices;

       

        public CustomerController(IUserServices userServices)
        {
            this.userServices = userServices;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public  IEnumerable<User> GetAllUsersAsync()
        {
                           
                    return userServices.getuserasync();
                   //  return new OkObjectResult(await _productManager.GetAllProductsAsync());
                            
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]

        public async Task<IActionResult> Post(User user)
        {
            try
            {
                await userServices.createasync(user);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            userServices.DeleteUser(id);

        }
    }
}

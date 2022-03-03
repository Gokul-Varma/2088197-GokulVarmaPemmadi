using Handson03.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Handson03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {


        private readonly IRepository<Employee> productsRepository;


        public ValuesController(IRepository<Employee> productsRepository)
        {
            this.productsRepository = productsRepository;
        }


        [HttpGet]

        public IActionResult GetProducts()
        {
            var Products = productsRepository.Get();
            return Ok(Products);
        }

        [HttpGet("{id}")]

        public IActionResult GetProduct(int id)
        {
            var Products = productsRepository.Get(p=>p.Id==id);
            var Product = Products.FirstOrDefault();
            if(Product == null)
                return NotFound();
            return Ok(Product);


        }

        [HttpPost]
        public async Task<IActionResult> AddProducts(Employee model)
        {
            productsRepository.Add(model);
            int RowsAffected = await productsRepository.SaveAsync();
            if (RowsAffected == 1)
                return CreatedAtRoute(routeName: "GetProduct", routeValues: new { id = model.Id}, value: model);
            return BadRequest("add failed");

        }
        [HttpPut]
        public async Task<IActionResult> UpdateProducts(Employee model)
        { 
            productsRepository.Update(model);
            int RowsAffected = await productsRepository.SaveAsync();
            if(RowsAffected == 1)
                return Ok(model);
            return BadRequest("update failed");

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducts(int id)
        {
            var Products=productsRepository.Get(p=>p.Id==id);
            var Product=Products.FirstOrDefault();
            
            if (Product == null)
                return NotFound();
            productsRepository.Delete(Product);
            int RowsAffected = await productsRepository.SaveAsync();
            if(RowsAffected == 1)
                return NoContent();
            return BadRequest("delete failed");
        }
       

    }
}

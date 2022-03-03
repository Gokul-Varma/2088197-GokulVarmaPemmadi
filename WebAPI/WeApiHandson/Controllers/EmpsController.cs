using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Handson.Models;



namespace WebApi_Handson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : ControllerBase
    {

        List<Employee> emp;

        public EmpsController()
        {
            emp = new List<Employee>
            {
                new Employee
                {
                    Id=101,
                    Name="Naruto",
                    Salary=27000,
            Permanent=true
                },
                new Employee
                {

                    Id=102,
                    Name="Sasuke",
                    Salary=12000,
            Permanent=false

                }
            };
        }
        [HttpGet("GetStandard")]

        [ProducesResponseType(statusCode: 200)]

        public ActionResult<Employee> GetStandardEmployeeList()
        {
            return Ok(emp);
        }




        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            Employee em = null;
            foreach(var e in emp)
            {
                if (em.Id == id)
                {
                    em = e;

                }

            }

            return Ok(em);
        }






        // POST api/<EmpsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmpsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

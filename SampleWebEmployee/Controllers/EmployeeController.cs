using Microsoft.AspNetCore.Mvc;
using SampleWebAPIEmployee.Services;
using SampleWebEmployee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IEmployeeServices _Empservice;
        public ProductController(IEmployeeServices prodservice)
        {
            _Empservice = prodservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Product/GetProducts")]
        public IActionResult GetEmployee()
        {
            return new ObjectResult(_Empservice.GetAllEmployee());
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddEmployee(Employee prod)
        {
            return new ObjectResult(_Empservice.AddEmployee(prod));
        }

        [HttpPost]
        [Route("ModifyProduct")]
        public IActionResult ModifyEmployee(Employee prod)
        {
            return new ObjectResult(_Empservice.ModifyEmployee(prod));
        }

        [HttpGet]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            return new ObjectResult(_Empservice.DeleteEmployee(id));
        }
    }
}
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiRoutingDemo.Controllers
{
    //[Route("api/[controller]")]
    [Route("[Controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        //[Route("Emp/All")]
        //[Route("[Action]")]
        [HttpGet]
        public string Get()
        {
            return "Response from GetAllEmployees Method";
        }
        //[Route("Emp/ById")]
       // [Route("Emp/{id}")]
       [Route("{id:int:min(25)}")]
        [HttpGet]
        public string GetEmployeeById(int id)
        {
            return "Response from GetEmployeeById Method" +id;
        }

        [HttpGet]
       // [Route("Employee/Search")]
        //[Route("Employee/Gender/{gender}/City/{city}")]
        public string GetemployeeByGenderCity(string? gender,string? city)
        {
            return " This Employee Gender is " + gender + " From " + city;
        }

        [HttpGet]
        //[Route("allemployees")]
        //[Route("GetAllEmployees")]
        //[Route("Employees")]
        public string GetAllEmployee()
        {
            return " all Employee details available here";
        }

        [HttpGet]
        [Route("~/alldepartments")]
        public string GetAllDepartments()
        {
            return "Department details";
        }
    }
}

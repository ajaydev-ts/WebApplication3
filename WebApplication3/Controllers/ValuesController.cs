using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly SchooldbContext schooldbContext;  //object creation
        public ValuesController(SchooldbContext schooldbContext)  
        {
            this.schooldbContext = schooldbContext;
        }
        [HttpGet("getall")]
        public List<Student> get()
        {
            var data = this.schooldbContext.Students.ToList();
            return data;
        }
        [HttpPost("postall")]
        public string post(Student st)
        {
            this.schooldbContext.Add(st);
            this.schooldbContext.SaveChanges();
            return "Success";
        }
    }
}

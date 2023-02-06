using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OTO.Model;

namespace OTO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAddressController : ControllerBase
    {
        private readonly StdDbContext _db;

        public StudentAddressController(StdDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAlll()
        {
            try
            {
                var studentsAList = _db.StudentAddresses.ToList();


                return Ok(studentsAList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public IActionResult Create(StudentAddress student)
        {

            _db.StudentAddresses.Add(student);
            _db.SaveChanges();
            return Ok(student);
        }
    }
}

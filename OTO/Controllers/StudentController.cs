using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OTO.Model;

namespace OTO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly StdDbContext _db;
        private readonly IMapper _mapper;

        public StudentController(StdDbContext db , IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

      
        [HttpGet("hh")]
        public ActionResult<List<Student>>GetAlll()
        {
            return Ok(_db.Students.Select(std => _mapper.Map<Studentdto>(std)));
        }

        [HttpPost("kk")]

       
        public IActionResult Create(Studentdto student)
        {
            Student std = _mapper.Map<Student>(student);

            _db.Students.Add(std);
            _db.SaveChanges();
            return Ok(_db.Students.Select(std => _mapper.Map<Studentdto>(std)));
        }
    }
}

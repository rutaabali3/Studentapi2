using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentapi2.Data;
using Studentapi2.Models;

namespace Studentapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            var students = await _context.Students.ToListAsync();
            return Ok(students);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if(student == null)
                return NotFound ("NO STUDENT WITH THIS ID " + id);
            {
                return Ok(student);
            }
        }

        [HttpPost]

        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            _context.Students.Add(student);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateStudent(int id, Student student)
        {
            if(id != student.Id)
            {
                return BadRequest("The id in the URL doesnot match the ID in the body");
            }
            var existingStudent = await _context.Students.FindAsync(id);
            if (existingStudent == null)
        }
    }
}


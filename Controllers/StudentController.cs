using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using StudentManagementApi.Interfaces;
using StudentManagementApi.Models;


namespace StudentManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Studentcontroller : ControllerBase
    {
        private readonly IStudentService _service;

        public Studentcontroller(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var student = _service.GetById(id);
            return student == null ? NotFound() : Ok(student);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            var newStudent = _service.Create(student);
            return newStudent == null ? NotFound() : Ok(newStudent);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Student student)
        {
            if (id != student.ID) return BadRequest();

            _service.Update(student);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(_service.GetById(id));
            return NoContent();
        }
    }
}
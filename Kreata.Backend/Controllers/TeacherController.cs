using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;
using Kreta.Shared.Converters;
using Kreta.Shared.Dtos;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private ITeacherRepo _teacherRepo;
        public TeacherController(ITeacherRepo teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllTeacher()
        {
            List<Teacher> teachers = new List<Teacher>();
            if (_teacherRepo != null)
            {
                teachers = await _teacherRepo.GetAll();
                return Ok(teachers);
            }
            return BadRequest("Tanár adatok nem érhetõek el.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            Teacher? teacher = new();
            if (_teacherRepo is not null)
            {
                teacher = await _teacherRepo.GetBy(id);
                if (teacher != null)
                    return Ok(teacher);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateTeacherAsync(Teacher entity)
        {
            ControllerResponse response = new();
            if (_teacherRepo is not null)
            {
                response = await _teacherRepo.UpdateTeacherAsync(entity);
                if (response.HasError)
                {
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az adatok frissítés nem lehetséges!");
            return BadRequest(response);
        }
    }
}

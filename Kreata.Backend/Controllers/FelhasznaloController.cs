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
    public class FelhasznaloController : ControllerBase
    {
        private IFelhasznaloRepo _felhasznaloRepo;
        public FelhasznaloController(IFelhasznaloRepo felhasznaloRepo)
        {
            _felhasznaloRepo = felhasznaloRepo;
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllFelhasznalo()
        {
            List<Felhasznalo> felhasznalok = new List<Felhasznalo>();
            if (_felhasznaloRepo != null)
            {
                felhasznalok = await _felhasznaloRepo.GetAll();
                return Ok(felhasznalok);
            }
            return BadRequest("Felhasználó adatok nem érhetőek el.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            Felhasznalo? felhasznalo = new();
            if (_felhasznaloRepo is not null)
            {
                felhasznalo = await _felhasznaloRepo.GetBy(id);
                if (felhasznalo != null)
                    return Ok(felhasznalo);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateFelhasznaloAsync(Felhasznalo entity)
        {
            ControllerResponse response = new();
            if (_felhasznaloRepo is not null)
            {
                response = await _felhasznaloRepo.UpdateFelhasznaloAsync(entity);
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

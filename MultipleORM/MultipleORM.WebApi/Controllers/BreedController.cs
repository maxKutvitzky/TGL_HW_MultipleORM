using Microsoft.AspNetCore.Mvc;
using MultipleORM.Bll.Interfaces.Entities;
using MultipleORM.Bll.Interfaces.IServices;

namespace MultipleORM.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreedController : ControllerBase
    {
        private readonly IBreedService _breedService;
        public BreedController(IBreedService service)
        {
            _breedService = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_breedService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            BllBreed breed = _breedService.GetById(id);

            if (breed == null) return NotFound();

            return Ok(breed);
        }

        [HttpPost]
        public IActionResult Add(BllBreed breed)
        {
            try
            {
                _breedService.Add(breed);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(BllBreed breed, int id)
        {
            if (id != breed.Id) return BadRequest();
            try
            {
                _breedService.Update(breed);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return Ok(breed);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(BllBreed breed, int id)
        {
            if (id != breed.Id) return BadRequest();
            try
            {
                _breedService.Delete(breed);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}

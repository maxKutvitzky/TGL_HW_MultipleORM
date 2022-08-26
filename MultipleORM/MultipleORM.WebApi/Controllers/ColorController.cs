using Microsoft.AspNetCore.Mvc;
using MultipleORM.Bll.Interfaces.Entities;
using MultipleORM.Bll.Interfaces.IServices;
using MultipleORM.Bll.Interfaces.IServices.Base;

namespace MultipleORM.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IColorService _colorService;
        public ColorController(IColorService service)
        {
            _colorService = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_colorService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            BllColor entity = _colorService.GetById(id);

            if (entity == null) return NotFound();

            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Add(BllColor color)
        {
            try
            {
                _colorService.Add(color);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(BllColor color, int id)
        {
            if (id != color.Id) return BadRequest();
            try
            {
                _colorService.Update(color);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return Ok(color);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(BllColor color, int id)
        {
            if (id != color.Id) return BadRequest();
            try
            {
                _colorService.Delete(color);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}

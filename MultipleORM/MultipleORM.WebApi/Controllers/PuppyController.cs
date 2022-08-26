using Microsoft.AspNetCore.Mvc;
using MultipleORM.Bll.Interfaces.Entities;
using MultipleORM.Bll.Interfaces.IServices;

namespace MultipleORM.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PuppyController : ControllerBase
{
    private readonly IPuppyService _puppyService;

    public PuppyController(IPuppyService puppyService)
    {
        _puppyService = puppyService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_puppyService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        BllPuppy puppy = _puppyService.GetById(id);

        if (puppy == null) return NotFound();

        return Ok(puppy);
    }

    [HttpPost]
    public IActionResult Add(BllPuppy puppy)
    {
        try
        {
            _puppyService.Add(puppy);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }

        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Update(BllPuppy puppy, int id)
    {
        if (id != puppy.Id) return BadRequest();
        try
        {
            _puppyService.Update(puppy);
        }
        catch (Exception e)
        {
            return BadRequest();
        }

        return Ok(puppy);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(BllPuppy puppy, int id)
    {
        if (id != puppy.Id) return BadRequest();
        try
        {
            _puppyService.Delete(puppy);
        }
        catch (Exception e)
        {
            return BadRequest();
        }

        return Ok();
    }
}
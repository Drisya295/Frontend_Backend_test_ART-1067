using System.Threading.Tasks;
using System;

[ApiController]
[Route("api/[controller]")]
public class CafesController : ControllerBase
{
    private readonly ICafeService _cafeService;

    public CafesController(ICafeService cafeService)
    {
        _cafeService = cafeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCafes([FromQuery] string location = null)
    {
        var cafes = await _cafeService.GetCafes(location);
        return Ok(cafes);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCafe(Cafe cafe)
    {
        await _cafeService.CreateCafe(cafe);
        return CreatedAtAction(nameof(GetCafes), new { id = cafe.Id }, cafe);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCafe(Guid id, Cafe cafe)
    {
        if (id != cafe.Id)
            return BadRequest();

        await _cafeService.UpdateCafe(cafe);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCafe(Guid id)
    {
        await _cafeService.DeleteCafe(id);
        return NoContent();
    }
}


using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController: ControllerBase
{
    private static readonly List<Character> characters =
    [
        new(),
        new() { Id = 1, Name = "Sam" }
    ];

    [HttpGet("GetAll")]
    public ActionResult<List<Character>> Get()
    {
        return Ok(characters);
    }

    [HttpGet("{id}")]
    public ActionResult<Character> GetSingle(int id)
    {
        return Ok(characters.FirstOrDefault(c => c.Id == id));
    }
}

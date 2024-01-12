using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController: ControllerBase
{
    private static readonly List<Character> characters =
    [
        new(),
        new() { Name = "Sam" }
    ];

    [HttpGet("GetAll")]
    public ActionResult<List<Character>> Get()
    {
        return Ok(characters);
    }

    [HttpGet]
    public ActionResult<Character> GetSingle()
    {
        return Ok(characters[0]);
    }
}

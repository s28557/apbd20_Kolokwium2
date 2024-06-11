using Kol2.Services;
using Kol2.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Kol2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharactersController : ControllerBase
{
    private readonly IDbService _dbService;
    public CharactersController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    [HttpGet("{characterId}/characters")]
    public async Task<IActionResult> GetCharacterData(int characterId)
    {
        var characters = await _dbService.GetCharacterData(characterId);

        return Ok(characters.Select(e => new GetCharacterDTO()
        {
            Id = e.Id,
            FirstName = e.FirstName,
            LastName = e.LastName,
            CurrentWeight = e.CurrentWeight,
            MaxWeight = e.MaxWeight,
        }));
    }
}
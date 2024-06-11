using Kol2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kol2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemsController : ControllerBase
{
    private readonly IDbService _dbService;
    public ItemsController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    
}
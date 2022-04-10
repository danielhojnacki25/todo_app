using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        return null;
    }
}
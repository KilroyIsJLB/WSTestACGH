using Microsoft.AspNetCore.Mvc;
using WSTestACGH.Models;

namespace WSTestACGH.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemsController : ControllerBase
{
 
    [HttpGet]
    public ActionResult<List<Item>> GetAll()
    {
        return Enumerable.Range(1, 5).Select(index => new Item
        {
            Id = index,
            Description = $"Item{index}",
            Price = index * 100,

        }).ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Item> GetOne(int id)
    {
        if (id < 1 || id > 5)
        {
            return NotFound();
        }
        
        return new Item
        {
            Id = id,
            Description = $"Item{id}",
            Price = id * 100,

        };
    }
}
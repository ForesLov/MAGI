using MAGI.Models;
using MAGI.Persistece;
using Microsoft.AspNetCore.Mvc;

namespace MAGI.Controllers;

[ApiController]
[Route("[controller]")]
public class DatabasesController:ControllerBase
{
    private readonly ApplicationDBContext _context;

    public DatabasesController(ApplicationDBContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IEnumerable<Database> Databases()
    {
        //_context.ObservedDatabases.ToArray();
        return _context.ObservedDatabases.ToArray();
    }
    
}

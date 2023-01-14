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
    public IEnumerable<Database> GetAll()
    {
        //_context.ObservedDatabases.ToArray();
        return _context.ObservedDatabases.ToArray();
    }
    [HttpGet]
    public Database? GetDatabase(Guid id)
    {
        return _context.ObservedDatabases.FirstOrDefault(i => i.ID == id);
    }
    [HttpPost]
    public async Task<bool> AddDatabase([Bind("Name, ID")] Database database)
    {
        try
        {
            _context.ObservedDatabases.Add(database);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    [HttpPost]
    public async Task<bool> DeleteDatabase(Guid id)
    {
        try
        {
            var database = _context.ObservedDatabases.FirstOrDefault(i => i.ID == id);
            if (database is null) return false;
            _context.ObservedDatabases.Remove(database);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    [HttpPost]
    public async Task<bool> EditDatabasr([Bind ("Name, ID")]Database database)
    {
        try
        {
            _context.ObservedDatabases.Update(database);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
        
    }
}

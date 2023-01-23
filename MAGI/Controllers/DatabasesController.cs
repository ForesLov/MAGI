using MAGI.Models;
using MAGI.Persistece;
using Microsoft.AspNetCore.Mvc;

namespace MAGI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class DatabasesController : ControllerBase
{
    private readonly ApplicationDBContext _context;

    public DatabasesController(ApplicationDBContext context)
    {
        _context = context;
    }
    /// <summary>
    /// Возвращает все наблюдаемые базы данных.
    /// </summary>
    /// <returns><see cref="IEnumerable{T}"/> где T - это наблюдаемые базы данных.</returns>
    [HttpGet]
    public ActionResult<IEnumerable<Database>> GetAll()
    { 
        //_context.ObservedDatabases.ToArray();
        return Ok(_context.ObservedDatabases.ToArray());
    }
    /// <summary>
    /// Создаёт новую запись о наблюдаемой базе данных.
    /// </summary>
    /// <param name="database"> 
    /// Новый объект наблюдаемой базы данных.</param>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Database database)
    {
        _context.ObservedDatabases.Add(database);
        await _context.SaveChangesAsync();
        return Ok();
    }
    /// <summary>
    /// Возвращает наблюдаемую базу данных по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор базы данных.</param>
    /// <returns></returns>
    [HttpGet("{id}")] //TODO: доделать валидацию ID
    public ActionResult<Database?> Get(Guid id)
    {
        return Ok(_context.ObservedDatabases.FirstOrDefault(i => i.ID == id));
    }
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] Database database)
    {
        _context.ObservedDatabases.Update(database);
        await _context.SaveChangesAsync();
        return Ok();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var database = _context.ObservedDatabases.FirstOrDefault(i => i.ID == id);
        if (database is null) return NotFound();
        _context.ObservedDatabases.Remove(database);
        await _context.SaveChangesAsync();
        return Ok();
    }
}

using ContactsBook.Core.DataTransferObjects.Commands;
using ContactsBook.Core.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace ContactsBook.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase
{
    private readonly IContactManager _contactManager;

    public ContactController(IContactManager contactManager)
    {
        _contactManager = contactManager;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _contactManager.Get();
        if (result == null)
            return NotFound();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var result = await _contactManager.GetById(id);
        if (result == null)
            return NotFound();
        return Ok(result);
    }

    [HttpGet("firstname/{firstname}")]
    public async Task<IActionResult> GetByFirstname(string firstname)
    {
        var results = await _contactManager.GetByName(firstname);
        if (results == null || results.Length == 0)
            return NotFound();
        return Ok(results);
    }

    [HttpGet("phone/{phone}")]
    public async Task<IActionResult> GetByPhone(string phone)
    {
        var results = await _contactManager.GetByPhone(phone);
        if (results == null || results.Length == 0)
            return NotFound();
        return Ok(results);
    }

    [HttpPut]
    public async Task PutContact([FromBody] PutContactDto body)
    {
        await _contactManager.Put(body);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _contactManager.Delete(id);
        return Ok();
    }
}
using ContactsBook.Core.DataTransferObjects.Commands;
using ContactsBook.Core.DataTransferObjects.ViewModels;
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
    public ActionResult<ContactDto[]> GetAll()
    {
        var result = _contactManager.Get();
        if (result is null || result.Length == 0)
            return NotFound();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ContactDto>> Get([FromRoute] Guid id)
    {
        var result = await _contactManager.GetById(id);
        if (result == null)
            return NotFound();
        return Ok(result);
    }

    [HttpGet("firstname/{firstname}")]
    public ActionResult<ContactDto[]> GetByFirstname(string firstname)
    {
        var results = _contactManager.GetByName(firstname);
        if (results == null || results.Length == 0)
            return NotFound();
        return Ok(results);
    }

    [HttpGet("phone/{phone}")]
    public ActionResult<ContactDto[]> GetByPhone(string phone)
    {
        var results = _contactManager.GetByPhone(phone);
        if (results == null || results.Length == 0)
            return NotFound();
        return Ok(results);
    }

    [HttpPut]
    public async Task<IActionResult> PutContact([FromBody] UpdateContactDto body)
    {
        await _contactManager.Update(body);
        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult<ContactDto>> PostContact([FromBody] CreateContactDto body)
    {
        return await _contactManager.Create(body);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _contactManager.Delete(id);
        return Ok();
    }
}
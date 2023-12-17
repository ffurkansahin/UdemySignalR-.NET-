

using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer;
using SignalR.DtoLayer;

namespace SignalR.Api;

[Route("api/[controller]")]
[ApiController]
public class AboutController : ControllerBase
{
    private readonly IAboutService _aboutService;

    public AboutController(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }
    [HttpGet]
    public IActionResult AboutList()
    {
        var values = _aboutService.TGetList();
        return Ok(values);
    }
    [HttpPost]
    /* public IActionResult CreateAbout(CreateBookingDto createBookingDto)
    {
        _aboutService.TAdd(createBookingDto);
        return Ok("Okk");
    } */
    [HttpDelete("id")]
    public IActionResult DeleteAbout(int id)
    {
        var value = _aboutService.TGetById(id);
        _aboutService.TDelete(value);
        return Ok();
    }
    [HttpPut]
    /* public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
    {
        _aboutService.TUpdate(updateAboutDto);
        return Ok("Okk");
    } */
    [HttpGet("id")]
    public IActionResult GetAboutById(int id)
    {
        return Ok( _aboutService.TGetById(id));
    }
}



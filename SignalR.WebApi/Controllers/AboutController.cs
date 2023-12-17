

using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer;
using SignalR.DtoLayer;
using SignalR.EntityLayer.Entities;

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
    public IActionResult CreateAbout(CreateAboutDto createAboutDto)
    {
        About booking = new About()
        {
            Description = createAboutDto.Description,
            ImageUrl = createAboutDto.ImageUrl,
            Title = createAboutDto.Title,
        };
        _aboutService.TAdd(booking);
        return Ok("Okk");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteAbout(int id)
    {
        var value = _aboutService.TGetById(id);
        _aboutService.TDelete(value);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
    {
        About about = new About()
        {
            ID = updateAboutDto.ID,
            Title = updateAboutDto.Title,
            Description = updateAboutDto.Description,
            ImageUrl = updateAboutDto.ImageUrl,
        };
        _aboutService.TUpdate(about);
        return Ok("Okk");
    }
    [HttpGet("{id}")]
    public IActionResult GetAboutById(int id)
    {
        return Ok( _aboutService.TGetById(id));
    }
}



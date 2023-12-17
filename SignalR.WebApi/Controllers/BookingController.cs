﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer;
using SignalR.DtoLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult GetBookingList()
        {
            return Ok(_bookingService.TGetList());
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                Phone = createBookingDto.Phone,
                Description = createBookingDto.Description,
                PersonCount = createBookingDto.PersonCount,
            };
            _bookingService.TAdd(booking);
            return Ok("Booking completed");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Booking deleted");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                ID = updateBookingDto.ID,
                Name = updateBookingDto.Name,
                Phone = updateBookingDto.Phone,
                Description = updateBookingDto.Description,
                PersonCount = updateBookingDto.PersonCount,
                Date = updateBookingDto.Date,
                Mail=updateBookingDto.Mail,
            };
            _bookingService.TUpdate(booking);
            return Ok("Booking updated");
        }
        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id)
        {
            return Ok(_bookingService.TGetById(id));
        }
    }
}

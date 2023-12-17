using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer;
using SignalR.DtoLayer;
using SignalR.EntityLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetList());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount
            {
                Description = createDiscountDto.Description,
                Amount = createDiscountDto.Amount,
                ImageUrl = createDiscountDto.ImageUrl,
                Title = createDiscountDto.Title,
            });
            return Ok("Discount added");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("Discount deleted");
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount
            {
                ID = updateDiscountDto.ID,
                Amount = updateDiscountDto.Amount,
                Title = updateDiscountDto.Title,
                ImageUrl = updateDiscountDto.ImageUrl,
                Description = updateDiscountDto.Description,
            });
            return Ok("Discount updated");
        }
        [HttpGet("{id}")]
        public IActionResult GetDiscountById(int id)
        {
            return Ok(_discountService.TGetById(id));
        }
    }
}

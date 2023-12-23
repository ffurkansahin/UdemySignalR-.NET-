using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer;
using SignalR.DtoLayer;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _mapper.Map<List<ResultProductDto>>(_productService.TGetList());
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var values = _mapper.Map<List<ResultProductWithCategoriesDto>>(_productService.TGetProductsWithCategories());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product
            {
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Name = createProductDto.Name,
                Price = createProductDto.Price,
                Status = createProductDto.Status,
                CategoryId=createProductDto.CategoryID
            });
            return Ok("Product added");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Product deleted");
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product
            {
                ID = updateProductDto.ID,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Name = updateProductDto.Name,
                Price = updateProductDto.Price,
                Status = updateProductDto.Status,
                CategoryId =updateProductDto.CategoryID
            });
            return Ok("Product updated");
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(_productService.TGetById(id));
        }
    }
}

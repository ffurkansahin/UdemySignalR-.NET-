using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SignalR.WebUI.Dtos.CategoryDtos;
using SignalR.WebUI.Dtos.ProductDtos;
using System.Text;

namespace SignalR.WebUI.Controllers
{
	public class ProductController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public ProductController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:44378/api/Product/ProductListWithCategory");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> CreateProduct()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:44378/api/Category");
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
			List<SelectListItem> CategoryValues = (from x in values
												   select new SelectListItem
												   {
													   Text = x.Name,
													   Value = x.ID.ToString()
												   }).ToList();
			ViewBag.CategoryValues = CategoryValues;
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateProduct(CreateProductDto dto)
		{
			dto.Status = true;
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(dto);
			StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
			var responseMessage = await client.PostAsync("https://localhost:44378/api/Product", stringContent);
			if(responseMessage.IsSuccessStatusCode) 
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		public async Task<IActionResult> DeleteProduct(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:44378/api/Product/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		public async Task<IActionResult> UpdateProduct(int id)
		{
			var client2 = _httpClientFactory.CreateClient();
			var responseMessage2 = await client2.GetAsync("https://localhost:44378/api/Category");
			var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
			var values2 = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData2);
			List<SelectListItem> CategoryValues = (from x in values2
												   select new SelectListItem
												   {
													   Text = x.Name,
													   Value = x.ID.ToString()
												   }).ToList();
			ViewBag.CategoryValues = CategoryValues;
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:44378/api/Product/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UpdateProduct(UpdateProductDto dto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(dto);
			StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
			var responseMessage = await client.PutAsync($"https://localhost:44378/api/Product",stringContent);
			if(responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

	}
}

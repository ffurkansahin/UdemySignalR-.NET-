namespace SignalR.WebUI.Dtos.ProductDtos
{
	public class ResultProductDto
	{
		public int ID { get; set; }
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public double Price { get; set; }
		public string? ImageUrl { get; set; }
		public bool Status { get; set; }
		public string? CategoryName { get; set; }

	}
}

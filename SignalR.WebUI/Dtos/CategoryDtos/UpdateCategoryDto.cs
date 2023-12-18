namespace SignalR.WebUI.Dtos.CategoryDtos
{
	public class UpdateCategoryDto
	{
		public int ID { get; set; }
		public string Name { get; set; } = null!;
		public bool Status { get; set; }
	}
}

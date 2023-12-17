using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ProductDto
{
    public class ResultProductWithCategoriesDto
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

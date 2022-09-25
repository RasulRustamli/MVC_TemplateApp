namespace MVC_TemplateApp.DTOs.Product;


    public class CreateProductDto
    {
        public string Name { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; } 
        public decimal StartPrice { get; set; }
        public decimal Price { get; set; }
        public double Rate { get; set; }
        public IFormFileCollection ProductPhotos { get; set; } 
    }


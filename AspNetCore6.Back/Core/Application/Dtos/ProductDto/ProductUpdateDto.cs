﻿using AspNetCore6.Back.Core.Domain;

namespace AspNetCore6.Back.Core.Application.Dtos.ProductDto
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}

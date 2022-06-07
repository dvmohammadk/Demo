using DemoTest.Domain.Enum;
using System;
using Type = DemoTest.Domain.Enum.Type;

namespace DemoTest.Domain.Interfaces
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Tilte { get; set; }
        public Type Type { get; set; }
        public double Price { get; set; }
        public Color Color { get; set; }
    }
}

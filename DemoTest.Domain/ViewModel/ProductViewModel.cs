using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest.Domain.ViewModel
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Tilte { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
    }
}

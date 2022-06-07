using DemoTest.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = DemoTest.Domain.Enum.Type;

namespace DemoTest.Domain.Entites.Product
{
    #region Prop
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Tilte { get; set; }
        public Type Type { get; set; }
        public double Price { get; set; }
        public Color Color { get; set; }

    }
    #endregion
    #region Rel
    #endregion
}

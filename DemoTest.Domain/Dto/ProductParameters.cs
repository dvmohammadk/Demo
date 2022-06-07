using DemoTest.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = DemoTest.Domain.Enum.Type;

namespace DemoTest.Domain.Dto
{
    public class ProductParameters: QueryStringParameters
    {
        //اضافه کردن این فیلد جدید برای جست و جو
        public Type? Type { get; set; }
        public Color? Color { get; set; }

    }
}

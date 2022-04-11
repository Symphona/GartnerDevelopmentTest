using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GartnerDevelopmentTest.Model
{
    public class SoftwareAdviceJsonEntity
    {
        public Product[] products { get; set; }

    }

    public class Product
    {
        public string title { get; set; }
        public string? twitter { get; set; }
        public string[] categories { get; set; }
    }
}

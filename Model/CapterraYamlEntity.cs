using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GartnerDevelopmentTest.Model
{
    public class CapterraYamlEntity
    {
        public YamlRowEntity[] Rows { get; set; }

    }

    public class YamlRowEntity
    {
        public string tags { get; set; }
        public string name { get; set; }
        public string twitter { get; set; }
    }
}

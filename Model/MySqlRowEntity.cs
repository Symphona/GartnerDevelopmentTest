using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GartnerDevelopmentTest.Model
{
    public class MySqlRowEntity
    {

        public string[] Tags { get; set; }
        public string Name { get; set; }
        public string? Twitter { get; set; }

        public MySqlRowEntity(string[] tags, string name, string? twitter)
        {
            Tags = tags;
            Name = name;
            Twitter = twitter;
        }
    }
}

using GartnerDevelopmentTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GartnerDevelopmentTest.Input_Readers
{
    public interface IFileReader
    {
        List<MySqlRowEntity> Read(string v);
    }
}

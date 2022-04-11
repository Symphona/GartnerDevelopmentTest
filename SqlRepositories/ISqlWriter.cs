using GartnerDevelopmentTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GartnerDevelopmentTest.SqlRepositories
{
    public interface ISqlWriter
    {
        public void Write(List<MySqlRowEntity> entities);

    }
}

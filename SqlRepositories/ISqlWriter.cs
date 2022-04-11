using GartnerDevelopmentTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GartnerDevelopmentTest.SqlRepositories
{
    /// <summary>
    /// Unused, created as an example for if a new Database engine is selected
    /// </summary>
    public interface ISqlWriter
    {
        public void Write(List<MySqlRowEntity> entities);

    }
}

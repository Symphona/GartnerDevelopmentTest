using GartnerDevelopmentTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GartnerDevelopmentTest.SqlRepositories
{
    public static class MysqlWriter //: ISqlWriter - Can be added later and abstracted for new Database model
    {
        
        public static void Write(List<MySqlRowEntity> entities)
        {
            //TODO - Ensure updating any existing information is handled, if needed
            throw new NotImplementedException();
        }
    }
}

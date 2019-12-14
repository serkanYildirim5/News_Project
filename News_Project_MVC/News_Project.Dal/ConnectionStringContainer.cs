using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Project.Dal
{
    public class ConnectionStringContainer
    {
        internal static string ConnectionString
        {
            get { return "Server=.;Database=News_ProjectDB;User Id=SA;Password = 123;MultipleActiveResultSets=true;"; }
        }
    }
}

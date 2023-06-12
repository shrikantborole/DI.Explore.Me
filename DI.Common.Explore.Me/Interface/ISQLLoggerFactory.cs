using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Common.Explore.Me.Interface
{
    public interface ISQLLoggerFactory
    {
        public ILogger CreateRefernceGenerator(string connectionString);
    }
}

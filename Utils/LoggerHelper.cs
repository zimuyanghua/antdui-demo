using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntdUIDemo.Utils
{
    public static class LoggerHelper
    {
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    }
}

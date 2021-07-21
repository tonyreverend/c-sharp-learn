using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsers
{
    abstract class Browser
    {
        public abstract bool CheckBrowser(BrowserType type);

        public abstract BrowserType GetBrowser();
    }
}

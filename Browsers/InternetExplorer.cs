using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsers
{
    class InternetExplorer : Browser
    {
        public override bool CheckBrowser(BrowserType type)
        {
            if (type == BrowserType.InternetExplorer)
                return true;
            else
                return false;
        }

        public override BrowserType GetBrowser()
        {
            return BrowserType.InternetExplorer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsers
{
    class Firefox : Browser
    {
        public override bool CheckBrowser(BrowserType type)
        {
            if (type == BrowserType.Firefox)
                return true;
            else
                return false;
        }

        public override BrowserType GetBrowser()
        {
            return BrowserType.Firefox;
        }
    }
}

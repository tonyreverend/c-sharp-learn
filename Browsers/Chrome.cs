using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsers
{
    class Chrome : Browser
    {
        public override bool CheckBrowser(BrowserType type)
        {
            if (type == BrowserType.Chrome)
                return true;
            else
                return false;
        }

        public override BrowserType GetBrowser()
        {
            return BrowserType.Chrome;
        }
    }
}

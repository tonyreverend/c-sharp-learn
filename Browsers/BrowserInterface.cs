using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsers

{
    interface BrowserInterface
    {
        public bool CheckBrowser(BrowserType type);

        public BrowserType GetBrowser();
    }
}

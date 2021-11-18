using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    interface IParse
    {
        List<Search> AnalizeFile(Search mySearch, string path);
    }
}

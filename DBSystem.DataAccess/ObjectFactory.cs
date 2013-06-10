using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBSystem.DataAccess
{
    public class ObjectFactory<TDTO,TEntiy>:MasterDataAccess
        where TDTO:class
        where TEntiy:class
    {
    }
}

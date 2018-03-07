using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    //can have more than one interface inside namespace
    interface Db2
    {
        void Delete();
    }
    interface Db3
    {
        string CreateNewDb { set; get; }
        void Create();
    }
}

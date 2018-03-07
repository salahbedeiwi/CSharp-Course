using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db1NameSpace
{
    interface Db1
    {
        //can't define fields/attributes
        //methods don't have any body content
        //can't include public/private/protected at all
        //can't create/declare a variable of it
        //can't create an object of it

        //create property: getter & setter - must not return anything
        string ConnectionString { get; set; } //acts like abstract. must be used

        //create method: must use everything here - must be empty
        void Add();
        void Update();
    }
}

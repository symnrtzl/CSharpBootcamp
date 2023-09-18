using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Burası tek başına bir anlam ifade etmiyor.
    //İmzanın aynı olduğu ( Calculate() method ) ama içerisinin farklı olduğu classları interface olarak tanımlarız.
    //
    interface ICreditManager
    {
        public void Calculate();
    }
}

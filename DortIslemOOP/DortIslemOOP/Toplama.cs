using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslemOOP
{
    internal class Toplama : DortIslem
    {
        private int _a;
        private int _b;
        public void islem(int a,int b)
        {
            this._a = a;
            this._b = b;
            IsimBelirle("Toplama");
            IsaretBelirle("+");
        }
        public override double Hesapla()
        {
            return _a + _b;
        }
    }
}

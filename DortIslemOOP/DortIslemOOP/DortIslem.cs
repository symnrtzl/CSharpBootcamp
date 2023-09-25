using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslemOOP
{
    abstract class DortIslem
    {
        private String _isim;
        private String _isaret;
        public void IsimBelirle(String isim)
        {
            this._isim = isim;
        }
        public String IsimGetir()
        {
            return this._isim;
        }
        public void IsaretBelirle(String isaret)
        {
            this._isaret = isaret;
        }
        public string IsaretGetir()
        {
            return this._isaret; 
        }
        public abstract double Hesapla(); 
    }
}

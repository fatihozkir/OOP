using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract_Interface
{
    public class Tofas:ArabaBase,IModifiye
    {
        public override string Calistir()
        {
            return this.Marka + " " + this.Model + " Çalıştı !";
        }

        public override string Durdur()
        {
            return this.Marka + " " + this.Model + " Durdu !";
        }

        public string HavayaKalk()
        {
            return this.Marka + " " + this.Model + " Havaya Kalktı !";
        }

        public string RahatsizEt()
        {
            return this.Marka + " " + this.Model + " Çevreye rahatsızlık verildi !";
        }

        public string EgzozPatlat()
        {
            return this.Marka + " " + this.Model + " Egzoz Patlatıldı !";
        }
    }
}

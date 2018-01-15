using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract_Interface
{
    public abstract class ArabaBase
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public float MotorHacmi { get; set; }
        public int UretimYili { get; set; }
        public abstract string Calistir();
        public abstract string Durdur();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw316=new Bmw();
            bmw316.Marka = "BMW";
            bmw316.Model = "3.16";
            bmw316.MotorHacmi = 1.6f;
            bmw316.Renk = "Siyah";
            bmw316.UretimYili = 2015;
            bmw316.CelikJant = true;

            Console.WriteLine(bmw316.Calistir());
            Console.WriteLine(bmw316.Durdur()+Environment.NewLine);

            //Object Initializer yöntemi ile değerlerin verilmesi !
            Volkswagen vwPassat = new Volkswagen
            {
                Model = "Passat",
                Marka = "Volkswagen",
                MotorHacmi = 2.0f,
                Renk = "Beyaz",
                UretimYili = 2015,
                AutoPilot = true
            };

            Console.WriteLine(vwPassat.Calistir());
            Console.WriteLine(vwPassat.Durdur() + Environment.NewLine);

            Tofas dogan = new Tofas
            {
                Model = "Doğan SLX",
                Marka = "Tofaş",
                MotorHacmi = 1.6f,
                Renk = "Bordo",
                UretimYili = 1998
            };

            Console.WriteLine(dogan.Calistir());
            Console.WriteLine(dogan.Durdur());
            //Diğer Araçların çalıştır ve durdur Temel Fonksiyonlarından Farklı Olarak Tofaş'a interface vasıtası ile yetenekler kazandırıldı ! Interface bir class'a yeni yetenekler kazandırmak için vardır.
            //Aşağıdaki metodlar ise Interface ile arabaya kazandırdığımız metodlardır !
            Console.WriteLine(dogan.EgzozPatlat());
            Console.WriteLine(dogan.HavayaKalk());
            Console.WriteLine(dogan.RahatsizEt());



            Volkswagen golfVolkswagen = new Volkswagen
            {
                MotorHacmi = 2.0f,
                Renk = "Gri",
                Marka = "Volkswagen",
                UretimYili = 2017,
                Model = "Golf",
                AutoPilot = true
            };

            //UpCast liskov substitution Yerine Geçme Prensibi yaptık !
            ArabaBase temelVolkswagen = (ArabaBase) golfVolkswagen;
            //Burada gördüğümüz gibi golkfVolkswagen nesnesi ArabaBase e cast edildiği için autopilot propertysine ulaşamadık !
            
            Console.WriteLine("\n"+temelVolkswagen.Marka + " \n" + temelVolkswagen.Model + "\n" +
                              temelVolkswagen.MotorHacmi + "\n" + temelVolkswagen.Renk + "\n" +
                              temelVolkswagen.UretimYili);

            ArabaBase sahinTofas = new Tofas
            {
                Model = "Şahin",
                MotorHacmi = 1.6f,
                Renk = "Beyaz",
                Marka = "Tofaş",
                UretimYili = 1996
            };

            //Yine Burada da göreceğimiz üzere şahintofaş nesnesini arababase'e cast ettiğimiz için çalıştır ve durdur harici diğer metodlara erişimi sağlayamadık !

            Console.WriteLine("\n" + sahinTofas.Marka + " \n" + sahinTofas.Model + "\n" +
                              sahinTofas.MotorHacmi + "\n" + sahinTofas.Renk + "\n" +
                              sahinTofas.UretimYili);
            Console.WriteLine(sahinTofas.Calistir());
            Console.WriteLine(sahinTofas.Durdur());


            Console.ReadKey();

        }
    }
}

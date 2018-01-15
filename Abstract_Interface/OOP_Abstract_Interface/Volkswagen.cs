namespace OOP_Abstract_Interface
{
    public class Volkswagen : ArabaBase
    {
        public bool AutoPilot { get; set; }
        public override string Calistir()
        {
            return this.Marka+" "+ this.Model +" Araba Çalıştı !";
        }

        public override string Durdur()
        {
            return this.Marka + " " + this.Model + " Araba Durdu !";
        }
    }
}
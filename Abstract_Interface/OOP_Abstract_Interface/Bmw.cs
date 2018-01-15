namespace OOP_Abstract_Interface
{
    public class Bmw : ArabaBase
    {
        public bool CelikJant { get; set; }
        public override string Calistir()
        {
            return this.Marka + " " + this.Model + " Araba Çalıştı !";
        }

        public override string Durdur()
        {
            return this.Marka + " " + this.Model + " Araba Durdu !";
        }
    }
}
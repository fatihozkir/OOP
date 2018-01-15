namespace OOP_Abstract_Interface
{
    public interface IModifiye
    {
        //Bu interface'i istediğiniz arabaya uygulayabilirsiniz. Bunu uyguladığınız anda araba tüm bu özelliklere sahip olur.
        //Fakat biz bunları abstract üzerinde yapmış olsaydık tüm arabalar arababase'den miras alacağı için o arabalarda bu fonksiyonlara sahip olacaktı. Bundan dolayı Interfaceler opsiyonel seçenekleri classlara kazandırmamız için bize olanak sağlarlar.
        string HavayaKalk();
        string RahatsizEt();
        string EgzozPatlat();
    }
}
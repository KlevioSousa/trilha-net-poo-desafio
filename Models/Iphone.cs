namespace DesafioPOO.Models
{
    // Classe Nokia herda da classe abstrata Smartphone
    public class Iphone : Smartphone
    {
        // Construtor da classe Nokia, chamando o construtor base da classe Smartphone
        public Iphone (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // Sobrescrevendo o método abstrato InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
    }
}
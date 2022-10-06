using System;

namespace DesafioPOO.Models 
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo... \nAplicativo {nomeApp.ToUpper()} instalado com sucesso!!");    
        }
    }
}

using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Console.Write("Digite seu número: ");
            string numero = Console.ReadLine();
            Console.Write("Digite o modelo do seu smartphone: ");
            string modelo = Console.ReadLine();
            Console.Write("Informe qual o seu IMEI: ");
            string imei = Console.ReadLine();
            Console.Write("Capacidade de memória: ");
            int memoria = int.Parse(Console.ReadLine());
            Smartphone nokia = new Nokia(numero: numero, modelo: modelo, IMEI: imei, memoria: memoria);
            nokia.Ligar();
            Console.Write("Qual aplicativo deverá ser instalado? ");
            string app = Console.ReadLine();
            nokia.InstalarAplicativo(app);

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone:");
            Console.Write("Digite seu número: ");
            numero = Console.ReadLine();
            Console.Write("Digite o modelo do seu smartphone: ");
            modelo = Console.ReadLine();
            Console.Write("Informe qual o seu IMEI: ");
            imei = Console.ReadLine();
            Console.Write("Capacidade de memória: ");
            memoria = int.Parse(Console.ReadLine());
            Smartphone iphone = new Iphone(numero: numero, modelo: modelo, IMEI: imei, memoria: memoria);
            iphone.Ligar();
            Console.Write("Qual aplicativo deverá ser instalado? ");
            app = Console.ReadLine();
            iphone.InstalarAplicativo(app);
        }
    }
}

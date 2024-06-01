using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public Smartphone(string numero, string modelo, string marca)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo) : base(numero, modelo, "Nokia") { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} na loja da Nokia...");
        }
    }

    public class IPhone : Smartphone
    {
        public IPhone(string numero, string modelo) : base(numero, modelo, "iPhone") { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} na App Store...");
        }
    }
}
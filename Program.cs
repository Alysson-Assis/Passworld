using System;
using System.Text;

namespace PasswordGenerator{
    class Program{
        static void Main(string[] args){
            //Numero de caracteres
            Console.Write("Digite quantos caracteres a senha terá: ");
            int qtd = int.Parse(Console.ReadLine());

            string caracteresPossiveis =
            "ABCDEFJHIJKLMNOPQRSTUVWXYZÇ" + 
            "ABCDEFJHIJKLMNOPQRSTUVWXYZÇ".ToLower() + 
            "0123456789" + "!@#$&";

            //Aletioriedade
            Random sorteio = new Random();
            //variavel que vai receber o numeros aleatorios
            int numeroSorteado = 0;
            StringBuilder password = new StringBuilder();

            //Vai fazer o loop de qtd.
            for(int i =0; i < qtd; i++){
                numeroSorteado= sorteio.Next(0, caracteresPossiveis.Length -1);
                password.Append(caracteresPossiveis[numeroSorteado]);
            }
            Console.WriteLine(password);
        }
    }
}

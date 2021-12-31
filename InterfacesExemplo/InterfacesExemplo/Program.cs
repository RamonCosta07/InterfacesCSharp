using InterfacesExemplo.Interfaces;
using System;

namespace InterfacesExemplo
{
    class Program
    {
        /* Implementação de uma interface
         * ICalculadora, no qual seus métodos
         * serão implementados pela classe calculadora
         * colocando em prática conceitos de interface
         */
        static void Main(string[] args)
        {
            ICalculadora calc = new Calculadora();
            Console.WriteLine(calc.Somar(4, 6));
        }
    }
}

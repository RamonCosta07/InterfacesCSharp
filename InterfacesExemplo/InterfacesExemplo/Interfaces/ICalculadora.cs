using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExemplo.Interfaces
{
    interface ICalculadora // Por padrão as interfaces começam com I
    {
        /* Iremos colocar apenas a assinatura dos métodos
         * E o tipo de retorno,
         * com os seus parâmetros. Exceto pelo método
         * de dividir. Não precisamos do get e set
         * Pois por padrão os modificadores de acesso em
         * interfaces são públicos
         */
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        double Dividir(int num1, int num2) {
            return num1 / num2;
        }


    }
}

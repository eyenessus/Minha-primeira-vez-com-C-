using System;
using System.Collections;
using System.Collections.Generic;
namespace ATV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto;
            double valor_unitario;
            int quantidade;
            char fim = 's';
            do
            {
                Console.Clear();
                Console.WriteLine("Olá, poderia informa o pedido?");
                produto = Console.ReadLine();
                Console.WriteLine("Qual valor?");
                valor_unitario = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a quantidade?");
                quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine("Deseja adicionar outro pedido?");
                fim = char.Parse(Console.ReadLine());;
            } while (fim == 's');
            Console.WriteLine(quantidade+" "+produto+", valor total de R$"+(quantidade*valor_unitario));
        }
    }
}

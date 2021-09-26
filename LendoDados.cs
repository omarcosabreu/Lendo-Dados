using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class LendoDados 
        {
         public static void Executar() {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Qual é a sua cidade? ");
            string cidade = Console.ReadLine();

            
            Console.WriteLine($"Seu nome é {nome}, " +
                $"você tem {idade} anos, o seu salário é de R${salario}  " +
                $"e a sua cidade é {cidade}.");
        }
    }
}

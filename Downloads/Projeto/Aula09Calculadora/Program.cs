using System;

namespace Aula09Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
                CalculadoraCientifica calc = new CalculadoraCientifica();
            Console.WriteLine("Digite uma operação (soma, multiplicação, subtração e divisão ). No seguinte formato: 25 x 3");
            calc.ControlarMetodos( Console.ReadLine() );
            Console.WriteLine("Resultado:"+calc.resultado);

            Console.WriteLine("Digite números separados por ponto e vírgula (;) para calcular a média");
            calc.CalcularMedia(Console.ReadLine());
             Console.WriteLine("Resultado da média:"+calc.resultado);
        }
    }
}

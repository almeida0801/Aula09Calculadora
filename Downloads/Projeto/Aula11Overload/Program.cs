using System;

namespace Aula11Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoDoPersonagem infojogador = new CalculoDoPersonagem();

            // primeira opção, sem argumentos
            System.Console.WriteLine( infojogador.Calcular() );

            // segunda opção, 1 argumento do tipo int
            System.Console.WriteLine( infojogador.Calcular(100) );

            // terceira opção, 2 argumentos do tipo int
            System.Console.WriteLine( infojogador.Calcular(100, 80) );

            // quarta opção, 2 argumentos do tipo string
            System.Console.WriteLine( infojogador.Calcular("Paulo", "Brandão") );


        }
    }
}

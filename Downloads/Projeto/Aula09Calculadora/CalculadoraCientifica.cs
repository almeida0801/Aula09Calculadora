namespace Aula09Calculadora
{
    public class CalculadoraCientifica : Calculadora
    {
        private string [] valores { get; set;}

        private float soma { get; set; }

        public void CalcularMedia(string txtConsole){
               // O Split serve para separar os números
            // Em uma sequência por exemplo: 16;28;14;17;43
            // valores[0] = 16
            // valores[1] = 28
            // valores[2] = 14
            // valores[3] = 17
            // valores[4] = 43
                
            valores = txtConsole.Split(";");

            for (int i = 0; i < valores.Length; i++)
            {
                //Varredor de valores
                soma += float.Parse(valores[i]);
            }

            resultado = soma / valores.Length;
        }

        public void ControlarMetodos(string entradaUsuario){
                // 25 x 3
                // dados [0] = 25
                // dados [1] = x
                // dados [2] = 3
            string[] dados = entradaUsuario.Split(" ");

            numero1 = float.Parse(dados[0]);
            operador = dados[1];
            numero2 = float.Parse(dados[2]);

            switch (operador)
            {
                case "+":
                Somar();
                break;

                case "-":
                Subtrair();
                break;

                case "/":
                Dividir();
                break;
                
                case "*":
                Multiplicar();
                break;

                default:
                Somar();
                break;
            }
        }
    }
}
namespace Aula11Overload
{
    public class CalculoDoPersonagem
    {
        public string Calcular(){
            return "Não tem calculo a ser aprlicado";
        }
        public string Calcular( int vida ){
            return "O jogador está com uma vida de "+vida;
        }
        public string Calcular( int vida, int escudo ){
            return "A vida do jogador mais o escudo que foi aplicado é de "+(vida+escudo);
        }
        public string Calcular( string nome, string sobrenome ){
            return $"O nome completo do jogador é {nome} {sobrenome}";
        }



    }
}
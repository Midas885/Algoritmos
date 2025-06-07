

namespace Algoritmos.P1
{
    public class Carta
    {
        public string Palo { get; } 
        public string Valor { get; } 

        public Carta(string palo, string valor)
        {
            Palo = palo;
            Valor = valor;
        }

        public override string ToString() => $"{Valor} de {Palo}";

    }
}

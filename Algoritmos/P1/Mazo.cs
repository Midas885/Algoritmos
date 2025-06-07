




namespace Algoritmos.P1
{
    using System;
    using System.Collections.Generic;

    public class Mazo
    {
        private List<Carta> cartas;
        private Random random = new Random();

        public Mazo()
        {
            InicializarMazo();
        }

        private void InicializarMazo()
        {
            string[] palos = { "Corazones", "Diamantes", "Picas", "Treboles" };
            string[] valores = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jota", "Reina", "Rey" };

            cartas = new List<Carta>();

            foreach (var palo in palos)
            {
                foreach (var valor in valores)
                {
                    cartas.Add(new Carta(palo, valor));
                }
            }
        }

        public void Barajar()
        {
            for (int i = cartas.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Carta temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp;
            }
        }

        public List<Carta> Repartir(int cantidad)
        {
            if (cantidad > cartas.Count)
                throw new InvalidOperationException(" No hay suficientes cartas en el mazo.");

            List<Carta> cartasRepartidas = cartas.GetRange(0, cantidad);
            cartas.RemoveRange(0, cantidad);
            return cartasRepartidas;
        }

        public void MostrarMazo()
        {
            foreach (var carta in cartas)
            {
                Thread.Sleep(100);
                Console.WriteLine($"    {carta}");
            }
        }

        public int CartasRestantes() => cartas.Count;
    }
}

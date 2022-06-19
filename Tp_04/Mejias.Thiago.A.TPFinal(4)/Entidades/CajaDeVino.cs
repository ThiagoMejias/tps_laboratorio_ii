using Entidades.Archivos;


namespace Entidades
{
    public class CajaDeVino
    {
        public enum Tipo
        {
            tinto, blanco, rosado, espumante
        }

        public Tipo tipo;
        public static int cantidadDeVinos;

        public CajaDeVino()
        {

        }
        static CajaDeVino()
        {
            CajaDeVino.cantidadDeVinos = 6;
        }
        public CajaDeVino(Tipo tipo)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(CajaDeVino c1, CajaDeVino c2)
        {

            return c1 is not null && c2 is not null && c1.tipo == c2.tipo;
        }
        public static bool operator !=(CajaDeVino c1, CajaDeVino c2)
        {
            return !(c1 == c2);
        }

        public string Mostrar()
        {
            return $"Tipo: {this.tipo}\n\n";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
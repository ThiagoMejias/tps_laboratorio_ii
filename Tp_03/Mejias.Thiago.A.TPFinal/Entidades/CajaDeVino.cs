namespace Entidades
{
    public class CajaDeVino
    {
        string marca;
        string tipo;
        public static int cantidadDeVinos;

        static CajaDeVino()
        {
            CajaDeVino.cantidadDeVinos = 6;
        }
        public CajaDeVino(string marca, string tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
        }

        public string Mostrar()
        {
            return $"Marca: {this.marca} , Tipo:{this.tipo}";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        DateTime fechaDeNacimiento;
        private string nombreCompleto;
        private int dni;
        private string direccion;
        private float deuda;

        public int Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public float Deuda { get => deuda; set => deuda = value; }

        public Cliente()
        {
        }
        public Cliente(DateTime fechaDeNacimiento, string nombre, int dni, string direccion, float deuda)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.nombreCompleto = nombre;
            this.deuda = deuda;
            this.dni = dni;
            this.direccion = direccion;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombreCompleto}");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"El monto a pagar es: {this.Deuda}");
            return sb.ToString();
        }

        public static bool operator ==(Cliente c, Cliente c2)
        {
            return c is not null && c2 is not null && c.Dni == c2.Dni;
        }

        public static bool operator !=(Cliente c, Cliente c2)
        {
            return !(c == c2);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente is not null && cliente == this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    // Clase abstracta Cliente
    public abstract class Cliente
    {
        public int NumeroDeSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public decimal Cuota { get; set; }
        public Membresia Membresia { get; set; }

        // Devuelve el importe del descuento por tipo de cliente
        public abstract decimal ImporteDescuentoPorTipo();

        // Neto a pagar = Cuota - descuentoTipo - descuentoMembresia
        public decimal CalcularNeto()
        {
            decimal descuentoTipo = ImporteDescuentoPorTipo();
            decimal descuentoMembresia = Membresia?.Importe ?? 0m;
            return Cuota - descuentoTipo - descuentoMembresia;
        }
    }

    public class ClientePrincipiante : Cliente
    {
        public override decimal ImporteDescuentoPorTipo() => Math.Round(Cuota * 0.15m, 2);
    }

    public class ClienteIntermedio : Cliente
    {
        public override decimal ImporteDescuentoPorTipo() => Math.Round(Cuota * 0.08m, 2);
    }

    public class ClienteAvanzado : Cliente
    {
        public override decimal ImporteDescuentoPorTipo() => Math.Round(Cuota * 0.03m, 2);
    }
}
